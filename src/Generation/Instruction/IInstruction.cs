namespace ReScore.Generation.Instruction;

public interface IInstruction
{
    public string Translate(uint opcode);
    public uint Length { get; }
}