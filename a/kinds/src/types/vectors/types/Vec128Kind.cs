//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public readonly struct Vec128Kind : IVectorKind<W128>
    {     
        [MethodImpl(Inline)]
        public static implicit operator VectorTypeKind(Vec128Kind src)
            => src.Width;

        [MethodImpl(Inline)]
        public static implicit operator VectorWidth(Vec128Kind src)
            => VectorWidth.W128;

        [MethodImpl(Inline)]
        public static implicit operator Vec128Kind(W128 src)
            => default;

        public VectorWidth Width => VectorWidth.W128;
    }        

    public readonly struct Vec128Kind<T> : IVectorKind<Vec128Kind<T>,W128,T>, IVectorKind
        where T : unmanaged
    {        
        [MethodImpl(Inline)]
        public static implicit operator VectorTypeKind(Vec128Kind<T> src)
            => src.Width;

        [MethodImpl(Inline)]
        public static implicit operator VectorWidth(Vec128Kind<T> src)
            => VectorWidth.W128;
            
        [MethodImpl(Inline)]
        public static implicit operator Vec128Kind(Vec128Kind<T> src)
            => default;

        public VectorWidth Width => VectorWidth.W128;
    }        
}