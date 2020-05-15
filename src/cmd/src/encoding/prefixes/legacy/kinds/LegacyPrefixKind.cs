//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;

    using static HexKind;

    public enum LegacyPrefixKind : byte
    {
        None = 0,

        /// <summary>
        /// Operand size override; Changes the default operand size of a memory or register operand
        /// </summary>
        OzO = x66,

        /// <summary>
        /// Address size override; Changes the default address size of a memory operand
        /// </summary>
        AzO = x67,

        /// <summary>
        /// Causes certain kinds of memory read-modify-write instructions to occur atomically.
        /// </summary>
        LOCK = xf0,

        /// <summary>
        /// Forces use of the current CS segment for memory operands
        /// </summary>
        CS = x2e,

        /// <summary>
        /// Forces use of the current DSS segment for memory operands
        /// </summary>
        DS = x32,

        /// <summary>
        /// Forces use of the current ES segment for memory operands
        /// </summary>
        ES = x26,

        /// <summary>
        /// Forces use of the current FS segment for memory operands
        /// </summary>
        FS = x64,

        /// <summary>
        /// Forces use of the current GS segment for memory operands
        /// </summary>
        GS = x65,

        /// <summary>
        /// Forces use of the current SS segment for memory operands
        /// </summary>
        SS = x36,

        /// <summary>
        /// Repeats a string operation (INS, MOVS, OUTS, LODS,and STOS) until the rCX register equals 0.
        /// </summary>
        REP = xf3,

        /// <summary>
        /// Repeats a compare-string or scan-string operation (CMPSx and SCASx) until the rCX register equals 0 
        /// or the zero flag (ZF) is cleared to 0.
        /// </summary>
        REPE = xf3,

        /// <summary>
        /// Repeats a compare-string or scan-string operation (CMPSx and SCASx) until the rCX register equals 0 
        /// or the zero flag (ZF) is cleared to 0.
        /// </summary>
        REPZ = xf3,

        /// <summary>
        /// Repeats a compare-string or scan-string operation (CMPSx and SCASx) until the rCX register equals 0 or 
        /// the zero flag (ZF) is set to 1.
        /// </summary>
        REPNE = xf2,

        /// <summary>
        /// Repeats a compare-string or scan-string operation (CMPSx and SCASx) until the rCX register equals 0 or 
        /// the zero flag (ZF) is set to 1.
        /// </summary>
        REPNZ = xf2,
    }
}