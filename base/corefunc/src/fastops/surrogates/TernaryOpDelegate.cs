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
        public readonly struct TernaryOpSurrogate<T> : ITernaryOp<T>
        {
            public readonly string Name;

            readonly Func<T,T,T,T> F;

            [MethodImpl(Inline)]
            internal TernaryOpSurrogate(Func<T,T,T,T> f, string name)            
            {
                this.F = f;
                this.Name = name;
            }
            
            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b, T c) => F(a, b, c);
        }
 

    }

}