namespace ReScore.Generation.Function;

public static class CFunction
{
    public static string Generate(uint address, string[] lines, bool isLabel = false, string? nameOverride = null)
    {
        return 
$@"
void {nameOverride ?? $"{(isLabel ? "LABEL" : "FUNC")}_{address:X8}"}()
{{
    {string.Join("\n    ", lines)}
}}
";
    }
}