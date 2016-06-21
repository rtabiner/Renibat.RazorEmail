using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Renibat.RazorEmail.Extensions
{
    public static class StringExtensions
    {
        public static string ReadFilePathContentToString(this string path)
        {
            string content;

            using (var reader = new StreamReader(path))
            {
                content = reader.ReadToEnd();
            }

            return content;
        }
        public static string CreateBreakTagsForParsedContent(this string input, string tagPlaceholderName = "breaks")
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var contentBreakMatches = Regex.Match(input, string.Format(@"(?<=<{0}>)[^><]+?(?=</{0}>)", tagPlaceholderName), RegexOptions.IgnorePatternWhitespace);

            if (!contentBreakMatches.Success)
                return input;

            return input.Replace(contentBreakMatches.Groups[0].Value, contentBreakMatches.Groups[0].Value.Replace(Environment.NewLine, "<br />"));
        }
    }
}
