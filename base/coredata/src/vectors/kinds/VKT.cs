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
    
    using static zfunc;

    public static class VKT
    {
        public readonly struct Vec : IVectorType
        {

        }        

        public readonly struct Vec128 : IFixedVectorType<Fixed128>
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

        public readonly struct Vec128<T> : IVectorType<Vector128<T>,T>, IFixedVectorType<Fixed128>
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

            [MethodImpl(Inline)]
            public static implicit operator VectorType<T>(Vec128<T> src)
                =>  default;
                
            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}

        }        

        public readonly struct Vec256 : IFixedVectorType<Fixed256>
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

        public readonly struct Vec256<T> : IVectorType<Vector256<T>,T>, IFixedVectorType<Fixed256>
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

        public readonly struct VectorType<T> : IVectorType<T> 
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public static implicit operator Vec(VectorType<T> src)
                =>  default;                
        }

        public readonly struct VectorType<W,T> : IVectorType<T>, IFixedWidth<W>
            where T : unmanaged
            where W : unmanaged, ITypeNat
        {
            public static FixedWidth Width => (FixedWidth)nateval<W>();

            public static int BitCount => (int)nateval<W>();
            
            [MethodImpl(Inline)]
            public static implicit operator Vec(VectorType<W,T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator VectorType<T>(VectorType<W,T> src)
                =>  default;
                        
            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

    }
}