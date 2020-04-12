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

    public readonly struct Vec512Kind : IVectorKind<W512>
    {
        public VectorWidth Width => VectorWidth.W512;       

        [MethodImpl(Inline)]
        public static implicit operator VectorTypeKind(Vec512Kind src)
            => src.Width;

        [MethodImpl(Inline)]
        public static implicit operator Vec512Kind(W512 src)
            => default;                    
    }        

    public readonly struct Vec512Kind<T> : IVectorKind<Vec512Kind<T>,W512,T>, IVectorKind
        where T : unmanaged
    {    
        public VectorWidth Width => VectorWidth.W512;       

        [MethodImpl(Inline)]
        public static implicit operator VectorWidth(Vec512Kind<T> src)
            => src.Width;

        [MethodImpl(Inline)]
        public static implicit operator VectorTypeKind(Vec512Kind<T> src)
            => src.Width;

        [MethodImpl(Inline)]
        public static implicit operator Vec512Kind(Vec512Kind<T> src)
            => default;
    }   
}