using System.Reflection;

namespace aisp.launch;

internal static class LaunchDefaults
{
    public static string WebsiteUrl { get; } =
        ReadMetadata("DefaultWebsiteUrl", "https://aisp.moe");

    public static string GitHubRepo { get; } =
        ReadMetadata("DefaultGitHubRepo", "aispfan/aisp-launcher-win7");

    private static string ReadMetadata(string key, string fallback) =>
        Assembly
            .GetExecutingAssembly()
            .GetCustomAttributes<AssemblyMetadataAttribute>()
            .FirstOrDefault(attribute => attribute.Key == key)
            ?.Value
        ?? fallback;
}
