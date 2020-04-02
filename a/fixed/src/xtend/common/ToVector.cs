//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static Vector256<T> ToVector<T>(this in Fixed256V src)
            where T : unmanaged
                => src.data.As<ulong,T>();
    }
}