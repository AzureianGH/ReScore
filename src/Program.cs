using ReScore.Generation.Function;
using ReScore.Generation.Program;

namespace ReScore;

public static class Program
{
    public static void Main(string[] args)
    {
        using var fsstream = File.Open("I:\\ReScore\\test.c", FileMode.Create);
        using var file = new StreamWriter(fsstream);

        file.Write(Generic.Generate("FUNC_12345678", ["FUNC_12345678", "custom_name"]));
        file.Write(CFunction.Generate(0x12345678, ["ctx.r0 = ctx.r1 + 1;", "ctx.r2++;", "return;"]));
        file.Write(CFunction.Generate(0xABCDEF, ["return;"], nameOverride: "custom_name"));
    }
}