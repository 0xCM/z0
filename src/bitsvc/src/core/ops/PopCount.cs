//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static SFx;

    partial class BC
    {
        [Closures(Integers)]
        public readonly struct PopCount<T> : IFunc<T,uint>
            where T : unmanaged
        {
            public static PopCount<T> Op => default;

            public const string Name = "popcount";

            public OpIdentity Id
                => SFx.identity<T>(Name);

            [MethodImpl(Inline)]
            public uint Invoke(T a)
                => gbits.pop(a);
        }
    }
}