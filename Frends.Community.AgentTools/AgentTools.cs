namespace Frends.Community.AgentTools;

using System.ComponentModel;
using System.Threading;
using Frends.Community.AgentTools.Definitions;
using System.Net.NetworkInformation;
using System.Net;

/// <summary>
/// Main class of the Task.
/// </summary>
public static class NetworkTools
{
    /// <summary>
    /// Ping a ipv4 address.
    /// </summary>
    /// <param name="nameOrAddress">Ip or hostaddress of the host.</param>
    /// <param name="options">Define if repeated multiple times. </param>
    /// <param name="cancellationToken">Cancellation token given by Frends.</param>
    /// <returns>Object { string Output }.</returns>
    public static Result Ping([PropertyTab] Input nameOrAddress, [PropertyTab] Options options, CancellationToken cancellationToken)
    {
        bool pingable = false;
        Ping pinger = null;

        try
        {
            pinger = new Ping();
            PingReply reply = pinger.Send(nameOrAddress.Content);
            pingable = reply.Status == IPStatus.Success;
        }
        catch (PingException)
        {
            // Discard PingExceptions and return false;
        }
        finally
        {
            if (pinger != null)
            {
                pinger.Dispose();
            }
        }

        var output = new Result(pingable);
        return output;
    }

}
