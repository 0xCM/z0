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

    public static partial class HK
    {

        [MethodImpl(Inline)]
        public static UserType upk()
            => default;

        [MethodImpl(Inline)]
        public static UserType<T> upk<T>(T t = default)
            where T : unmanaged
                => default;


        [MethodImpl(Inline)]
        public static BitMatrixType<T> bm<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BitMatrixType<W,T> bm<W,T>(W w = default, T t = default)
            where T : unmanaged
            where W : unmanaged, ITypeNat
                => default;

        public readonly struct UserType : IHKType<UserType>
        {
            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(UserType src)
                =>  src.Classifier;

            public const HKTypeKind Kind = HKTypeKind.UserType; 
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct UserType<T> : IHKType<UserType<T>,T> 
            where T : unmanaged
        {

            [MethodImpl(Inline)]
            public static implicit operator UserType(UserType<T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(UserType<T> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(UserType<T> src)
                =>  new TypeKind<T>(src.Classifier);
            
            public const HKTypeKind Kind = HKTypeKind.UserType; 
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }                

        public readonly struct BitVectorType : IHKType<BitVectorType>
        {
            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(BitVectorType src)
                =>  src.Classifier;

            public const HKTypeKind Kind = HKTypeKind.BitVectorType; 
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct BitVectorType<T> : IHKType<BitVectorType<T>,T> 
            where T : unmanaged
        {
            public static FixedWidth Width => (FixedWidth)bitsize<T>();

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(BitVectorType<T> src)
                =>  new TypeKind<T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator BitVectorType(BitVectorType<T> src)
                =>  default;

            public const HKTypeKind Kind = HKTypeKind.BitVectorType; 
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}

        }        

        public readonly struct BitMatrixType<T> : IHKType<BitMatrixType<T>,T> 
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(BitMatrixType<T> src)
                =>  new TypeKind<T>(src.Classifier);
            
            public const HKTypeKind Kind = HKTypeKind.BitMatrixType; 
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct BitMatrixType<N,T> : IHKType<BitMatrixType<N,T>,N,T> 
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(BitMatrixType<N,T> src)
                =>  new TypeKind<T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator BitMatrixType<T>(BitMatrixType<N,T> src)
                =>  default;

            public const HKTypeKind Kind = HKTypeKind.BitMatrixType; 
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct BitGridType<T> : IHKType<BitGridType<T>,T> 
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(BitGridType<T> src)
                =>  new TypeKind<T>(src.Classifier);
            public const HKTypeKind Kind = HKTypeKind.BitGridType; 
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct BitGridType<M,N,T> : IHKType<BitGridType<M,N,T>,M,N,T> 
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
        {
            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(BitGridType<M,N,T> src)
                =>  new TypeKind<T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<M,N,T>(BitGridType<M,N,T> src)
                =>  new TypeKind<M,N,T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator BitGridType<T>(BitGridType<M,N,T> src)
                =>  default;

            public const HKTypeKind Kind = HKTypeKind.BitGridType; 

            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        
    }
}