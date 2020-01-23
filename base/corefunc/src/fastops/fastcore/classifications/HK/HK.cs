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
        public static SysPrim primal()
            => default;

        [MethodImpl(Inline)]
        public static SysPrim<T> primal<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static UserPrim uprimal()
            => default;

        [MethodImpl(Inline)]
        public static UserPrim<T> uprimal<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Blocked16 bk16()
            => default;

        [MethodImpl(Inline)]
        public static Blocked32 bk32()
            => default;

        [MethodImpl(Inline)]
        public static Blocked64 bk64()
            => default;

        [MethodImpl(Inline)]
        public static Blocked128 bk128()
            => default;

        [MethodImpl(Inline)]
        public static Blocked256 bk256()
            => default;

        [MethodImpl(Inline)]
        public static Blocked512 bk512()
            => default;

        [MethodImpl(Inline)]
        public static Blocked<T> bk<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Blocked<W,T> bk<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Vec vk()
            => default;

        [MethodImpl(Inline)]
        public static Vec<T> vk<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Vec128 vk128()
            => default;

        [MethodImpl(Inline)]
        public static Vec128<T> vk128<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Vec256 vk256()
            => default;

        [MethodImpl(Inline)]
        public static Vec256<T> vk256<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Vec<W,T> vk<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static SysSpan span()
                => default;

        [MethodImpl(Inline)]
        public static SysSpan<T> span<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BMat<T> bm<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BMat<W,T> bm<W,T>(W w = default, T t = default)
            where T : unmanaged
            where W : unmanaged, ITypeNat
                => default;

        public readonly struct SysPrim : IHKType<SysPrim>
        {
            public const HKTypeKind Kind = HKTypeKind.SystemPrimitive; 

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(SysPrim src)
                =>  src.Classifier;
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct SysPrim<T> : IHKType<SysPrim<T>,T> 
            where T : unmanaged
        {
            public const HKTypeKind Kind = HKTypeKind.SystemPrimitive; 

            public static FixedWidth Width => (FixedWidth)bitsize<T>();

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(SysPrim<T> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(SysPrim<T> src)
                =>  new TypeKind<T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator SysPrim(SysPrim<T> src)
                =>  default;
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }

        public readonly struct SysSpan : IHKType<SysSpan>
        {
            public const HKTypeKind Kind = HKTypeKind.SystemSpan; 

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(SysSpan src)
                =>  src.Classifier;
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct SysSpan<T> : IHKType<SysSpan<T>,T> 
            where T : unmanaged
        {
            public const HKTypeKind Kind = HKTypeKind.SystemSpan; 

            [MethodImpl(Inline)]
            public static implicit operator SysSpan(SysSpan<T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(SysSpan<T> src)
                =>  new TypeKind<T>(src.Classifier);
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct Vec : IHKType<Vec>
        {
            public const HKTypeKind Kind = HKTypeKind.Vector; 

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(Vec src)
                =>  src.Classifier;
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct Vec<T> : IHKType<Vec<T>,T> 
            where T : unmanaged
        {
            public const HKTypeKind Kind = HKTypeKind.Vector; 

            [MethodImpl(Inline)]
            public static implicit operator Vec(Vec<T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(Vec<T> src)
                =>  new TypeKind<T>(src.Classifier);
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct Vec128 : IHKType<Vec128>, IFixedClass
        {
            public const HKTypeKind Kind = HKTypeKind.Vector; 

            public const FixedWidth Width = FixedWidth.W128;

            public static N128 W => default;

            public const int BitCount = 128;

            [MethodImpl(Inline)]
            public static implicit operator Vec(Vec128 src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(Vec128 src)
                =>  src.Classifier;
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
                
        }        

        public readonly struct Vec128<T> : IHKType<Vec128<T>>, IFixedClass
            where T : unmanaged
        {
            public const HKTypeKind Kind = HKTypeKind.Vector; 

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
            public static implicit operator HKTypeKind(Vec128<T> src)
                =>  src.Classifier;
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}

        }        

        public readonly struct Vec256 : IHKType<Vec256>, IFixedClass
        {
            public const HKTypeKind Kind = HKTypeKind.Vector; 

            public const FixedWidth Width = FixedWidth.W256;

            public const int BitCount = 256;             

            public static N256 W => default;

            [MethodImpl(Inline)]
            public static implicit operator Vec(Vec256 src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(Vec256 src)
                =>  src.Classifier;
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}

        }        

        public readonly struct Vec256<T> : IHKType<Vec256<T>>, IFixedClass
            where T : unmanaged
        {
            public const HKTypeKind Kind = HKTypeKind.Vector; 

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
            public static implicit operator HKTypeKind(Vec256<T> src)
                =>  src.Classifier;
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}

        }        

        public readonly struct Vec<W,T> : IHKType<Vec<W,T>,W,T>, IFixedClass 
            where T : unmanaged
            where W : unmanaged, ITypeNat
        {
            public const HKTypeKind Kind = HKTypeKind.Vector;      

            public static FixedWidth Width => (FixedWidth)nateval<W>();

            public static int BitCount => (int)nateval<W>();

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(Vec<W,T> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(Vec<W,T> src)
                =>  new TypeKind<T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<W,T>(Vec<W,T> src)
                =>  new TypeKind<W,T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator Vec(Vec<W,T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator Vec<T>(Vec<W,T> src)
                =>  default;
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}

        }        

        public readonly struct Blocked : IHKType<Blocked>
        {
            public const HKTypeKind Kind = HKTypeKind.Block; 

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(Blocked src)
                =>  src.Classifier;
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct Blocked16 : IHKType<Blocked16>, IFixedClass
        {
            public const HKTypeKind Kind = HKTypeKind.Block; 

            public const FixedWidth Width = FixedWidth.W16;

            public static N16 W => default;

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(Blocked16 src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked16 src)
                =>  default;
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked32 : IHKType<Blocked32>, IFixedClass
        {
            public const HKTypeKind Kind = HKTypeKind.Block; 

            public const FixedWidth Width = FixedWidth.W32;                        

            public static N32 W => default;

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(Blocked32 src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked32 src)
                =>  default;
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
            
        }        

        public readonly struct Blocked64 : IHKType<Blocked64>, IFixedClass
        {
            public const HKTypeKind Kind = HKTypeKind.Block; 

            public const FixedWidth Width = FixedWidth.W64;            

            public static N64 W => default;

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(Blocked64 src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked64 src)
                =>  default;
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked128 : IHKType<Blocked128>, IFixedClass
        {
            public const HKTypeKind Kind = HKTypeKind.Block; 

            public const FixedWidth Width = FixedWidth.W128;


            public static N128 W => default;

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(Blocked128 src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked128 src)
                =>  default;

            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked256 : IHKType<Blocked256>, IFixedClass
        {
            public const HKTypeKind Kind = HKTypeKind.Block; 

            public const FixedWidth Width = FixedWidth.W256;


            public static N256 W => default;

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(Blocked256 src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked256 src)
                =>  default;

            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked512 : IHKType<Blocked512>, IFixedClass
        {
            public const HKTypeKind Kind = HKTypeKind.Block; 

            public const FixedWidth Width = FixedWidth.W512;

            public static N512 W => default;

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(Blocked512 src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked512 src)
                =>  default;
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked<T> : IHKType<Blocked<T>,T> 
            where T : unmanaged
        {

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked<T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(Blocked<T> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(Blocked<T> src)
                =>  new TypeKind<T>(src.Classifier);
            public const HKTypeKind Kind = HKTypeKind.Block; 
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct Blocked<W,T> : IHKType<Blocked<W,T>,W,T>
            where T : unmanaged
            where W : unmanaged, ITypeNat
        {
            
            public static FixedWidth Width => (FixedWidth)nateval<W>();

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(Blocked<W,T> src)
                =>  src.Classifier;
            
            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(Blocked<W,T> src)
                =>  new TypeKind<T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<W,T>(Blocked<W,T> src)
                =>  new TypeKind<W,T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked<W,T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator Blocked<T>(Blocked<W,T> src)
                =>  default;

            public const HKTypeKind Kind = HKTypeKind.Block; 
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}            

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
       }        

        public readonly struct UserPrim : IHKType<UserPrim>
        {
            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(UserPrim src)
                =>  src.Classifier;

            public const HKTypeKind Kind = HKTypeKind.UserPrimitive; 
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct UserPrim<T> : IHKType<UserPrim<T>,T> 
            where T : unmanaged
        {

            [MethodImpl(Inline)]
            public static implicit operator UserPrim(UserPrim<T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(UserPrim<T> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(UserPrim<T> src)
                =>  new TypeKind<T>(src.Classifier);
            
            public const HKTypeKind Kind = HKTypeKind.UserPrimitive; 
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }                

        public readonly struct BVec : IHKType<BVec>
        {
            [MethodImpl(Inline)]
            public static implicit operator HKTypeKind(BVec src)
                =>  src.Classifier;

            public const HKTypeKind Kind = HKTypeKind.BitVector; 
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct BVec<T> : IHKType<BVec<T>,T> 
            where T : unmanaged
        {
            public static FixedWidth Width => (FixedWidth)bitsize<T>();

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(BVec<T> src)
                =>  new TypeKind<T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator BVec(BVec<T> src)
                =>  default;

            public const HKTypeKind Kind = HKTypeKind.BitVector; 
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}

        }        

        public readonly struct BMat<T> : IHKType<BMat<T>,T> 
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(BMat<T> src)
                =>  new TypeKind<T>(src.Classifier);
            
            public const HKTypeKind Kind = HKTypeKind.BitMatrix; 
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct BMat<N,T> : IHKType<BMat<N,T>,N,T> 
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(BMat<N,T> src)
                =>  new TypeKind<T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator BMat<T>(BMat<N,T> src)
                =>  default;

            public const HKTypeKind Kind = HKTypeKind.BitMatrix; 
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct BGrid<T> : IHKType<BGrid<T>,T> 
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(BGrid<T> src)
                =>  new TypeKind<T>(src.Classifier);
            public const HKTypeKind Kind = HKTypeKind.BitGrid; 
                    
            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct BGrid<M,N,T> : IHKType<BGrid<M,N,T>,M,N,T> 
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
        {
            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(BGrid<M,N,T> src)
                =>  new TypeKind<T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<M,N,T>(BGrid<M,N,T> src)
                =>  new TypeKind<M,N,T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator BGrid<T>(BGrid<M,N,T> src)
                =>  default;

            public const HKTypeKind Kind = HKTypeKind.BitGrid; 

            public HKTypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct UnaryFunc : IHKFunc<UnaryFunc>
        {
            public const HKFunctionKind Kind = HKFunctionKind.UnaryFunc;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(UnaryFunc src)
                =>  src.Classifier;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct UnaryOp : IHKFunc<UnaryOp>
        {
            public const HKFunctionKind Kind = HKFunctionKind.UnaryOp;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(UnaryOp src)
                =>  src.Classifier;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct BinaryFunc : IHKFunc<BinaryFunc>
        {
            public const HKFunctionKind Kind = HKFunctionKind.BinaryFunc;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(BinaryFunc src)
                =>  src.Classifier;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct BinaryOp : IHKFunc<BinaryOp>
        {
            public const HKFunctionKind Kind = HKFunctionKind.BinaryOp;


            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(BinaryOp src)
                =>  src.Classifier;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct TernaryFunc : IHKFunc<TernaryFunc>
        {
            public const HKFunctionKind Kind = HKFunctionKind.TernaryFunc;


            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(TernaryFunc src)
                =>  src.Classifier;


            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct TernaryOp : IHKFunc<TernaryOp>
        {
            public const HKFunctionKind Kind = HKFunctionKind.TernaryOp;


            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(TernaryOp src)
                =>  src.Classifier;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }
    }
}