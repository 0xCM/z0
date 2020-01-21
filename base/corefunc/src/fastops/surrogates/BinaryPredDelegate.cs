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
        public readonly struct BinaryPredSurrogate<T> : IBinaryPred<T>
        {
            public readonly string Name;

            readonly Func<T,T,bit> F;


            [MethodImpl(Inline)]
            internal BinaryPredSurrogate(Func<T,T,bit> f, string name)            
            {
                this.F = f;
                this.Name = name;
            }
            
            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public bit Invoke(T a, T b) => F(a, b);
        }
    }
}