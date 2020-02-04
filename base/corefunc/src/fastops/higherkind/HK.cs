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
        public static BitMatrixType<W,T> bm<W,T>(W w = default, Numeric<T> t = default)
            where T : unmanaged
            where W : unmanaged, ITypeNat
                => default;


        public readonly struct UserType : ITypeKind
        {
            public const TypeKind TypeClass = TypeKind.UserType; 

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(UserType src)
                =>  src.Classifier;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> TypeClass;}
        }        

        public readonly struct UserType<T> : ITypeKind<T> 
            where T : unmanaged
        {

            [MethodImpl(Inline)]
            public static implicit operator UserType(UserType<T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(UserType<T> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(UserType<T> src)
                =>  new TypeKind<T>(src.Classifier);
            
            public const TypeKind Kind = TypeKind.UserType; 
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }                

        public readonly struct BitVectorType : ITypeKind
        {
            public const TypeKind TypeClass = TypeKind.BitVectorType; 

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(BitVectorType src)
                =>  src.Classifier;

                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> TypeClass;}
        }        

        public readonly struct BitVectorType<T> : ITypeKind<T> 
            where T : unmanaged
        {
            public const TypeKind TypeClass = TypeKind.BitVectorType; 

            public static FixedWidth Width => (FixedWidth)bitsize<T>();

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(BitVectorType<T> src)
                =>  new TypeKind<T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator BitVectorType(BitVectorType<T> src)
                =>  default;

                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> TypeClass;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}

        }        

        public readonly struct BitMatrixType<T> : ITypeKind<T> 
            where T : unmanaged
        {
            public const TypeKind TypeClass = TypeKind.BitMatrixType; 

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(BitMatrixType<T> src)
                =>  new TypeKind<T>(src.Classifier);
                                
            public TypeKind Classifier { [MethodImpl(Inline)] get=> TypeClass;}
        }        

        public readonly struct BitMatrixType<N,T> : ITypeKindN1<N,T> 
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            public const TypeKind TypeClass = TypeKind.BitMatrixType; 

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(BitMatrixType<N,T> src)
                =>  new TypeKind<T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator BitMatrixType<T>(BitMatrixType<N,T> src)
                =>  default;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> TypeClass;}
        }        

        public readonly struct BitGridType<T> : ITypeKind<T> 
            where T : unmanaged
        {
            public const TypeKind TypeClass = TypeKind.BitGridType; 

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(BitGridType<T> src)
                =>  new TypeKind<T>(src.Classifier);
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> TypeClass;}
        }        

        public readonly struct BitGridType<M,N,T> : ITypeKindN2<M,N,T> 
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
        {
            public const TypeKind TypeClass = TypeKind.BitGridType; 

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(BitGridType<M,N,T> src)
                =>  new TypeKind<T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator TypeKindN2<M,N,T>(BitGridType<M,N,T> src)
                =>  new TypeKindN2<M,N,T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator BitGridType<T>(BitGridType<M,N,T> src)
                =>  default;

            public TypeKind Classifier { [MethodImpl(Inline)] get=> TypeClass;}
        }        
    }
}