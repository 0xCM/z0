//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using System;

    [Flags]
    public enum DirectionKind : byte
    {
        None = 0,

        [Symbol("in")]
        In = 1,

        [Symbol("out")]
        Out = 2,

        [Symbol("inout")]
        Bidirectional = In | Out,
    }
}