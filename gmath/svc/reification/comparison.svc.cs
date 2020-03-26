//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;    

    partial class MathSvcHosts
    {
        [NumericClosures(NumericKind.All)]
        public readonly struct Eq<T> : ISFuncApi<T,T,bit>, ISBinarySpanPredApi<T>
            where T : unmanaged        
        {
            public const string Name = "eq";

            public static Eq<T> Op => default;

            public OpIdentity Id => Identify.SFunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T x, T y) 
                => gmath.eq(x,y);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst)
                => SpanFunc.apply(this, lhs,rhs,dst);
        }

        [NumericClosures(NumericKind.All)]
        public readonly struct Neq<T> : ISFuncApi<T,T,bit>, ISBinarySpanPredApi<T>
            where T : unmanaged        
        {
            public const string Name = "neq";

            public static Neq<T> Op => default;
            
            public OpIdentity Id => Identify.SFunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T x, T y) => gmath.neq(x,y);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst)
                => SpanFunc.apply(this, lhs,rhs,dst);
        }

        [NumericClosures(NumericKind.All)]
        public readonly struct Lt<T> : ISFuncApi<T,T,bit>, ISBinarySpanPredApi<T>
            where T : unmanaged        
        {
            public const string Name = "lt";

            public static Lt<T> Op => default;

            public OpIdentity Id => Identify.SFunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T x, T y) 
                => gmath.lt(x,y);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst)
                => SpanFunc.apply(this, lhs,rhs,dst);
        }

        [NumericClosures(NumericKind.All)]
        public readonly struct LtEq<T> : ISFuncApi<T,T,bit>, ISBinarySpanPredApi<T>
            where T : unmanaged        
        {
            public const string Name = "lteq";

            public static LtEq<T> Op => default;

            public OpIdentity Id => Identify.SFunc<T>(Name);

            [MethodImpl(Inline)]
            public bit Invoke(T x, T y) 
                => gmath.lteq(x,y);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst)
                => SpanFunc.apply(this, lhs,rhs,dst);
        }

        [NumericClosures(NumericKind.All)]
        public readonly struct Gt<T> : ISFuncApi<T,T,bit>, ISBinarySpanPredApi<T>
            where T : unmanaged        
        {
            public const string Name = "gt";

            public static Gt<T> Op => default;

            public OpIdentity Id => Identify.SFunc<T>(Name);

            [MethodImpl(Inline)]
            public bit Invoke(T a, T b) 
                => gmath.gt(a,b);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst)
                => SpanFunc.apply(this, lhs,rhs,dst);
        }

        [NumericClosures(NumericKind.All)]
        public readonly struct GtEq<T> : ISFuncApi<T,T,bit>, ISBinarySpanPredApi<T>
            where T : unmanaged        
        {
            public const string Name = "gteq";

            public static GtEq<T> Op => default;

            public OpIdentity Id => Identify.SFunc<T>(Name);

            [MethodImpl(Inline)]
            public bit Invoke(T a, T b) 
                => gmath.gteq(a,b);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst)
                => SpanFunc.apply(this, lhs,rhs,dst);
        }

        [NumericClosures(NumericKind.All)]
        public readonly struct Between<T> : ISFuncApi<T,T,T,bit>
            where T : unmanaged        
        {
            public const string Name = "between";

            public static Between<T> Op => default;

            public OpIdentity Id => Identify.SFunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T x, T a, T b) 
                => gmath.between(x,a,b);
        }

        [NumericClosures(NumericKind.All)]
        public readonly struct Nonz<T> : ISFuncApi<T,bit>, ISUnarySpanPredApi<T>
            where T : unmanaged        
        {
            public const string Name = "nonz";

            public static Nonz<T> Op => default;

            public OpIdentity Id => Identify.SFunc<T>(Name);

            [MethodImpl(Inline)]
            public bit Invoke(T a) 
                => gmath.nonz(a);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> src, Span<bit> dst)
                => SpanFunc.apply(this, src, dst);
        }

        [NumericClosures(NumericKind.All)]
        public readonly struct NegativeOp<T> : ISFuncApi<T,bit>, ISUnarySpanPredApi<T>
            where T : unmanaged        
        {
            public const string Name = "negative";

            public static NegativeOp<T> Op => default;

            public OpIdentity Id => Identify.SFunc<T>(Name);

            [MethodImpl(Inline)]
            public bit Invoke(T a) 
                => gmath.negative(a);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> src, Span<bit> dst)
                => SpanFunc.apply(this, src, dst);
        }

        [NumericClosures(NumericKind.All)]
        public readonly struct PositiveOp<T> : ISFuncApi<T,bit>, ISUnarySpanPredApi<T>
            where T : unmanaged        
        {
            public const string Name = "positive";

            public static PositiveOp<T> Op => default;

            public OpIdentity Id => Identify.SFunc<T>(Name);

            [MethodImpl(Inline)]
            public bit Invoke(T a) 
                => gmath.positive(a);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> src, Span<bit> dst)
                => SpanFunc.apply(this, src, dst);
        }

        [NumericClosures(NumericKind.All)]
        public readonly struct Min<T> : ISBinaryOpApi<T>, ISBinarySpanOpApi<T>
            where T : unmanaged        
        {
            public const string Name = "min";

            public static Min<T> Op => default;

            public OpIdentity Id => Identify.SFunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.min(a, b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => SpanFunc.apply(this, lhs,rhs,dst);
        }

        [NumericClosures(NumericKind.All)]
        public readonly struct Max<T> : ISBinaryOpApi<T>, ISBinarySpanOpApi<T>
            where T : unmanaged        
        {
            public const string Name = "max";

            public static Max<T> Op => default;

            public OpIdentity Id => Identify.SFunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.max(a, b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => SpanFunc.apply(this, lhs,rhs,dst);
        }
    }
}