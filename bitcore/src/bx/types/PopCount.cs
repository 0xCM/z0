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
        public readonly struct PopCount<T> : IUnaryMeasure<T,uint>
            where T : unmanaged        
        {
            public static PopCount<T> Op => default;

            public const string Name = "popcount";

            public Moniker Moniker => identify<T>(Name);

            [MethodImpl(Inline)]
            public uint Invoke(T a) => gbits.pop(a);
        }
    }

}