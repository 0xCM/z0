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
        [Closures(AllNumeric)]
        public readonly struct Eq<T> : ISFuncApi<T,T,bit>, ISBinarySpanPredApi<T>
            where T : unmanaged        
        {
            public const string Name = "eq";

            public static Eq<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T x, T y) 
                => gmath.eq(x,y);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst)
                => apply(this, lhs,rhs,dst);
        }
    }
}