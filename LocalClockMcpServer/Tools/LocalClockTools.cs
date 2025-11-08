using ModelContextProtocol.Server;
using System;
using System.ComponentModel;

namespace SampleMcpServer.Tools;

public class LocalClockTools()
{
    /// <summary>
    /// Retrieves the local date and time with daytime saving.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    [McpServerTool()]
    [Description("Retrieves the local date and time with daytime saving.")]
    public string CurrentDateTime()
    {
        return $"It is {DateTime.Now:yyyy-MM-dd HH:mm:ssK}";
    }
}