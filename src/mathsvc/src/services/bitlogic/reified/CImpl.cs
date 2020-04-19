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
        public readonly struct CImpl<T> : IBinaryBitLogicSvc<K.CImpl<T>,T>
            where T : unmanaged        
        {    
            public const string Name = "cimpl";

            public static CImpl<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.cimpl(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => gspan.cimpl(lhs,rhs,dst);
        }
    }
}