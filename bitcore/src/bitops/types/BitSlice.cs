//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    partial class BCTypes
    {
        public readonly struct BitSlice<T> : IPrimalUnaryRange8Op<T>
            where T : unmanaged        
        {
            public static BitSlice<T> Op => default;

            public const string Name = "between";

            public string Moniker => moniker<T>(Name);

            public T Invoke(T a, byte k1, byte k2) => gbits.bitslice(a,k1,k2);
        }
    }
}