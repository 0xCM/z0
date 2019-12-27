//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
    /// Clasifies primitive types
    /// </summary>
    [Flags]
    public enum PrimalKind : uint
    {    
        None = 0,

        U8 = 8,

        I8 = U8 << 8,

        U16 = 16,

        I16 = U16 << 8,

        U32 = 32,

        I32 = U32 << 8,

        U64 = 64,

        I64 = U64 << 8,

        F32 = U32 << 16,
        
        F64 = U64 << 16,

        UnsignedIntegral = U8 | U16 | U32 | U64,

        SignedIntegral =  I8 | I16 | I32 | I64,

        Integral = UnsignedIntegral | SignedIntegral,

        Float = F32 | F64,

        Signed = SignedIntegral | Float,

        Unsigned = UnsignedIntegral,

        All = Integral | Float
    }
}