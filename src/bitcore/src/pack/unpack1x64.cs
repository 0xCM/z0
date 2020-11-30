//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class Bits
    {
        [MethodImpl(Inline), Unpack]
        public static ref ulong unpack64x1(ulong src, ref ulong dst)
        {
            unpack1x8x32((uint)src, ref dst);
            unpack1x8x32((uint)(src >> 32), ref seek8g(dst, 32));
            return ref dst;
        }
    }
}