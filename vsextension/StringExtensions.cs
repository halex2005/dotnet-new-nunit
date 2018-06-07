namespace NUnitTemplatesVsix
{
    static class StringExtensions
    {
        public static string NullIfEmpty(this string source)
        {
            return string.IsNullOrEmpty(source)
                ? null
                : source;
        }
    }
}