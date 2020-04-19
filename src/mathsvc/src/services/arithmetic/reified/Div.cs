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
    }
}