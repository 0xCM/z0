//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    partial class OpCaptures
    {
        /// <summary>
        /// Captures a binary operator for which it is a surrogate 
        /// </summary>
        public readonly struct TernaryOp<F,T> : ITernaryOp<T>
            where F : ITernaryOp<T>
        {
            readonly F f;

            [MethodImpl(Inline)]
            internal TernaryOp(F f)            
                => this.f = f;
            
            public string Moniker => f.Moniker;

            [MethodImpl(Inline)]
            public T Invoke(T a, T b, T c) => f.Invoke(a,b,c);
        }
    }
}