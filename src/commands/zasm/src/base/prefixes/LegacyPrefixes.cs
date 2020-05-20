//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Prefixes;

    /// <summary>
    /// Defines the legacy prefix set
    /// </summary>    
    public readonly struct LegacyPrefixes
    {    
        /// <summary>
        /// Operand size override; Changes the default operand size of a memory or register operand
        /// </summary>
        public static OzO OzO => OzO.Value;

        /// <summary>
        /// Address size override; Changes the default address size of a memory operand
        /// </summary>
        public static AzO AzO => AzO.Value;

        /// <summary>
        /// Forces use of the current CS segment for memory operands
        /// </summary>
        public static CSOV CS => CSOV.Value;

        /// <summary>
        /// Forces use of the current DS segment for memory operands
        /// </summary>
        public static DSOV DS => DSOV.Value;

        /// <summary>
        /// Forces use of the current ES segment for memory operands
        /// </summary>
        public static ESOV ES => ESOV.Value;

        /// <summary>
        /// Forces use of the current FS segment for memory operands
        /// </summary>
        public static FSOV FS => FSOV.Value;

        /// <summary>
        /// Forces use of the current GS segment for memory operands
        /// </summary>
        public static GSOV GS => GSOV.Value;

        /// <summary>
        /// Forces use of the current SS segment for memory operands
        /// </summary>
        public static SSOV SS => SSOV.Value;

        /// <summary>
        /// Causes certain kinds of memory read-modify-write instructions to occur atomically.
        /// </summary>
        public static LOCK LOCK => LOCK.Value;

        /// <summary>
        /// Repeats a compare-string or scan-string operation (CMPSx and SCASx) until the rCX register equals 0 
        /// or the zero flag (ZF) is cleared to 0.
        /// </summary>
        public static REPZ REPZ => REPZ.Value;

        /// <summary>
        /// Repeats a compare-string or scan-string operation (CMPSx and SCASx) until the rCX register equals 0 or 
        /// the zero flag (ZF) is set to 1.
        /// </summary>
        public static REPNZ REPNZ => REPNZ.Value;
    }
}