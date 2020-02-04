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
    /// Classifies types
    /// </summary>
    [Flags]
    public enum TypeKind : uint
    {    
        None = 0,
        
        NumericType = Pow2.T00,

        SpanType = Pow2.T01,

        NatType = Pow2.T02,
        
        FixedType = Pow2.T08,

        FixedTypeSeg = Pow2.T09,

        BlockedType = Pow2.T10,

        VectorType = Pow2.T11,

        UserType = Pow2.T12,

        BitVectorType = Pow2.T15,

        BitMatrixType = Pow2.T16,

        BitGridType = Pow2.T17,
    }
}