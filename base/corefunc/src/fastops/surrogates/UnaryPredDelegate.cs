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
        public readonly struct UnaryPredSurrogate<T> : IUnaryPred<T>
        {
            public readonly string Name;

            readonly Func<T,bit> F;

            [MethodImpl(Inline)]
            internal UnaryPredSurrogate(Func<T,bit> f, string name)            
            {
                this.F = f;
                this.Name = name;
            }
            
            public Moniker Moniker => identify<T>(Name);

            [MethodImpl(Inline)]
            public bit Invoke(T a) => F(a);
        }
    }
}