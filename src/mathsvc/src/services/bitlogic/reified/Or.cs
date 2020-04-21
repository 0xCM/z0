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
        public readonly struct Or<T> : IBinaryBitLogicSvc<K.Or<T>,T>
            where T : unmanaged        
        {    
            public const string Name = "or";

            public static Or<T> Op => default;

            public OpIdentity Id => Identities.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.or(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => gspan.or(l,r,dst);
        }
    }
}