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

    partial class HK
    {
        /// <summary>
        /// Reifies a non-parametric vector kind
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec vk()
            => default;

        /// <summary>
        /// Reifies a parametric vector kind
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec<T> vk<T>(T t = default)
            where T : unmanaged
                => default;

        /// <summary>
        /// Reifies a non-parametric 128-bit vector kind
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128 vk128()
            => default;

        /// <summary>
        /// Reifies a cell-parametric 128-bit vector kind
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128<T> vk128<T>(T t = default)
            where T : unmanaged
                => default;

        /// <summary>
        /// Reifies a non-parametric 256-bit vector kind
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec256 vk256()
            => default;

        /// <summary>
        /// Reifies a cell-parametric 256-bit vector kind
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec256<T> vk256<T>(T t = default)
            where T : unmanaged
                => default;

        /// <summary>
        /// Reifies a parametric vector kind that closes over width and cell parameters
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec<W,T> vk<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
                => default;


        public readonly struct Vec : IVecKind
        {
            public const TypeKind Kind = TypeKind.VectorType; 

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Vec src)
                =>  src.Classifier;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct Vec<T> : IVecKind<T> 
            where T : unmanaged
        {
            public const TypeKind Kind = TypeKind.VectorType; 

            [MethodImpl(Inline)]
            public static implicit operator Vec(Vec<T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(Vec<T> src)
                =>  new TypeKind<T>(src.Classifier);
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public Vec128<T> Promote(Vec128 hk)
                => vk128<T>();
            
            public Vec256<T> Promote(Vec256 hk)
                => vk256<T>();
        }

        public readonly struct Vec128 : IFixedVecKind<Fixed128>
        {
            public const TypeKind Kind = TypeKind.VectorType; 

            public const FixedWidth Width = FixedWidth.W128;

            public static N128 W => default;

            public const int BitCount = 128;

            [MethodImpl(Inline)]
            public static implicit operator Vec(Vec128 src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator Vec128(N128 src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Vec128 src)
                =>  src.Classifier;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
                
        }        

        public readonly struct Vec128<T> : IVecKind<Vector128<T>,T>, IFixedVecKind<Fixed128>
            where T : unmanaged
        {
            public const TypeKind Kind = TypeKind.VectorType; 

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
            public static implicit operator Vec<T>(Vec128<T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Vec128<T> src)
                =>  src.Classifier;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}

        }        

        public readonly struct Vec256 : IFixedVecKind<Fixed256>
        {
            public const TypeKind Kind = TypeKind.VectorType; 

            public const FixedWidth Width = FixedWidth.W256;

            public const int BitCount = 256;             

            public static N256 W => default;

            [MethodImpl(Inline)]
            public static implicit operator Vec(Vec256 src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator Vec256(N256 src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Vec256 src)
                =>  src.Classifier;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}

        }        

        public readonly struct Vec256<T> : IVecKind<Vector256<T>,T>, IFixedVecKind<Fixed256>
            where T : unmanaged
        {
            public const TypeKind Kind = TypeKind.VectorType; 

            public const FixedWidth Width = FixedWidth.W256;

            public const int BitCount = 256;

            public static N256 W => default;

            [MethodImpl(Inline)]
            public static implicit operator Vec(Vec256<T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator Vec256(Vec256<T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Vec256<T> src)
                =>  src.Classifier;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Vec<W,T> : IVecKind<T>, IFixedNatWidth<W>
            where T : unmanaged
            where W : unmanaged, ITypeNat
        {
            public const TypeKind Kind = TypeKind.VectorType;      

            public static FixedWidth Width => (FixedWidth)nateval<W>();

            public static int BitCount => (int)nateval<W>();

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Vec<W,T> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(Vec<W,T> src)
                =>  new TypeKind<T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator TypeKindN1<W,T>(Vec<W,T> src)
                =>  new TypeKindN1<W,T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator Vec(Vec<W,T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator Vec<T>(Vec<W,T> src)
                =>  default;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}

        }        

    }

}