//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;

    partial struct z
    {
        [MethodImpl(Inline), Concat, Closures(Closure)]
        public static Vector128<T> v128<T>(Vector64<T> a, Vector64<T> b)
            where T : unmanaged
                => generic<T>(vparts(w128, @as<Vector64<ulong>, ulong>(a.AsUInt64()), @as<Vector64<ulong>, ulong>(b.AsUInt64())));

        [MethodImpl(Inline), Concat, Closures(Closure)]
        public static Vector256<T> v256<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => Vector256.WithUpper(Vector256.WithLower(default,a),b);
    }
}