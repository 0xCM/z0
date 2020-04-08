//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed;

    partial class BitCoreServices
    {
        public readonly struct Between<T> : ISImm8x2UnaryOpApi<T>
            where T : unmanaged        
        {
            public static Between<T> Op => default;

            public const string Name = "between";

            public OpIdentity Id => Identify.sFunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, byte k1, byte k2) => gbits.between(a,k1,k2);
        }
    }
}