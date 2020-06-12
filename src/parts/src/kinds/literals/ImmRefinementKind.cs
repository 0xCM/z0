//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum ImmSourceKind : byte
    {
        Literal = 0,

        Refinement = 1
    }

    [Flags]
    public enum ImmRefinementKind : byte
    {
        None = 0,

        Unrefined = 1,

        Refined = 2,

        All = Unrefined | Refined
    }
}