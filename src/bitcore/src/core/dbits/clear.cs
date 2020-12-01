//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static BitMasks;

     partial class Bits
     {
          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), BitClear]
          public static byte clear(byte src, byte index, byte count)
          {
               var mask = (uint)Max16u ^ ((uint)lo64(count - 1) << index);
               return (byte)(mask & src);
          }

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), BitClear]
          public static sbyte clear(sbyte src, byte index, byte count)
          {
               var mask = (int)Max16u ^ ((int)lo64(count - 1) << index);
               return (sbyte)(mask & (int)src);
          }

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), BitClear]
          public static ushort clear(ushort src, byte index, byte count)
          {
               var mask = (uint)Max16u ^ ((uint)lo64(count - 1) << index);
               return (ushort)(mask & src);
          }

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), BitClear]
          public static short clear(short src, byte index, byte count)
          {
               var mask = (int)Max16u ^ ((int)lo64(count - 1) << index);
               return (short)(mask & src);
          }

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), BitClear]
          public static uint clear(uint src, byte index, byte count)
          {
               var mask = Max32u ^ ((uint)lo64(count - 1) << index);
               return mask & src;
          }

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), BitClear]
          public static int clear(int src, byte index, byte count)
               => (int)clear((uint)src,index,count);

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), BitClear]
          public static long clear(long src, byte index, byte count)
               => (long)clear((ulong)src, index, count);

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), BitClear]
          public static ulong clear(ulong src, byte index, byte count)
          {
               var mask = Max64u ^ (lo64(count - 1) << index);
               return mask & src;
          }
    }
}