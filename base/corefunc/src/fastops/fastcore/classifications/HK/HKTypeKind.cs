//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    /// <summary>
    /// Clasifies types
    /// </summary>
    [Flags]
    public enum HKTypeKind : uint
    {    
        None = 0,
        
        SystemPrimitive = Pow2.T00,

        SystemSpan = Pow2.T01,
        
        Block = Pow2.T10,

        Vector = Pow2.T11,

        UserPrimitive = Pow2.T12,

        BitVector = Pow2.T15,

        BitMatrix = Pow2.T16,

        BitGrid = Pow2.T17,
    }
}