namespace CedarAPI;

public static class ProcessArgumentBuilder
{
    public static void AddArgument(this System.Collections.ObjectModel.Collection<string> arguments, string argumentName, string? argumentValue)
    {
        arguments.Add(argumentName);
        if(argumentValue is not null)
            arguments.Add(argumentValue);
    }
}
