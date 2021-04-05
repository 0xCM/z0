//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegIndex;

    [SymbolSource]
    public enum Gp32 : byte
    {
        [Symbol("eax")]
        EAX = r0,

        [Symbol("ecx")]
        ECX = r1,

        [Symbol("edx")]
        EDX = r2,

        [Symbol("ebx")]
        EBX = r3,

        [Symbol("esp")]
        ESP = r4,

        [Symbol("ebp")]
        EBP = r5,

        [Symbol("esi")]
        ESI = r6,

        [Symbol("edi")]
        EDI = r7,

        [Symbol("r8d")]
        R8D = r8,

        [Symbol("r9d")]
        R9D = r9,

        [Symbol("r10d")]
        R10D = r10,

        [Symbol("r11d")]
        R11D = r11,

        [Symbol("r12d")]
        R12D = r12,

        [Symbol("r13d")]
        R13D = r13,

        [Symbol("r14d")]
        R14D = r14,

        [Symbol("r15d")]
        R15D = r15,
    }
}