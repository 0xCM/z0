//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;
    
     partial class Bits
     {                
          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), Op]
          public static byte clear(byte src, byte index, byte count)
          {
               var mask = (uint)ushort.MaxValue ^ ((uint)BitMask.lo64(count - 1) << index);
               return (byte)(mask & src);
          }

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), Op]
          public static sbyte clear(sbyte src, byte index, byte count)
          {
               var mask = (int)ushort.MaxValue ^ ((int)BitMask.lo64(count - 1) << index);
               return (sbyte)(mask & (int)src);
          }

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), Op]
          public static ushort clear(ushort src, byte index, byte count)
          {
               var mask = (uint)ushort.MaxValue ^ ((uint)BitMask.lo64(count - 1) << index);
               return (ushort)(mask & src);
          }

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), Op]
          public static short clear(short src, byte index, byte count)
          {
               var mask = (int)ushort.MaxValue ^ ((int)BitMask.lo64(count - 1) << index);
               return (short)(mask & src);
          }

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), Op]
          public static uint clear(uint src, byte index, byte count)
          {
               var mask = uint.MaxValue ^ ((uint)BitMask.lo64(count - 1) << index);
               return mask & src;
          }

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), Op]
          public static int clear(int src, byte index, byte count)
               => (int)clear((uint)src,index,count);

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), Op]
          public static long clear(long src, byte index, byte count)
               => (long)clear((ulong)src, index, count);

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), Op]
          public static ulong clear(ulong src, byte index, byte count)
          {
               var mask = ulong.MaxValue ^ (BitMask.lo64(count - 1) << index);
               return mask & src;
          }


    }
}