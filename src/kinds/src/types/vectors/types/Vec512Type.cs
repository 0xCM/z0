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
    /// Represents the generic type definition for a 512-bit vector
    /// </summary>
    public readonly struct Vec512Type : IVectorType<W512>
    {
        [MethodImpl(Inline)]
        public static implicit operator VectorWidthKind(Vec512Type src)
            => src.Width;

        [MethodImpl(Inline)]
        public static implicit operator Vec512Type(W512 src)
            => default;                    

        public VectorWidth Width => VectorWidth.W512;
        
        public Type TypeDefinition => typeof(Vector512<>).GenericDefinition2();
    }        
}