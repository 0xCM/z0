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
        /// Captures a binary operator for which it is a surrogate 
        /// </summary>
        public readonly struct BinaryOp<F,T> : IBinaryOp<T>
            where F : IBinaryOp<T>
        {
            readonly F f;

            [MethodImpl(Inline)]
            internal BinaryOp(F f) => this.f = f;
            
            public string Moniker => f.Moniker;

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) => f.Invoke(a,b);
        }
    }
}