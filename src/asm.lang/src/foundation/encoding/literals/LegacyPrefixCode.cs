//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Unifies the legacy prefix codes
    /// </summary>
    public enum LegacyPrefixCode : byte
    {
        None = 0,

        /// <summary>
        /// 26
        /// </summary>
        ES = SegOverrideCode.ES,

        /// <summary>
        /// 2E
        /// </summary>
        CS = SegOverrideCode.CS,

        /// <summary>
        /// 2E
        /// </summary>
        BT = BranchHintCode.BT,

        /// <summary>
        /// 3E
        /// </summary>
        DS = SegOverrideCode.DS,

        /// <summary>
        /// 3E
        /// </summary>
        BNT = BranchHintCode.BNT,

        /// <summary>
        /// 66
        /// </summary>
        OPSZ = SizeOverrideCode.OPSZ,

        /// <summary>
        /// 64
        /// </summary>
        FS = SegOverrideCode.FS,

        /// <summary>
        /// 65
        /// </summary>
        GS = SegOverrideCode.GS,

        /// <summary>
        /// 66
        /// </summary>
        x66 = MandatoryPrefixCode.x66,

        /// <summary>
        /// 67
        /// </summary>
        ADSZ = SizeOverrideCode.ADSZ,

        /// <summary>
        /// E6
        /// </summary>
        SS = SegOverrideCode.SS,

        /// <summary>
        /// F0
        /// </summary>
        LOCK = LockPrefixCode.LOCK,

        /// <summary>
        /// F2
        /// </summary>
        F2 = MandatoryPrefixCode.F2,

        /// <summary>
        /// F3
        /// </summary>
        F3 = MandatoryPrefixCode.F3,

        /// <summary>
        /// F2
        /// </summary>
        REPNZ = RepeatPrefixCode.REPNZ,

        /// <summary>
        /// F2
        /// </summary>
        REPNE = RepeatPrefixCode.REPNE,

        /// <summary>
        /// F3
        /// </summary>
        REPE = RepeatPrefixCode.REPE,

        /// <summary>
        /// F3
        /// </summary>
        REPZ = RepeatPrefixCode.REPZ,

        /// <summary>
        /// F3
        /// </summary>
        BND = BndPrefixCode.BND,
    }
}