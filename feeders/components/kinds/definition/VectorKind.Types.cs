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
    
    using static Components;

    public readonly struct Vec128Kind : IVectorType
    {
        public const FixedWidth Width = FixedWidth.W128;

        public static W128 W => default;

        public const int BitCount = 128;

        [MethodImpl(Inline)]
        public static implicit operator VectorTypeKind(Vec128Kind src)
            =>  default;

        [MethodImpl(Inline)]
        public static implicit operator Vec128Kind(W128 src)
            =>  default;

        public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}                
    }        

    public readonly struct Vec128Kind<T> : IVectorType<Vector128<T>,T>, IVectorType
        where T : unmanaged
    {
        public const FixedWidth Width = FixedWidth.W128;

        public const int BitCount = 128;

        public static W128 W => default;

        [MethodImpl(Inline)]
        public static implicit operator VectorTypeKind(Vec128Kind<T> src)
            =>  default;

        [MethodImpl(Inline)]
        public static implicit operator Vec128Kind(Vec128Kind<T> src)
            =>  default;

        public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
    }        

    public readonly struct Vec256Kind : IVectorType
    {
        public const FixedWidth Width = FixedWidth.W256;

        public const int BitCount = 256;             

        public static W256 W => default;

        [MethodImpl(Inline)]
        public static implicit operator VectorTypeKind(Vec256Kind src)
            =>  default;

        [MethodImpl(Inline)]
        public static implicit operator Vec256Kind(W256 src)
            =>  default;
                    
        public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
    }        

    public readonly struct Vec256Kind<T> : IVectorType<Vector256<T>,T>, IVectorType
        where T : unmanaged
    {
        public const FixedWidth Width = FixedWidth.W256;

        public const int BitCount = 256;

        public static W256 W => default;

        [MethodImpl(Inline)]
        public static implicit operator VectorTypeKind(Vec256Kind<T> src)
            =>  default;

        [MethodImpl(Inline)]
        public static implicit operator Vec256Kind(Vec256Kind<T> src)
            =>  default;                    
        public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
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