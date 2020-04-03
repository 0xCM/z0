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

    public readonly struct Vec128Kind : IVectorType
    {     
        [MethodImpl(Inline)]
        public static implicit operator VectorTypeKind(Vec128Kind src)
            => src.Width;

        [MethodImpl(Inline)]
        public static implicit operator VectorWidth(Vec128Kind src)
            => src.Width;

        [MethodImpl(Inline)]
        public static implicit operator Vec128Kind(W128 src)
            => default;

        public VectorWidth Width => VectorWidth.W128;
    }        

    public readonly struct Vec128Kind<T> : IVectorType<Vector128<T>,T>, IVectorType
        where T : unmanaged
    {        
        [MethodImpl(Inline)]
        public static implicit operator VectorTypeKind(Vec128Kind<T> src)
            => src.Width;

        [MethodImpl(Inline)]
        public static implicit operator VectorWidth(Vec128Kind<T> src)
            => src.Width;

        [MethodImpl(Inline)]
        public static implicit operator Vec128Kind(Vec128Kind<T> src)
            => default;

        public VectorWidth Width => VectorWidth.W128;
    }        

    public readonly struct Vec256Kind : IVectorType
    {
        [MethodImpl(Inline)]
        public static implicit operator VectorTypeKind(Vec256Kind src)
            => src.Width;

        [MethodImpl(Inline)]
        public static implicit operator Vec256Kind(W256 src)
            => default;
                    
        public VectorWidth Width => VectorWidth.W256;       
    }        

    public readonly struct Vec256Kind<T> : IVectorType<Vector256<T>,T>, IVectorType
        where T : unmanaged
    {    
        [MethodImpl(Inline)]
        public static implicit operator VectorWidth(Vec256Kind<T> src)
            => src.Width;

        [MethodImpl(Inline)]
        public static implicit operator VectorTypeKind(Vec256Kind<T> src)
            => src.Width;

        [MethodImpl(Inline)]
        public static implicit operator Vec256Kind(Vec256Kind<T> src)
            => default;                    

        public VectorWidth Width => VectorWidth.W256;       
    }   

    public static class VecKindOps     
    {
        [MethodImpl(Inline)]
        public static Vec128Kind<T> VectorKind<T>(this W128 w)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Vec256Kind<T> VectorKind<T>(this W256 w)
            where T : unmanaged
                => default;
    }
}