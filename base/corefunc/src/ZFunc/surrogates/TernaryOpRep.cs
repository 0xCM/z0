//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    partial class OpSurrogates
    {
        /// <summary>
        /// Captures a binary operator for which it is a surrogate 
        /// </summary>
        public readonly struct TernaryRep<F,T> : ITernaryOp<T>
            where F : ITernaryOp<T>
        {
            readonly F f;

            [MethodImpl(Inline)]
            internal TernaryRep(F f)            
                => this.f = f;
            
            public string Moniker => f.Moniker;

            [MethodImpl(Inline)]
            public T Invoke(T a, T b, T c) => f.Invoke(a,b,c);
        }
    }
}