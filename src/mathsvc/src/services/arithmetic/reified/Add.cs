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

    partial class MSvcHosts
    {
        [Closures(AllNumeric)]
        public readonly struct Add<T> : IBinaryArithmeticSvc<K.Add<T>,T>
            where T : unmanaged        
        {
            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.add(a, b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => gspan.add(lhs,rhs,dst);
        }
    }
}