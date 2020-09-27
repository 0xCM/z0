//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BC
    {
        [Closures(Integers)]
        public readonly struct Dot<T> : IFunc<T,T,Bit32>
            where T : unmanaged
        {
            public static Dot<T> Op => default;

            public const string Name = "dot";

            public OpIdentity Id => ApiIdentity.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public Bit32 Invoke(T a, T b) => gbits.dot(a,b);
        }
    }
}