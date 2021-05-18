//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Flags]
    public enum RelationKind : uint
    {
        None,

        Unary = 1,

        Binary = 2,

        Ternary = 4,

        Directed = 8,

        Unique = 16,

        ForeignKey = 32 | Binary | Directed,

        Join = 64
    }
}