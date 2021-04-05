//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegIndex;

    public enum Gp64 : byte
    {
        [Symbol("rax")]
        RAX = r0,

        [Symbol("rcx")]
        RCX = r1,

        [Symbol("rdx")]
        RDX = r2,

        [Symbol("rbx")]
        RBX = r3,

        [Symbol("rsp")]
        RSP = r4,

        [Symbol("rbp")]
        RBP = r5,

        RSI = r6,

        RDI = r7,

        R8Q = r8,

        R9Q = r9,

        R10Q = r10,

        R11Q = r11,

        R12Q = r12,

        R13Q = r13,

        R14Q = r14,

        R15Q = r15,
    }
}