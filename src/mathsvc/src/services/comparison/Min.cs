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
        public readonly struct Min<T> : ISBinaryOpApi<T>, ISBinarySpanOpApi<T>
            where T : unmanaged        
        {
            public const string Name = "min";

            public static Min<T> Op => default;

            public OpIdentity Id => Identities.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.min(a, b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => apply(this, lhs,rhs,dst);
        }
    }
}