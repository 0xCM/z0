//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines primal equivalence classes
    /// </summary>
    [Flags,SymSource]
    public enum PrimalClass : byte
    {
        None = 0,

        [Symbol("u")]
        Unsigned = 1,

        [Symbol("i")]
        Signed = 2,

        [Symbol("c")]
        Char = 4,

        [Symbol("f")]
        Float = 8
    }
}