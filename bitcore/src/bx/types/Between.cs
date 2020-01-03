//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    partial class BCTypes
    {
        public readonly struct Between<T> : IUnaryOpImm8x2<T>
            where T : unmanaged        
        {
            public static Between<T> Op => default;

            public const string Name = "between";

            public string Moniker => moniker<T>(Name);

            public T Invoke(T a, byte k1, byte k2) => gbits.between(a,k1,k2);
        }
    }
}