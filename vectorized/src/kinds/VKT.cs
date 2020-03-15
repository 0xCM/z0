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
    
    using static Root;

    public interface IVectorKind : ITypeKind
    {

    }

    public interface IVectorType : IVectorKind, IFixedWidth
    {

    }    

    public interface IVectorType<F> : IVectorType, IFixedKind<F>
        where F : unmanaged, IFixed
    {

    }

    public interface IVectorType<V,T> : ITypeKind<T>, IVectorType
        where V : struct
        where T : unmanaged
    {

    }
    
    public static class VKT
    {
        public readonly struct Vec : IVectorKind
        {

        }        

        public readonly struct Vec128 : IVectorType<Fixed128>
        {
            public const FixedWidth Width = FixedWidth.W128;

            public static N128 W => default;

            public const int BitCount = 128;

            [MethodImpl(Inline)]
            public static implicit operator Vec(Vec128 src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator Vec128(N128 src)
                =>  default;

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}                
        }        

        public readonly struct Vec128<T> : IVectorType<Vector128<T>,T>, IVectorType<Fixed128>
            where T : unmanaged
        {
            public const FixedWidth Width = FixedWidth.W128;

            public const int BitCount = 128;

            public static N128 W => default;

            [MethodImpl(Inline)]
            public static implicit operator Vec(Vec128<T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator Vec128(Vec128<T> src)
                =>  default;

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Vec256 : IVectorType<Fixed256>
        {
            public const FixedWidth Width = FixedWidth.W256;

            public const int BitCount = 256;             

            public static N256 W => default;

            [MethodImpl(Inline)]
            public static implicit operator Vec(Vec256 src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator Vec256(N256 src)
                =>  default;
                        
            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Vec256<T> : IVectorType<Vector256<T>,T>, IVectorType<Fixed256>
            where T : unmanaged
        {
            public const FixedWidth Width = FixedWidth.W256;

            public const int BitCount = 256;

            public static N256 W => default;

            [MethodImpl(Inline)]
            public static implicit operator Vec(Vec256<T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator Vec256(Vec256<T> src)
                =>  default;                    
            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        
    }
}