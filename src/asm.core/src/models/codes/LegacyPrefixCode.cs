//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmCodes
    {
        /// <summary>
        /// Unifies the legacy prefix codes
        /// </summary>
        [SymbolSource]
        public enum LegacyPrefix : byte
        {
            None = 0,

            [Symbol("ES", "Seg override prefix, x26")]
            ES = SegOverrideCode.ES,

            [Symbol("CS", "Seg override prefix, x2E")]
            CS = SegOverrideCode.CS,

            [Symbol("BT", "Branch hint prefix, x2E")]
            BT = BranchHintCode.BT,

            [Symbol("DS", "Seg override prefix, x3E")]
            DS = SegOverrideCode.DS,

            [Symbol("BNT", "Branch hint prefix, x3E")]
            BNT = BranchHintCode.BNT,

            [Symbol("OPSZ", "Seg override prefix, x66")]
            OPSZ = SizeOverrideCode.OPSZ,

            [Symbol("FS", "Seg override prefix, x64")]
            FS = SegOverrideCode.FS,

            [Symbol("GS", "Seg override prefix, x65")]
            GS = SegOverrideCode.GS,

            [Symbol("x66", "Mandatory prefix, x66")]
            x66 = MandatoryPrefixCode.x66,

            [Symbol("ADSZ", "Address size override,  x67")]
            ADSZ = SizeOverrideCode.ADSZ,

            [Symbol("SS", "Seg override prefix, x36")]
            SS = SegOverrideCode.SS,

            [Symbol("LOCK", "Lock prefix, xF0")]
            LOCK = LockPrefixCode.LOCK,

            [Symbol("F2", "Mandatory prefix, xF2")]
            F2 = MandatoryPrefixCode.F2,

            [Symbol("F3", "Mandatory prefix, xF3")]
            F3 = MandatoryPrefixCode.F3,

            [Symbol("REPNZ", "Repeat prefix, xF2")]
            REPNZ = RepeatPrefixCode.REPNZ,

            [Symbol("REPNE", "Repeat prefix, xF2")]
            REPNE = RepeatPrefixCode.REPNE,

            [Symbol("REPE", "Repeat prefix, xF3")]
            REPE = RepeatPrefixCode.REPE,

            [Symbol("REPZ", "Repeat prefix, xF3")]
            REPZ = RepeatPrefixCode.REPZ,

            [Symbol("BND", "BND prefix, xF2")]
            BND = BndPrefixCode.BND,
        }
    }
}