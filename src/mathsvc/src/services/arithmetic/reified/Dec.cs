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
    }
}