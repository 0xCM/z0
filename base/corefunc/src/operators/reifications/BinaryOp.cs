//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static zfunc;

    partial class ZOpR
    {                
        /// <summary>
        /// Captures a binary operator for which it is a surrogate 
        /// </summary>
        public readonly struct BinaryOp<F,T> : IBinaryOp<T>
            where F : IBinaryOp<T>
        {
            readonly F f;

            [MethodImpl(Inline)]
            internal BinaryOp(F f)            
                => this.f = f;
            
            public string Moniker => f.Moniker;

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) => f.Invoke(a,b);
        }

        /// <summary>
        /// Captures a binary operator for which it is a surrogate 
        /// </summary>
        public readonly struct BinaryOp<T> : IBinaryOp<T>
        {
            readonly IBinaryOp<T> f;

            [MethodImpl(Inline)]
            internal BinaryOp(IBinaryOp<T> f)            
                => this.f = f;
            
            public string Moniker => f.Moniker;

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) => f.Invoke(a,b);
        }

        public readonly struct BinaryDelegate<T> : IBinaryOp<T>
        {
            public readonly string Name;

            readonly Func<T,T,T> F;

            [MethodImpl(Inline)]
            internal BinaryDelegate(Func<T,T,T> f, string name)            
            {
                this.F = f;
                this.Name = name;
            }
            
            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) => F(a, b);
        }
    }
}