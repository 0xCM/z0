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
        public readonly struct Clamp<T> : IBinaryArithmeticSvc<T>
            where T : unmanaged        
        {
            public const string Name = "clamp";

            public static Clamp<T> Op => default;

            public OpIdentity Id => Identities.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.clamp(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => gspan.clamp(l,r,dst);
        }
    }
}