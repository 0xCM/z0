//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class OpDelegates
    {                
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