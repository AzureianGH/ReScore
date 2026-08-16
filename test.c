
#include <stdint.h>
#include <stdio.h>
#include <stdlib.h>

#define NULL (void*)0

typedef uint32_t uint;
typedef uint8_t byte;

typedef struct {
    uint r0;
    uint r1;
    uint r2;
} State;

State ctx;

size_t memory_size = 0x01000000;

byte* memory = NULL;

void FUNC_12345678();
void custom_name();

int main()
{
    memory = (byte*)malloc(memory_size);

    if (!memory)
    {
        printf("RESCORE: Memory allocation failed! `malloc` returned NULL!\n");
        exit(-1);
    }

    FUNC_12345678();

    free(memory);

    return 0;
}

void FUNC_12345678()
{
    ctx.r0 = ctx.r1 + 1;
    ctx.r2++;
    return;
}

void custom_name()
{
    return;
}
