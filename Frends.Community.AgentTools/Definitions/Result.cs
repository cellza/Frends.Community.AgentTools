namespace Frends.Community.AgentTools.Definitions;

/// <summary>
/// Result class usually contains properties of the return object.
/// </summary>
public class Result
{

    internal Result(bool output)
    {
        this.Output = output;
    }

    /// <summary>
    /// Gets a value wheter the host is reachable.
    /// </summary>
    /// <example>Example of the output.</example>
    public bool Output { get; private set; }
}
