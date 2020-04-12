//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    partial class BitService
    {
        public readonly struct BitSlice<T> : ISImm8x2UnaryOpApi<T>
            where T : unmanaged        
        {
            public static BitSlice<T> Op => default;

            public const string Name = "bitslice";

            public OpIdentity Id => Identify.sFunc<T>(Name);

            public T Invoke(T a, byte k1, byte k2) => gbits.bitslice(a,k1,k2);
        }
    }
}