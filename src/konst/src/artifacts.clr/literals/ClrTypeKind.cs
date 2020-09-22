//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using p = Pow2x8;

    /// <summary>
    /// Defines classifiers that correspond to the basic CLR types
    /// </summary>
    [Flags]
    public enum ClrTypeKind : byte
    {
        None = 0,

        Class = p.P2ᐞ00,

        Struct = p.P2ᐞ01,

        Delegate = p.P2ᐞ02,

        Enum = p.P2ᐞ03,

        Interface = p.P2ᐞ04
    }
}
