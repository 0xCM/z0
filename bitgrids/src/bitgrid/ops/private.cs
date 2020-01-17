//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitGrid
    {
        [MethodImpl(Inline)]
        static Vector128<T> gcell<T>(in Vector128<T> g, int index, T data)
            where T : unmanaged
                => g.WithElement(index, data);

        [MethodImpl(Inline)]
        static Vector256<T> gcell<T>(in Vector256<T> g, int index, T data)
            where T : unmanaged
                => g.WithElement(index, data);
    }

}