//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed;
    using static Structured;

    partial class MathSvcTypes
    {
        [Closures(NumericKind.All)]
        public readonly struct NegativeOp<T> : ISFunc<T,bit>, ISUnarySpanPredApi<T>
            where T : unmanaged        
        {
            public const string Name = "negative";

            public static NegativeOp<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public bit Invoke(T a) 
                => gmath.negative(a);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> src, Span<bit> dst)
                => apply(this, src, dst);
        }
    }
}