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
        public readonly struct Abs<T>  : IUnaryArithmeticSvc<T>
            where T : unmanaged        
        {
            public const string Name = "abs";

            public static Abs<T> Op => default;

            public OpIdentity Id => Identities.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a) => gmath.abs(a);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst)
                => gspan.inc(src,dst);
        }
    }
}