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
        public readonly struct CNonImpl<T> : IBinaryBitLogicSvc<K.CNonImpl<T>,T>
            where T : unmanaged        
        {    
            public const string Name = "cnonimpl";

            public static CNonImpl<T> Op => default;
            
            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.cnonimpl(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => gspan.cnonimpl(lhs,rhs,dst);
        }
    }
}