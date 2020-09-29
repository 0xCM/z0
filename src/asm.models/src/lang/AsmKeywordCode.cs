//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AsmLang
    {
        /// <summary>
        /// Defines surrogate identifiers for (actual) asm keywords, registers, instructions and other syntax that may appear
        /// in a raw x86 assembly language statement
        /// </summary>
        public enum AsmKeywordCode : ushort
        {
            None = 0,

            nop,

            word,

            dword,

            ptr,


            rsp,

            rax,


            // ~ segment registers
            cs,

            ds,

            ss,

            es,

            fs,

            gs,


            // ~ gp8 registers
            // ~ ------------------------
            al,

            cl,

            dl,

            bl,

            spL,

            bpL,

            sil,

            dil,

            // ~ instructions
            // ~ ------------------------
            mov,

            movzx,

            shl,

            or,

            ret,
        }
    }
}