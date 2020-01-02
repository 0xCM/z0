//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        /// Captures a unary operator for which it is a surrogate 
        /// </summary>
        public readonly struct UnaryRep<F,T> : IUnaryOp<T>
            where F : IUnaryOp<T>
        {
            readonly F f;

            [MethodImpl(Inline)]
            internal UnaryRep(F f) => this.f = f;
            
            public string Moniker => f.Moniker;

            [MethodImpl(Inline)]
            public T Invoke(T a) => f.Invoke(a);
        }
    }
}