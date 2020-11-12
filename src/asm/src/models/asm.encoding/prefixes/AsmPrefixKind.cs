//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Pow2x8;

    /// <summary>
    /// Defines prefix classifiers
    /// </summary>
    public enum AsmPrefixKind : byte
    {
        None = 0,

        Lock = P2ᐞ00,

        Rep = P2ᐞ01,

        Repne = P2ᐞ02,

        Rex = P2ᐞ03,

        Override = P2ᐞ04,

        SegOverride = P2ᐞ04,

        OperandOverride = P2ᐞ05,

        AddressOverride = P2ᐞ06
    }
}