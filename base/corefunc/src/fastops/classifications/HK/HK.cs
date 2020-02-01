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

        /// <summary>
        /// Reifies a non-parametric span kind
        /// </summary>
        [MethodImpl(Inline)]
        public static SysSpan sk()
                => default;

        /// <summary>
        /// Reifies a primal-parametric span kind
        /// </summary>
        [MethodImpl(Inline)]
        public static SysSpan<T> psk<T>(T t = default)
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

        /// <summary>
        /// Reifies an emitter
        /// </summary>
        /// <param name="r">An emission type representative</param>
        /// <typeparam name="R">The emitted type</typeparam>
        [MethodImpl(Inline)]
        public static Func<R> fk<R>(R r = default)
            => default;

        [MethodImpl(Inline)]
        public static FuncN<N0> fk(N0 n)
            => default;

        [MethodImpl(Inline)]
        public static FuncN<N1> fk(N1 n)
            => default;

        [MethodImpl(Inline)]
        public static FuncN<N2> fk(N2 n)
            => default;

        [MethodImpl(Inline)]
        public static FuncN<N3> fk(N3 n)
            => default;

        [MethodImpl(Inline)]
        public static FuncN<N4> fk(N4 n)
            => default;

        /// <summary>
        /// Reifies a unary function
        /// </summary>
        /// <param name="t1">An operand type representativev</param>
        /// <param name="r">An result type representative</param>
        /// <typeparam name="R">The emitted type</typeparam>
        [MethodImpl(Inline)]
        public static Func<T1,R> fk<T1,R>(T1 t1 = default, R r = default)
            => default;

        /// <summary>
        /// Reifies a binary function
        /// </summary>
        /// <param name="t1">An operand type representativev</param>
        /// <param name="t2">An operand type representativev</param>
        /// <param name="r">An result type representative</param>
        /// <typeparam name="R">The emitted type</typeparam>
        [MethodImpl(Inline)]
        public static Func<T1,T2,R> fk<T1,T2,R>(T1 t1 = default, T2 t2 = default, R r = default)
            => default;

        /// <summary>
        /// Reifies a ternary function
        /// </summary>
        /// <param name="t1">An operand type representativev</param>
        /// <param name="t2">An operand type representativev</param>
        /// <param name="t3">An operand type representativev</param>
        /// <param name="r">An result type representative</param>
        /// <typeparam name="R">The emitted type</typeparam>
        [MethodImpl(Inline)]
        public static Func<T1,T2,T3,R> fk<T1,T2,T3,R>(T1 t1 = default, T2 t2 = default, T3 t3 = default, R r = default)
            => default;

        /// <summary>
        /// Refifies a unary op kind
        /// </summary>
        /// <param name="n">The arity selector</param>
        /// <param name="t">A parametric selector</param>
        /// <typeparam name="T">Any type that distinguishes the kind in a given context</typeparam>
        [MethodImpl(Inline)]
        public static Op<N1,T> opk<T>(N1 n, T t = default)
            => default;

        /// <summary>
        /// Refifies a binary op kind
        /// </summary>
        /// <param name="n">The arity selector</param>
        /// <param name="t">A parametric selector</param>
        /// <typeparam name="T">Any type that distinguishes the kind in a given context</typeparam>
        [MethodImpl(Inline)]
        public static Op<N2,T> opk<T>(N2 n,  T t = default)
            => default;

        /// <summary>
        /// Refifies a ternary op kind
        /// </summary>
        /// <param name="n">The arity selector</param>
        /// <param name="t">A parametric selector</param>
        /// <typeparam name="T">Any type that distinguishes the kind in a given context</typeparam>
        [MethodImpl(Inline)]
        public static Op<N3,T> opk<T>(N3 n, T t = default)
            => default;


        [MethodImpl(Inline)]
        public static UnaryOp opk(N1 n)
            => default;

        [MethodImpl(Inline)]
        public static BinaryOp opk(N2 n)
            => default;

        [MethodImpl(Inline)]
        public static TernaryOp opk(N3 n)
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

            public Vec128<T> Promote(Vec128 hk)
                => vk128<T>();
            
            public Vec256<T> Promote(Vec256 hk)
                => vk256<T>();

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
            public static implicit operator Vec128(N128 src)
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
            public static implicit operator Vec256(N256 src)
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

        public readonly struct Func : IHKFunc<Func>
        {
            public const HKFunctionKind Kind = HKFunctionKind.None;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(Func src)
                =>  src.Classifier;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

        }

        static HKFunctionKind OpFunctionKind<N>(N n = default)
            where N : unmanaged, ITypeNat
            => n.NatValue switch {
                1 => HKFunctionKind.UnaryOp,
                2 => HKFunctionKind.BinaryOp,
                3 => HKFunctionKind.TernaryOp,
                _ => HKFunctionKind.None
            };

        static HKFunctionKind FunctionKind<N>(N n = default)
            where N : unmanaged, ITypeNat
            => n.NatValue switch {
                0 => HKFunctionKind.Func0,
                1 => HKFunctionKind.Func1,
                2 => HKFunctionKind.Func2,
                3 => HKFunctionKind.Func3,
                4 => HKFunctionKind.Func4,
                _ => HKFunctionKind.None
            };

        public readonly struct FuncN<N> : IHKFunc<FuncN<N>,N>
            where N : unmanaged, ITypeNat
        {
            public static HKFunctionKind Kind => FunctionKind<N>();

            [MethodImpl(Inline)]
            public static implicit operator FuncN<N>(Func src)
                =>  default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }
             
        public readonly struct Func<R> : IHKFunc<Func<R>,N1>
        {
            public const HKFunctionKind Kind = HKFunctionKind.Func0;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(Func<R> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Func(Func<R> src)
                =>  default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

        }

        public readonly struct Func<T1,R> : IHKFunc<Func<T1,R>,N1>
        {
            public const HKFunctionKind Kind = HKFunctionKind.Func1;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(Func<T1,R> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Func(Func<T1,R> src)
                =>  default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

        }

        public readonly struct Func<T1,T2,R> : IHKFunc<Func<T1,T2,R>,N2>
        {
            public const HKFunctionKind Kind = HKFunctionKind.Func2;


            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(Func<T1,T2,R> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Func(Func<T1,T2,R> src)
                =>  default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

        }

        public readonly struct Func<T1,T2,T3,R> : IHKFunc<Func<T1,T2,T3,R>,N3>
        {
            public const HKFunctionKind Kind = HKFunctionKind.Func3;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(Func<T1,T2,T3,R> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Func(Func<T1,T2,T3,R> src)
                =>  default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

        }

        public readonly struct Op<N> : IHKFunc<Op<N>>
            where N : unmanaged, ITypeNat

        {
            public static HKFunctionKind Kind => OpFunctionKind<N>();

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(Op<N> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Func(Op<N> src)
                =>  default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct Op<N,T> : IHKFunc<Op<N,T>,N>
            where N : unmanaged, ITypeNat

        {
            public static HKFunctionKind Kind => OpFunctionKind<N>();

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(Op<N,T> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Func<T,T>(Op<N,T> src)
                =>  default;


            [MethodImpl(Inline)]
            public static implicit operator Func(Op<N,T> src)
                =>  default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct UnaryFunc : IHKFunc<UnaryFunc,N1>
        {
            public const HKFunctionKind Kind = HKFunctionKind.UnaryFunc;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(UnaryFunc src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Func(UnaryFunc src)
                =>  default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }


        public readonly struct UnaryOp : IHKFunc<UnaryOp,N1>
        {
            public const HKFunctionKind Kind = HKFunctionKind.UnaryOp;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(UnaryOp src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Op<N1>(UnaryOp src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator UnaryOp(Op<N1> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator Func(UnaryOp src)
                =>  default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }


        public readonly struct UnaryOp<T> : IHKFunc<UnaryOp<T>,N1>
        {
            public const HKFunctionKind Kind = HKFunctionKind.UnaryOp;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(UnaryOp<T> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Func<T,T>(UnaryOp<T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator UnaryOp(UnaryOp<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator Func(UnaryOp<T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator Op<N1>(UnaryOp<T> src)
                =>  default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct BinaryFunc : IHKFunc<BinaryFunc,N2>
        {
            public const HKFunctionKind Kind = HKFunctionKind.BinaryFunc;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(BinaryFunc src)
                =>  src.Classifier;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct BinaryOp : IHKFunc<BinaryOp,N2>
        {
            public const HKFunctionKind Kind = HKFunctionKind.BinaryOp;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(BinaryOp src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Op<N2>(BinaryOp src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator BinaryOp(Op<N2> src)
                =>  default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct BinaryOp<T> : IHKFunc<BinaryOp<T>,N2>
        {
            public const HKFunctionKind Kind = HKFunctionKind.BinaryOp;


            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(BinaryOp<T> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Func<T,T,T>(BinaryOp<T> src)
                =>  default;
            
            [MethodImpl(Inline)]
            public static implicit operator Func(BinaryOp<T> src)
                =>  default;


            [MethodImpl(Inline)]
            public static implicit operator BinaryOp(BinaryOp<T> src)
                => default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct TernaryFunc : IHKFunc<TernaryFunc>
        {
            public const HKFunctionKind Kind = HKFunctionKind.TernaryFunc;


            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(TernaryFunc src)
                =>  src.Classifier;


            [MethodImpl(Inline)]
            public static implicit operator Func(TernaryFunc src)
                =>  default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct TernaryOp : IHKFunc<TernaryOp>
        {
            public const HKFunctionKind Kind = HKFunctionKind.TernaryOp;


            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(TernaryOp src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Func(TernaryOp src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator TernaryFunc(TernaryOp src)
                =>  default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }
    }
}