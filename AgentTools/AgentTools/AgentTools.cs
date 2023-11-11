namespace Frends.Community.AgentTools;

using System.ComponentModel;
using System.Threading;
using Frends.Community.AgentTools.Definitions;

/// <summary>
/// Main class of the Task.
/// </summary>
public static class NetworkTools
{
    /// <summary>
    /// Ping a ipv4 address.
    /// </summary>
    /// <param name="input">What to repeat.</param>
    /// <param name="options">Define if repeated multiple times. </param>
    /// <param name="cancellationToken">Cancellation token given by Frends.</param>
    /// <returns>Object { string Output }.</returns>
    public static Result Ping([PropertyTab] Input input, [PropertyTab] Options options, CancellationToken cancellationToken)
    {
        var repeats = new string[options.Amount];

        for (var i = 0; i < options.Amount; i++)
        {
            // It is good to check the cancellation token somewhere you spend lot of time, e.g. in loops.
            cancellationToken.ThrowIfCancellationRequested();
            repeats[i] = input.Content;
        }

        var output = new Result(string.Join(options.Delimiter, repeats));

        return output;
    }

    /// <summary>
    /// Test if a specific port is open to a fqdn or ipaddress.
    /// </summary>
    /// <param name="input">What to repeat.</param>
    /// <param name="options">Define if repeated multiple times. </param>
    /// <param name="cancellationToken">Cancellation token given by Frends.</param>
    /// <returns>Object { string Output }.</returns>
    public static Result TestConnection([PropertyTab] Input input, [PropertyTab] Options options, CancellationToken cancellationToken)
    {
        var repeats = new string[options.Amount];

        for (var i = 0; i < options.Amount; i++)
        {
            // It is good to check the cancellation token somewhere you spend lot of time, e.g. in loops.
            cancellationToken.ThrowIfCancellationRequested();
            repeats[i] = input.Content;
        }

        var output = new Result(string.Join(options.Delimiter, repeats));

        return output;
    }

    /// <summary>
    /// Get basic network information for the agent.
    /// </summary>
    /// <param name="input">What to repeat.</param>
    /// <param name="options">Define if repeated multiple times. </param>
    /// <param name="cancellationToken">Cancellation token given by Frends.</param>
    /// <returns>Object { string Output }.</returns>
    public static Result GetNetworkInfo([PropertyTab] Input input, [PropertyTab] Options options, CancellationToken cancellationToken)
    {
        var repeats = new string[options.Amount];

        for (var i = 0; i < options.Amount; i++)
        {
            // It is good to check the cancellation token somewhere you spend lot of time, e.g. in loops.
            cancellationToken.ThrowIfCancellationRequested();
            repeats[i] = input.Content;
        }

        var output = new Result(string.Join(options.Delimiter, repeats));

        return output;
    }
}
