//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class SurrogateTypes
    {                
        /// <summary>
        /// Captures a delegate that is exposed as a unary operator
        /// </summary>
        public readonly struct UnaryOpSurrogate<T> : IUnaryOp<T>
        {
            public readonly string Name;

            readonly Func<T,T> f;

            [MethodImpl(Inline)]
            internal UnaryOpSurrogate(Func<T,T> f, string name)            
            {
                this.f = f;
                this.Name = name;
            }
            
            public OpIdentity Moniker => identify<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a) => f(a);
        }

    }

}