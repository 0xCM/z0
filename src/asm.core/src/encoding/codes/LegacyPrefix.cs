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
            ES = SegOverride.ES,

            [Symbol("CS", "Seg override prefix, x2E")]
            CS = SegOverride.CS,

            [Symbol("BT", "Branch hint prefix, x2E")]
            BT = BranchHintCode.BT,

            [Symbol("DS", "Seg override prefix, x3E")]
            DS = SegOverride.DS,

            [Symbol("BNT", "Branch hint prefix, x3E")]
            BNT = BranchHintCode.BNT,

            [Symbol("OPSZ", "Seg override prefix, x66")]
            OPSZ = SizeOverride.OPSZ,

            [Symbol("FS", "Seg override prefix, x64")]
            FS = SegOverride.FS,

            [Symbol("GS", "Seg override prefix, x65")]
            GS = SegOverride.GS,

            [Symbol("x66", "Mandatory prefix, x66")]
            x66 = MandatoryPrefixCode.x66,

            [Symbol("ADSZ", "Address size override,  x67")]
            ADSZ = SizeOverride.ADSZ,

            [Symbol("SS", "Seg override prefix, x36")]
            SS = SegOverride.SS,

            [Symbol("LOCK", "Lock prefix, xF0")]
            LOCK = LockPrefixCode.LOCK,

            [Symbol("F2", "Mandatory prefix, xF2")]
            F2 = MandatoryPrefixCode.F2,

            [Symbol("F3", "Mandatory prefix, xF3")]
            F3 = MandatoryPrefixCode.F3,

            [Symbol("REPNZ", "Repeat prefix, xF2")]
            REPNZ = RepeatPrefix.REPNZ,

            [Symbol("REPZ", "Repeat prefix, xF3")]
            REPZ = RepeatPrefix.REPZ,

            [Symbol("BND", "BND prefix, xF2")]
            BND = BndPrefixCode.BND,
        }
    }
}