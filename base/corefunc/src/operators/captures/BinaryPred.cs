//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    
    partial class OpCaptures
    {                
        /// <summary>
        /// Captures a binary predicate
        /// </summary>
        public readonly struct BinaryPred<F,T> : IBinaryPred<T>
            where F : IBinaryPred<T>
        {
            readonly F f;

            [MethodImpl(Inline)]
            internal BinaryPred(F f) => this.f = f;
            
            public string Moniker => f.Moniker;

            [MethodImpl(Inline)]
            public bit Invoke(T a, T b) => f.Invoke(a,b);
        }

        /// <summary>
        /// Captures a binary predicate
        /// </summary>
        public readonly struct BinaryPred<F,S,T> : IBinaryPred<S,T>
            where F : IBinaryPred<S,T>
        {
            readonly F f;

            [MethodImpl(Inline)]
            internal BinaryPred(F f) => this.f = f;
            
            public string Moniker => f.Moniker;

            [MethodImpl(Inline)]
            public bit Invoke(S a, T b) => f.Invoke(a,b);
        }

    }

}