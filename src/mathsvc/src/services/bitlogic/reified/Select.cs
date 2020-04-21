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
        public readonly struct Select<T> : ITernaryBitLogicSvc<K.Select<T>,T>
            where T : unmanaged        
        {    
            public const string Name = "select";

            public static Select<T> Op => default;

            public OpIdentity Id => Identities.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b, T c) 
                => gmath.select(a, b, c);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst)
                => gspan.select(a,b,c,dst);
        }
    }
}