//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegIndex;

    partial struct AsmLang
    {

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

            [Symbol("rsi")]
            RSI = r6,

            [Symbol("rdi")]
            RDI = r7,

            [Symbol("r8")]
            R8Q = r8,

            [Symbol("r9")]
            R9Q = r9,

            [Symbol("r10")]
            R10Q = r10,

            [Symbol("r11")]
            R11Q = r11,

            [Symbol("r12")]
            R12Q = r12,

            [Symbol("r13")]
            R13Q = r13,

            [Symbol("r14")]
            R14Q = r14,

            [Symbol("r15")]
            R15Q = r15,
        }
    }
}