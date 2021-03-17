//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Unifies the <see cref='LockPrefixCode'/>, <see cref='RepeatPrefixCode'/>, <see cref='BndPrefixCode'/>,
    /// <see cref='SegOverrideCode'/>, <see cref='BranchHintCode'/> and <see cref='SizeOverrideCode'/> types
    /// </summary>
    public enum LegacyPrefixCode : byte
    {
        None = 0,

        LOCK = LockPrefixCode.LOCK,

        REPNZ = RepeatPrefixCode.REPNZ,

        REPE = RepeatPrefixCode.REPE,

        REPNE = RepeatPrefixCode.REPNE,

        REPZ = RepeatPrefixCode.REPZ,

        BND = BndPrefixCode.BND,

        CS = SegOverrideCode.CS,

        SS = SegOverrideCode.SS,

        DS = SegOverrideCode.DS,

        ES = SegOverrideCode.ES,

        FS = SegOverrideCode.FS,

        GS = SegOverrideCode.GS,

        BT = BranchHintCode.BT,

        BNT = BranchHintCode.BNT,

        OPSZ = SizeOverrideCode.OPSZ,

        ADSZ = SizeOverrideCode.ADSZ,
    }
}