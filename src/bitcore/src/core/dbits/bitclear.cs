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
          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), BitClear]
          public static byte bitclear(byte src, byte index, byte count)
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
          public static sbyte bitclear(sbyte src, byte index, byte count)
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
          public static ushort bitclear(ushort src, byte index, byte count)
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
          public static short bitclear(short src, byte index, byte count)
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
          public static uint bitclear(uint src, byte index, byte count)
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
          public static int bitclear(int src, byte index, byte count)
               => (int)bitclear((uint)src,index,count);

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), BitClear]
          public static long bitclear(long src, byte index, byte count)
               => (long)bitclear((ulong)src, index, count);

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), BitClear]
          public static ulong bitclear(ulong src, byte index, byte count)
          {
               var mask = Max64u ^ (lo64(count - 1) << index);
               return mask & src;
          }
    }
}