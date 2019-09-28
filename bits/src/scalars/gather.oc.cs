//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;
    using static AsIn;

    partial class boc
    {

        public static byte gather_d8u(byte src, byte mask)
            => Bits.gather(src,mask);

        public static byte gather_g8u(byte src, byte mask)
            => gbits.gather(in src,in mask);

        public static ushort gather_d16u(ushort src, ushort mask)
            => Bits.gather(src,mask);

        public static ushort gather_g16u(ushort src, ushort mask)
            => gbits.gather(src, mask);

        public static uint gather_d32u(uint src, uint mask)
            => Bits.gather(src,mask);

        public static uint gather_g32u(uint src, uint mask)
            => gbits.gather(in src,in mask);

        public static ulong gather_d64u(ulong src, ulong mask)
            => Bits.gather(src,mask);

        public static ulong gather_g64u(ulong src, ulong mask)
            => gbits.gather(in src,in mask);

    }

}