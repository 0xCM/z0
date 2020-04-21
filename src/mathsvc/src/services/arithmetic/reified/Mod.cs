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
        [Closures(Integers)]
        public readonly struct ModOp<T> : IBinaryArithmeticSvc<K.Mod<T>,T>
            where T : unmanaged        
        {
            public const string Name = "mod";

            public static ModOp<T> Op => default;

            public OpIdentity Id => Identities.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.mod(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => gspan.mod(lhs,rhs,dst);
        }
    }
}