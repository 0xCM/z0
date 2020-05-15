//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    using PK = LegacyPrefixKind;

    /// <summary>
    /// Defines the legacy prefix set
    /// </summary>    
    public readonly struct LegacyPrefixes
    {    
        /// <summary>
        /// Operand size override; Changes the default operand size of a memory or register operand
        /// </summary>
        public static OperandSizeOverride OzO => OperandSizeOverride.Define(PK.OzO);

        /// <summary>
        /// Address size override; Changes the default address size of a memory operand
        /// </summary>
        public static AddressSizeOverride AzO => AddressSizeOverride.Define(PK.AzO);

        /// <summary>
        /// Forces use of the current CS segment for memory operands
        /// </summary>
        public static SegmentOverride CS => SegmentOverride.Define(PK.CS);

        /// <summary>
        /// Forces use of the current DS segment for memory operands
        /// </summary>
        public static SegmentOverride DS => SegmentOverride.Define(PK.DS);

        /// <summary>
        /// Forces use of the current ES segment for memory operands
        /// </summary>
        public static SegmentOverride ES => SegmentOverride.Define(PK.ES);

        /// <summary>
        /// Forces use of the current FS segment for memory operands
        /// </summary>
        public static SegmentOverride FS => SegmentOverride.Define(PK.FS);

        /// <summary>
        /// Forces use of the current GS segment for memory operands
        /// </summary>
        public static SegmentOverride GS => SegmentOverride.Define(PK.GS);

        /// <summary>
        /// Forces use of the current SS segment for memory operands
        /// </summary>
        public static SegmentOverride SS => SegmentOverride.Define(PK.SS);

        /// <summary>
        /// Causes certain kinds of memory read-modify-write instructions to occur atomically.
        /// </summary>
        public static LockPrefix LOCK => LockPrefix.Define(PK.LOCK);

        /// <summary>
        /// Repeats a string operation (INS, MOVS, OUTS, LODS,and STOS) until the rCX register equals 0.
        /// </summary>
        public static RepeatPrefix REP => RepeatPrefix.Define(PK.REP);

        /// <summary>
        /// Repeats a compare-string or scan-string operation (CMPSx and SCASx) until the rCX register equals 0 
        /// or the zero flag (ZF) is cleared to 0.
        /// </summary>
        public static RepeatPrefix REPE => RepeatPrefix.Define(PK.REPE);

        /// <summary>
        /// Repeats a compare-string or scan-string operation (CMPSx and SCASx) until the rCX register equals 0 
        /// or the zero flag (ZF) is cleared to 0.
        /// </summary>
        public static RepeatPrefix REPZ => RepeatPrefix.Define(PK.REPZ);

        /// <summary>
        /// Repeats a compare-string or scan-string operation (CMPSx and SCASx) until the rCX register equals 0 or 
        /// the zero flag (ZF) is set to 1.
        /// </summary>
        public static RepeatPrefix REPNE => RepeatPrefix.Define(PK.REPNE);

        /// <summary>
        /// Repeats a compare-string or scan-string operation (CMPSx and SCASx) until the rCX register equals 0 or 
        /// the zero flag (ZF) is set to 1.
        /// </summary>
        public static RepeatPrefix REPNZ => RepeatPrefix.Define(PK.REPNZ);

        readonly HexIndex<LegacyPrefix> Index;
        
        LegacyPrefixes(int i)
        {
            Index = HexIndex.Define(x => (HexKind)x.Kind, 
                (LegacyPrefix)OzO,AzO, 
                CS, DS, ES, FS, GS, SS,
                LOCK,REPNE,REPNZ
                );
        }

    }
}