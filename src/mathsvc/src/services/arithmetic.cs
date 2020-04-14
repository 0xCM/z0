//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed;

    using K = Kinds;

    partial class MathSvcTypes
    {
        [Closures(AllNumeric)]
        public readonly struct Add<T> : IBinaryArithmeticSvc<K.Add<T>,T>
            where T : unmanaged        
        {
            public const string Name = "add";

            public static Add<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.add(a, b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => gspan.add(lhs,rhs,dst);
        }

        [Closures(AllNumeric)]
        public readonly struct Sub<T> : IBinaryArithmeticSvc<K.Sub<T>,T>
            where T : unmanaged        
        {
            public const string Name = "sub";

            public static Sub<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.sub(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => gspan.sub(lhs,rhs,dst);
        }

        [Closures(AllNumeric)]
        public readonly struct Mul<T> : IBinaryArithmeticSvc<K.Mul<T>,T>
            where T : unmanaged        
        {    
            public const string Name = "mul";

            public static Mul<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);


            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.mul(a, b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => gspan.mul(lhs,rhs,dst);

        }

        [Closures(AllNumeric)]
        public readonly struct Div<T> : IBinaryArithmeticSvc<K.Div<T>,T>
            where T : unmanaged        
        {
            public const string Name = "div";

            public static Div<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.div(a, b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => gspan.div(lhs,rhs,dst);
        }

        [Closures(Integers)]
        public readonly struct ModOp<T> : IBinaryArithmeticSvc<K.Mod<T>,T>
            where T : unmanaged        
        {
            public const string Name = "mod";

            public static ModOp<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.mod(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => gspan.mod(lhs,rhs,dst);
        }

        [Closures(Integers)]
        public readonly struct ModMul<T> : ISTernaryOpApi<T>, ISTernarySpanOpApi<T>
            where T : unmanaged        
        {
            public const string Name = "modmul";

            public static ModMul<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b, T m) => gmath.modmul(a,b,m);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst)
                => gspan.modmul(a,b,c,dst);
        }

        [Closures(Integers)]
        public readonly struct Even<T> : ISFuncApi<T,bit>, ISUnarySpanPredApi<T>
            where T : unmanaged        
        {
            public const string Name = "even";

            public static Even<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T a) => Numeric.even(a);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> src, Span<bit> dst)
                => gspan.even(src,dst);
        }

        [Closures(Integers)]
        public readonly struct Odd<T> : ISFuncApi<T,bit>, ISUnarySpanPredApi<T>
            where T : unmanaged        
        {
            public const string Name = "odd";

            public static Odd<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T a) => Numeric.odd(a);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> src, Span<bit> dst)
                => gspan.odd(src,dst);
        }

        [Closures(AllNumeric)]
        public readonly struct Clamp<T> : IBinaryArithmeticSvc<T>
            where T : unmanaged        
        {
            public const string Name = "clamp";

            public static Clamp<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.clamp(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => gspan.clamp(l,r,dst);
        }

        [Closures(AllNumeric)]
        public readonly struct Square<T> : IUnaryArithmeticSvc<T>
            where T : unmanaged        
        {
            public const string Name = "square";

            public static Square<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a) => gmath.square(a);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst)
                => gspan.square(src,dst);

        }
    
        [Closures(AllNumeric)]
        public readonly struct Negate<T> : IUnaryArithmeticSvc<T>
            where T : unmanaged        
        {
            public const string Name = "negate";

            public static Negate<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a) => gmath.negate(a);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst)
                => gspan.negate(src,dst);
        }
    
        [Closures(AllNumeric)]
        public readonly struct Dec<T> : IUnaryArithmeticSvc<T>
            where T : unmanaged        
        {
            public const string Name = "dec";

            public static Dec<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a) => gmath.dec(a);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst)
                => gspan.dec(src,dst);
        }

        [Closures(AllNumeric)]
        public readonly struct Inc<T> : IUnaryArithmeticSvc<T>
            where T : unmanaged        
        {        
            public const string Name = "inc";

            public static Inc<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a) => gmath.inc(a);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst)
                => gspan.inc(src,dst);
        }

        [Closures(AllNumeric)]
        public readonly struct Abs<T>  : IUnaryArithmeticSvc<T>
            where T : unmanaged        
        {
            public const string Name = "abs";

            public static Abs<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a) => gmath.abs(a);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst)
                => gspan.inc(src,dst);
        }

        [Closures(AllNumeric)]
        public readonly struct Dist<T> : ISFuncApi<T,T,ulong>
            where T : unmanaged        
        {
            public const string Name = "dist";

            public static Dist<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly ulong Invoke(T a, T b) => gmath.dist(a,b);
        }
    }
}