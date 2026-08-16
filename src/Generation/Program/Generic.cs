namespace ReScore.Generation.Program;

public static class Generic
{
    public static string Generate(string entryFunction, string[] functionList, uint ramSize = 0x1000000)
    {
        return 
$@"
#include <stdint.h>
#include <stdio.h>
#include <stdlib.h>

#define NULL (void*)0

typedef uint32_t uint;
typedef uint8_t byte;

typedef struct {{
    uint r0;
    uint r1;
    uint r2;
}} State;

State ctx;

size_t memory_size = 0x{ramSize:X8};

byte* memory = NULL;

{string.Join('\n', functionList.Select(x => $"void {x}();"))}

int main()
{{
    memory = (byte*)malloc(memory_size);

    if (!memory)
    {{
        printf(""RESCORE: Memory allocation failed! `malloc` returned NULL!\n"");
        exit(-1);
    }}

    {entryFunction}();

    free(memory);

    return 0;
}}
";
    }
}