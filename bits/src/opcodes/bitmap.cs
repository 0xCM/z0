//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class bvoc
    {            
        public static ulong clear_64(ulong src, int p0, int p1)
          => Bits.clear(src,p0,p1);

        public static ulong inject_64(ulong src, ulong dst, byte index, byte length)
              => Bits.inject(src,dst,index,length);

        public static ref byte bitmap_d8u_to_8u(in byte src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
          => ref Bits.bitmap(src,srcOffset,len,dstOffset,ref dst);

        public static ref byte bitmap_g8u_to_8u(in byte src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
          => ref gbits.bitmap(src,srcOffset,len,dstOffset,ref dst);

        public static ref ushort bitmapd_16u_to_16u(in ushort src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
          => ref Bits.bitmap(src,srcOffset,len,dstOffset,ref dst);

        public static ref ushort bitmap_g16u_to_16u(in ushort src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
          => ref gbits.bitmap(src,srcOffset,len,dstOffset,ref dst);

        public static ref uint bitmap_d32u_to_32u(in uint src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
          => ref Bits.bitmap(src,srcOffset,len,dstOffset,ref dst);

        public static ref uint bitmap_g32u_to_32u(in uint src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
          => ref gbits.bitmap(src,srcOffset,len,dstOffset,ref dst);

        public static ref ulong bitmap_d64u_to_64u(in ulong src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
          => ref Bits.bitmap(src,srcOffset,len,dstOffset,ref dst);

        public static ref ulong bitmap_g64u_to_64u(in ulong src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
          => ref gbits.bitmap(src,srcOffset,len,dstOffset,ref dst);

    }
}