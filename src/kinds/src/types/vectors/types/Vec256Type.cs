//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Seed;

    /// <summary>
    /// Represents the generic type definition for a 256-bit vector
    /// </summary>
    public readonly struct Vec256Type : IVectorType<W256>
    {
        [MethodImpl(Inline)]
        public static implicit operator VectorWidthKind(Vec256Type src)
            => src.Width;

        [MethodImpl(Inline)]
        public static implicit operator Vec256Type(W256 src)
            => default;                                 

        public VectorWidth Width => VectorWidth.W256;  

        public Type TypeDefinition => typeof(Vector256<>).GenericDefinition2();
    }        
}