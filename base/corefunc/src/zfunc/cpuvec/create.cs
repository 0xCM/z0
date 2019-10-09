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
    public static Vec128<uint> v128(uint x00, uint x01, uint x10, uint x11)
        => Vector128.Create(x00,x01, x10, x11);

    [MethodImpl(Inline)]
    public static Vec128<long> v128(long x00, long x01)
        => Vector128.Create(x00,x01);

    [MethodImpl(Inline)]
    public static Vec128<ulong> v128(ulong x00, ulong x01)
        => Vector128.Create(x00,x01);

    [MethodImpl(Inline)]
    public static Vec256<long> v256(long x00, long x01, long x10, long x11)
        => Vector256.Create(x00,x01,x10,x11);

    [MethodImpl(Inline)]
    public static Vec256<ulong> v256(ulong x00, ulong x01, ulong x10, ulong x11)
        => Vector256.Create(x00,x01,x10,x11);

}
