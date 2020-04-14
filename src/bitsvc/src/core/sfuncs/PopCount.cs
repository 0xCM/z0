//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed;

    partial class BC
    {
        [Closures(Integers)]
        public readonly struct PopCount<T> : ISFuncApi<T,uint>
            where T : unmanaged        
        {
            public static PopCount<T> Op => default;

            public const string Name = "popcount";

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public uint Invoke(T a) => gbits.pop(a);
        }
    }
}