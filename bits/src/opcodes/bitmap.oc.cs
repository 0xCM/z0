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
          public static int popbs(ulong src)
            => Bits.popbs(src);
            
          public static ref sbyte bitmap_d8i_to_8i(in sbyte src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
            => ref Bits.bitmap(src,srcOffset,len,dstOffset,ref dst);

          public static ref sbyte bitmap_g8i_to_8i(in sbyte src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
            => ref gbits.bitmap(src,srcOffset,len,dstOffset,ref dst);

          public static ref byte bitmap_d8u_to_8u(in byte src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
            => ref Bits.bitmap(src,srcOffset,len,dstOffset,ref dst);

          public static ref byte bitmap_g8u_to_8u(in byte src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
            => ref gbits.bitmap(src,srcOffset,len,dstOffset,ref dst);

          public static ref short bitmap_d16i_to_16i(in short src, byte srcOffset, byte len, byte dstOffset, ref short dst)
            => ref Bits.bitmap(src,srcOffset,len,dstOffset,ref dst);

          public static ref short bitmap_g16i_to_16i(in short src, byte srcOffset, byte len, byte dstOffset, ref short dst)
            => ref gbits.bitmap(src,srcOffset,len,dstOffset,ref dst);

          public static ref ushort bitmapd_16u_to_16u(in ushort src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
            => ref Bits.bitmap(src,srcOffset,len,dstOffset,ref dst);

          public static ref ushort bitmap_g16u_to_16u(in ushort src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
            => ref gbits.bitmap(src,srcOffset,len,dstOffset,ref dst);

          public static ref int bitmap_d32i_to_32i(in int src, byte srcOffset, byte len, byte dstOffset, ref int dst)
            => ref Bits.bitmap(src,srcOffset,len,dstOffset,ref dst);

          public static ref int bitmap_g32i_to_32i(in int src, byte srcOffset, byte len, byte dstOffset, ref int dst)
            => ref gbits.bitmap(src,srcOffset,len,dstOffset,ref dst);

          public static ref uint bitmap_d32u_to_32u(in uint src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
            => ref Bits.bitmap(src,srcOffset,len,dstOffset,ref dst);

          public static ref uint bitmap_g32u_to_32u(in uint src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
            => ref gbits.bitmap(src,srcOffset,len,dstOffset,ref dst);

          public static ref long bitmap_d64i_to_64i(in long src, byte srcOffset, byte len, byte dstOffset, ref long dst)
            => ref Bits.bitmap(src,srcOffset,len,dstOffset,ref dst);

          public static ref long bitmap_g64i_to_64i(in long src, byte srcOffset, byte len, byte dstOffset, ref long dst)
            => ref gbits.bitmap(src,srcOffset,len,dstOffset,ref dst);

          public static ref ulong bitmap_d64u_to_64u(in ulong src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
            => ref Bits.bitmap(src,srcOffset,len,dstOffset,ref dst);

          public static ref ulong bitmap_g64u_to_64u(in ulong src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
            => ref gbits.bitmap(src,srcOffset,len,dstOffset,ref dst);

          public static ref float bitmapbit_d32f_to_32f(in float src, byte srcOffset, byte len, byte dstOffset, ref float dst)
            => ref Bits.bitmap(src,srcOffset,len,dstOffset,ref dst);

          public static ref float bitmap_g32f_to_32f(in float src, byte srcOffset, byte len, byte dstOffset, ref float dst)
            => ref gbits.bitmap(src,srcOffset,len,dstOffset,ref dst);

          public static ref double bitmapbit_d64f_to_64f(in double src, byte srcOffset, byte len, byte dstOffset, ref double dst)
            => ref Bits.bitmap(src,srcOffset,len,dstOffset,ref dst);
   
          public static ref double bitmap_g64f_to_64f(in double src, byte srcOffset, byte len, byte dstOffset, ref double dst)
            => ref gbits.bitmap(src,srcOffset,len,dstOffset,ref dst);
    }
}