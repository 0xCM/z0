//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Flags]
    public enum BinaryRenderKind : byte
    {
        None = 0,

        LowerHex = 1,

        UpperHex = 2,

        Bits = 4,

        Delimited = 8,
    }
}