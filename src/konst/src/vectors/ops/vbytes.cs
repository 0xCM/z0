//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
 

    using static Konst;

    partial struct z
    {

        [MethodImpl(Inline), Op]
        public static Vector128<byte> vbytes(W128 w, ulong lo)
            => Vector128.CreateScalarUnsafe(lo).As<ulong,byte>();

        [MethodImpl(Inline), Op]
        public static Vector128<byte> vbytes(W128 w, ulong lo, ulong hi)
            => Vector128.Create(lo,hi).As<ulong,byte>();

        [MethodImpl(Inline), Op]
        public static Vector256<byte> vbytes(W256 w, ulong x0, ulong x1, ulong x2, ulong x3)
            => Vector256.Create(x0,x1,x2,x3).As<ulong,byte>();
    }
}