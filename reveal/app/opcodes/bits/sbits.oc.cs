//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class sbitsoc
    {

        public static uint pack32x1(ConstBlock256<byte> src)
            => Bits.pack8x1(src);

        public static void split_g64(ulong src, int index, out ulong x0, out ulong x1)
            => gbits.split(src, index, out x0, out x1);

        public static void split_64(ulong src, int index, out ulong x0, out ulong x1)
            => Bits.split(src, index, out x0, out x1);

        public static void split_exact(ulong src, out uint x0, out uint x1)
            => Bits.split(src, out x0, out x1);


    }

}