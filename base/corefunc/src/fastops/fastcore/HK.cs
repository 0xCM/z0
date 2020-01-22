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

    public static class HK
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

        public readonly struct SysPrim : ITypeKind<SysPrim>
        {
            public const TypeKind Kind = TypeKind.SystemPrimitive; 

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(SysPrim src)
                =>  src.Classifier;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct SysPrim<T> : ITypeKind<SysPrim<T>,T> 
            where T : unmanaged
        {
            public const TypeKind Kind = TypeKind.SystemPrimitive; 

            public static FixedWidth Width => (FixedWidth)bitsize<T>();

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(SysPrim<T> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(SysPrim<T> src)
                =>  new TypeKind<T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator SysPrim(SysPrim<T> src)
                =>  default;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }

        public readonly struct SysSpan : ITypeKind<SysSpan>
        {
            public const TypeKind Kind = TypeKind.SystemSpan; 

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(SysSpan src)
                =>  src.Classifier;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct SysSpan<T> : ITypeKind<SysSpan<T>,T> 
            where T : unmanaged
        {
            public const TypeKind Kind = TypeKind.SystemSpan; 

            [MethodImpl(Inline)]
            public static implicit operator SysSpan(SysSpan<T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(SysSpan<T> src)
                =>  new TypeKind<T>(src.Classifier);
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct Vec : ITypeKind<Vec>
        {
            public const TypeKind Kind = TypeKind.Vector; 

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Vec src)
                =>  src.Classifier;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct Vec<T> : ITypeKind<Vec<T>,T> 
            where T : unmanaged
        {
            public const TypeKind Kind = TypeKind.Vector; 

            [MethodImpl(Inline)]
            public static implicit operator Vec(Vec<T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(Vec<T> src)
                =>  new TypeKind<T>(src.Classifier);
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct Vec128 : ITypeKind<Vec128>, IFixedKind
        {
            public const TypeKind Kind = TypeKind.Vector; 

            public const FixedWidth Width = FixedWidth.W128;

            public static N128 W => default;

            public const int BitCount = 128;

            [MethodImpl(Inline)]
            public static implicit operator Vec(Vec128 src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Vec128 src)
                =>  src.Classifier;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
                
        }        

        public readonly struct Vec128<T> : ITypeKind<Vec128<T>>, IFixedKind
            where T : unmanaged
        {
            public const TypeKind Kind = TypeKind.Vector; 

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

        public readonly struct Vec256 : ITypeKind<Vec256>, IFixedKind
        {
            public const TypeKind Kind = TypeKind.Vector; 

            public const FixedWidth Width = FixedWidth.W256;

            public const int BitCount = 256;             

            public static N256 W => default;

            [MethodImpl(Inline)]
            public static implicit operator Vec(Vec256 src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Vec256 src)
                =>  src.Classifier;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}

        }        

        public readonly struct Vec256<T> : ITypeKind<Vec256<T>>, IFixedKind
            where T : unmanaged
        {
            public const TypeKind Kind = TypeKind.Vector; 

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

        public readonly struct Vec<W,T> : ITypeKind<Vec<W,T>,W,T>, IFixedKind 
            where T : unmanaged
            where W : unmanaged, ITypeNat
        {
            public const TypeKind Kind = TypeKind.Vector;      

            public static FixedWidth Width => (FixedWidth)nateval<W>();

            public static int BitCount => (int)nateval<W>();

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Vec<W,T> src)
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
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}

        }        

        public readonly struct Blocked : ITypeKind<Blocked>
        {
            public const TypeKind Kind = TypeKind.Block; 

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Blocked src)
                =>  src.Classifier;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct Blocked16 : ITypeKind<Blocked16>, IFixedKind
        {
            public const TypeKind Kind = TypeKind.Block; 

            public const FixedWidth Width = FixedWidth.W16;

            public static N16 W => default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Blocked16 src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked16 src)
                =>  default;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked32 : ITypeKind<Blocked32>, IFixedKind
        {
            public const TypeKind Kind = TypeKind.Block; 

            public const FixedWidth Width = FixedWidth.W32;                        

            public static N32 W => default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Blocked32 src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked32 src)
                =>  default;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
            
        }        

        public readonly struct Blocked64 : ITypeKind<Blocked64>, IFixedKind
        {
            public const TypeKind Kind = TypeKind.Block; 

            public const FixedWidth Width = FixedWidth.W64;            

            public static N64 W => default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Blocked64 src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked64 src)
                =>  default;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked128 : ITypeKind<Blocked128>, IFixedKind
        {
            public const TypeKind Kind = TypeKind.Block; 

            public const FixedWidth Width = FixedWidth.W128;


            public static N128 W => default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Blocked128 src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked128 src)
                =>  default;

            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked256 : ITypeKind<Blocked256>, IFixedKind
        {
            public const TypeKind Kind = TypeKind.Block; 

            public const FixedWidth Width = FixedWidth.W256;


            public static N256 W => default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Blocked256 src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked256 src)
                =>  default;

            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked512 : ITypeKind<Blocked512>, IFixedKind
        {
            public const TypeKind Kind = TypeKind.Block; 

            public const FixedWidth Width = FixedWidth.W512;

            public static N512 W => default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Blocked512 src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked512 src)
                =>  default;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked<T> : ITypeKind<Blocked<T>,T> 
            where T : unmanaged
        {

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked<T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Blocked<T> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(Blocked<T> src)
                =>  new TypeKind<T>(src.Classifier);
            public const TypeKind Kind = TypeKind.Block; 
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct Blocked<W,T> : ITypeKind<Blocked<W,T>,W,T>
            where T : unmanaged
            where W : unmanaged, ITypeNat
        {
            
            public static FixedWidth Width => (FixedWidth)nateval<W>();

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Blocked<W,T> src)
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

            public const TypeKind Kind = TypeKind.Block; 
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}            

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
       }        

        public readonly struct UserPrim : ITypeKind<UserPrim>
        {
            [MethodImpl(Inline)]
            public static implicit operator TypeKind(UserPrim src)
                =>  src.Classifier;

            public const TypeKind Kind = TypeKind.UserPrimitive; 
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct UserPrim<T> : ITypeKind<UserPrim<T>,T> 
            where T : unmanaged
        {

            [MethodImpl(Inline)]
            public static implicit operator UserPrim(UserPrim<T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(UserPrim<T> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(UserPrim<T> src)
                =>  new TypeKind<T>(src.Classifier);
            
            public const TypeKind Kind = TypeKind.UserPrimitive; 
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }                

        public readonly struct BVec : ITypeKind<BVec>
        {
            [MethodImpl(Inline)]
            public static implicit operator TypeKind(BVec src)
                =>  src.Classifier;

            public const TypeKind Kind = TypeKind.BitVector; 
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct BVec<T> : ITypeKind<BVec<T>,T> 
            where T : unmanaged
        {
            public static FixedWidth Width => (FixedWidth)bitsize<T>();

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(BVec<T> src)
                =>  new TypeKind<T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator BVec(BVec<T> src)
                =>  default;

            public const TypeKind Kind = TypeKind.BitVector; 
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}

        }        

        public readonly struct BMat<T> : ITypeKind<BMat<T>,T> 
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(BMat<T> src)
                =>  new TypeKind<T>(src.Classifier);
            
            public const TypeKind Kind = TypeKind.BitMatrix; 
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct BMat<N,T> : ITypeKind<BMat<N,T>,N,T> 
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(BMat<N,T> src)
                =>  new TypeKind<T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator BMat<T>(BMat<N,T> src)
                =>  default;

            public const TypeKind Kind = TypeKind.BitMatrix; 
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct BGrid<T> : ITypeKind<BGrid<T>,T> 
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(BGrid<T> src)
                =>  new TypeKind<T>(src.Classifier);
            public const TypeKind Kind = TypeKind.BitGrid; 
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct BGrid<M,N,T> : ITypeKind<BGrid<M,N,T>,M,N,T> 
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

            public const TypeKind Kind = TypeKind.BitGrid; 

            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct UnaryFunc : IFunctionKind<UnaryFunc>
        {
            public const FunctionKind Kind = FunctionKind.UnaryFunc;

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(UnaryFunc src)
                =>  src.Classifier;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct UnaryOp : IFunctionKind<UnaryOp>
        {
            public const FunctionKind Kind = FunctionKind.UnaryOp;

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(UnaryOp src)
                =>  src.Classifier;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct BinaryFunc : IFunctionKind<BinaryFunc>
        {
            public const FunctionKind Kind = FunctionKind.BinaryFunc;

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(BinaryFunc src)
                =>  src.Classifier;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct BinaryOp : IFunctionKind<BinaryOp>
        {
            public const FunctionKind Kind = FunctionKind.BinaryOp;


            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(BinaryOp src)
                =>  src.Classifier;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct TernaryFunc : IFunctionKind<TernaryFunc>
        {
            public const FunctionKind Kind = FunctionKind.TernaryFunc;


            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(TernaryFunc src)
                =>  src.Classifier;


            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct TernaryOp : IFunctionKind<TernaryOp>
        {
            public const FunctionKind Kind = FunctionKind.TernaryOp;


            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(TernaryOp src)
                =>  src.Classifier;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }
    }
}