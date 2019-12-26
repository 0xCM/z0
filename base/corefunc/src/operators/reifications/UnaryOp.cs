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
        /// Captures a unary operator for which it is a surrogate 
        /// </summary>
        public readonly struct UnaryOp<F,T> : IUnaryOp<T>
            where F : IUnaryOp<T>
        {
            readonly F f;

            [MethodImpl(Inline)]
            internal UnaryOp(F f)            
                => this.f = f;
            
            public string Moniker => f.Moniker;

            [MethodImpl(Inline)]
            public T Invoke(T a) => f.Invoke(a);
        }

        /// <summary>
        /// Captures a unary operator for which it is a surrogate 
        /// </summary>
        public readonly struct UnaryOp<T> : IUnaryOp<T>
        {
            readonly IUnaryOp<T> f;

            [MethodImpl(Inline)]
            internal UnaryOp(IUnaryOp<T> f)            
                => this.f = f;
            
            public string Moniker => f.Moniker;

            [MethodImpl(Inline)]
            public T Invoke(T a) => f.Invoke(a);
        }

        /// <summary>
        /// Captures a delegate that is exposed as a unary operator
        /// </summary>
        public readonly struct UnaryDelegate<T> : IUnaryOp<T>
        {
            public readonly string Name;

            readonly Func<T,T> f;

            [MethodImpl(Inline)]
            internal UnaryDelegate(Func<T,T> f, string name)            
            {
                this.f = f;
                this.Name = name;
            }
            
            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a) => f(a);
        }
    }
}