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

    public readonly struct Vec256Kind : IVectorTypeKind<W256>
    {
        public VectorWidth Width => VectorWidth.W256;          

        [MethodImpl(Inline)]
        public static implicit operator VectorTypeKind(Vec256Kind src)
            => src.Width;

        [MethodImpl(Inline)]
        public static implicit operator Vec256Kind(W256 src)
            => default;                                 
    }        

    public readonly struct Vec256Kind<T> : IVectorTypeKind<Vec256Kind<T>,W256,T>, IVectorTypeKind
        where T : unmanaged
    {   
        public VectorWidth Width => VectorWidth.W256;

        [MethodImpl(Inline)]
        public static implicit operator VectorWidth(Vec256Kind<T> src)
            => src.Width;

        [MethodImpl(Inline)]
        public static implicit operator VectorTypeKind(Vec256Kind<T> src)
            => src.Width;

        [MethodImpl(Inline)]
        public static implicit operator Vec256Kind(Vec256Kind<T> src)
            => default;        
    }   
}