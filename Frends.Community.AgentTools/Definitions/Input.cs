namespace Frends.Community.AgentTools.Definitions;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net;

/// <summary>
/// Input class usually contains parameters that are required.
/// </summary>
public class Input
{
    /// <summary>
    /// Gets or sets fqdn or ip address of the target.
    /// </summary>
    /// <example>Some example of the expected value.</example>
    [DisplayFormat(DataFormatString = "Text")]
    [DefaultValue("localhost")]
    public string Content { get; set; }
}