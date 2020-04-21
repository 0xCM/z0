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
        public readonly struct Xor<T> : IBinaryBitLogicSvc<K.Xor<T>,T>
            where T : unmanaged        
        {    
            public const string Name = "xor";

            public static Xor<T> Op => default;

            public OpIdentity Id => Identities.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.xor(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => gspan.xor(l,r,dst);
        }
    }
}