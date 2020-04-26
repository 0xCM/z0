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
    /// Represents the generic type definition for a 128-bit vector
    /// </summary>
    public readonly struct Vec128Type : IVectorType<W128>
    {     
        [MethodImpl(Inline)]
        public static implicit operator VectorWidthKind(Vec128Type src)
            => src.Width;

        [MethodImpl(Inline)]
        public static implicit operator VectorWidth(Vec128Type src)
            => VectorWidth.W128;

        [MethodImpl(Inline)]
        public static implicit operator Vec128Type(W128 src)
            => default;        

        public VectorWidth Width => VectorWidth.W128;

        public Type TypeDefinition => typeof(Vector128<>).GenericDefinition2();        
    }        
}