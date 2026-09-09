public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter)
    {
        int delimiterIndex = str.IndexOf(delimiter);

        return str.Substring(delimiterIndex + delimiter.Length);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type

    public static string SubstringBetween(
        this string str,
        string startDelimiter,
        string endDelimiter)
    {
        int startIndex = str.IndexOf(startDelimiter) + startDelimiter.Length;

        int endIndex = str.IndexOf(endDelimiter, startIndex);

        return str.Substring(startIndex, endIndex - startIndex);
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
public static string Message(this string log)
    {
        return log.SubstringAfter(": ");
    }
    

    // TODO: define the 'LogLevel()' extension method on the `string` type

    public static string LogLevel(this string log)
    {
        return log.SubstringBetween("[", "]");
    }
}