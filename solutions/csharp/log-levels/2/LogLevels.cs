static class LogLine
{
    public static string Message(string logLine){
        int index = logLine.Trim().IndexOf(' ');
        return logLine.Remove(0 , index+1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int index = logLine.Trim().IndexOf(']');
        string level = logLine.Remove(index , logLine.Length-index).Trim();
        return level.Remove(0,1).ToLowerInvariant();
    }

    public static string Reformat(string logLine)
    => $"{Message(logLine)} ({LogLevel(logLine)})" ;
}
