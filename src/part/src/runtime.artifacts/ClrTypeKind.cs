//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Pow2x8;

    /// <summary>
    /// Defines classifiers that correspond to the basic CLR types
    /// </summary>
    [Flags]
    public enum ClrTypeKind : byte
    {
        None = 0,

        Class = P2ᐞ00,

        Struct = P2ᐞ01,

        Delegate = P2ᐞ02,

        Enum = P2ᐞ03,

        Interface = P2ᐞ04
    }
}
