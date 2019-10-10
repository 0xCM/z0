//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Runtime.Intrinsics;

using Z0;

partial class zfunc
{
    [MethodImpl(Inline)]
    public static Vec128<ushort> v128(ushort x0, ushort x1, ushort x2, ushort x3, ushort x4, ushort x5, ushort x6, ushort x7)
        => Vector128.Create(x0,x1, x2, x3, x4, x5, x6, x7);

    [MethodImpl(Inline)]
    public static Vec128<uint> v128(uint x0, uint x1, uint x2, uint x3)
        => Vector128.Create(x0,x1, x2, x3);

    [MethodImpl(Inline)]
    public static Vec128<long> v128(long x0, long x1)
        => Vector128.Create(x0,x1);

    [MethodImpl(Inline)]
    public static Vec128<ulong> v128(ulong x0, ulong x1)
        => Vector128.Create(x0,x1);

    [MethodImpl(Inline)]
    public static Vec256<long> v256(long x0, long x1, long x2, long x3)
        => Vector256.Create(x0,x1,x2,x3);

    [MethodImpl(Inline)]
    public static Vec256<ulong> v256(ulong x0, ulong x1, ulong x2, ulong x3)
        => Vector256.Create(x0,x1,x2,x3);

}
