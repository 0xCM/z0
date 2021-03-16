//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Pow2x8;

    /// <summary>
    /// Defines legacy prefix classifiers
    /// </summary>
    [Flags]
    public enum LegacyPrefixKind : byte
    {
        None = 0,

        Lock = P2ᐞ00,

        Repeat = P2ᐞ01,

        Bnd = P2ᐞ02,

        SegOverride = P2ᐞ03,

        BranchHint = P2ᐞ04,

        OperandSizeOverride = P2ᐞ05,

        AddressSizeOverride = P2ᐞ06
    }
}