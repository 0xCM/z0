//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
 
    using static zfunc;
    
     partial class Bits
     {                
          /// <summary>
          /// Enables a contiguous sequence of source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin</param>
          /// <param name="count">The number of bits to fill</param>
          [MethodImpl(Inline), Op]
          public static byte bitfill(byte src, byte index, byte count)
          {
               var mask = (uint)ushort.MaxValue ^ ((uint)BitMask.lo64(count - 1) << index);
               return (byte)(~(mask | src));
          }

          /// <summary>
          /// Enables a contiguous sequence of source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin</param>
          /// <param name="count">The number of bits to fill</param>
          [MethodImpl(Inline), Op]
          public static sbyte bitfill(sbyte src, byte index, byte count)
          {
               var mask = (int)ushort.MaxValue ^ ((int)BitMask.lo64(count - 1) << index);
               return (sbyte)(~(mask | (int)src));
          }

          /// <summary>
          /// Enables a contiguous sequence of source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin</param>
          /// <param name="count">The number of bits to fill</param>
          [MethodImpl(Inline), Op]
          public static ushort bitfill(ushort src, byte index, byte count)
          {
               var mask = (uint)ushort.MaxValue ^ ((uint)BitMask.lo64(count - 1) << index);
               return (ushort)(~(mask | src));
          }

          /// <summary>
          /// Enables a contiguous sequence of source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), Op]
          public static short bitfill(short src, byte index, byte count)
          {
               var mask = (int)ushort.MaxValue ^ ((int)BitMask.lo64(count - 1) << index);
               return (short)(~(mask | (int)src));
          }

          /// <summary>
          /// Enables a contiguous sequence of source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin</param>
          /// <param name="count">The number of bits to fill</param>
          [MethodImpl(Inline), Op]
          public static uint bitfill(uint src, byte index, byte count)
          {
               var mask = uint.MaxValue ^ ((uint)BitMask.lo64(count - 1) << index);
               return ~(mask | src);
          }

          /// <summary>
          /// Enables a contiguous sequence of source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin</param>
          /// <param name="count">The number of bits to fill</param>
          [MethodImpl(Inline), Op]
          public static int bitfill(int src, byte index, byte count)
               => (int)bitfill((uint)src,index,count);

          /// <summary>
          /// Enables a contiguous sequence of source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin</param>
          /// <param name="count">The number of bits to fill</param>
          [MethodImpl(Inline), Op]
          public static ulong bitfill(ulong src, byte index, byte count)
          {
               var mask = ulong.MaxValue ^ (BitMask.lo64(count - 1) << index);
               return ~(mask | src);
          }

          /// <summary>
          /// Enables a contiguous sequence of source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin</param>
          /// <param name="count">The number of bits to fill</param>
          [MethodImpl(Inline), Op]
          public static long bitfill(long src, byte index, byte count)
               => (long)bitfill((ulong)src, index, count);
     }
}