//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using K = LegacyPrefixKind;

    /// <summary>
    /// Partitions legacy prefixes according to Intel V2.2-1
    /// </summary>
    [Flags]
    public enum LegacyPrefixGroup : byte
    {
        None = 0,

        Group1 = K.Lock | K.Repeat | K.Bnd,

        Group2 = K.SegOverride | K.BranchHint,

        Group3 = K.OperandSizeOverride,

        Group4 = K.AddressSizeOverride,
    }
}