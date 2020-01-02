//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    partial class OpDelegates
    {
        public readonly struct UnaryPred<T> : IUnaryPred<T>
        {
            public readonly string Name;

            readonly Func<T,bit> F;

            [MethodImpl(Inline)]
            internal UnaryPred(Func<T,bit> f, string name)            
            {
                this.F = f;
                this.Name = name;
            }
            
            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public bit Invoke(T a) => F(a);
        }
    }
}