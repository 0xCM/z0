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
        public readonly struct Nor<T> : IBinaryBitLogicSvc<K.Nor<T>,T>
            where T : unmanaged        
        {    
            public const string Name = "not";

            public static Nor<T> Op => default;
            public OpIdentity Id => Identities.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.nor(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => gspan.nor(l,r,dst);
        }
    }
}