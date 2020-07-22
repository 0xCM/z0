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
          /// Enables a contiguous sequence of source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin</param>
          /// <param name="count">The number of bits to fill</param>
          [MethodImpl(Inline), Op]
          public static byte fill(byte src, byte index, byte count)
          {
               
               var mask = (uint)Max16u ^ ((uint)lo64(count - 1) << index);
               return (byte)(~(mask | src));
          }

          /// <summary>
          /// Enables a contiguous sequence of source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin</param>
          /// <param name="count">The number of bits to fill</param>
          [MethodImpl(Inline), Op]
          public static sbyte fill(sbyte src, byte index, byte count)
          {
               var mask = (int)Max16u ^ ((int)lo64(count - 1) << index);
               return (sbyte)(~(mask | (int)src));
          }

          /// <summary>
          /// Enables a contiguous sequence of source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin</param>
          /// <param name="count">The number of bits to fill</param>
          [MethodImpl(Inline), Op]
          public static ushort fill(ushort src, byte index, byte count)
          {
               var mask = (uint)Max16u ^ ((uint)lo64(count - 1) << index);
               return (ushort)(~(mask | src));
          }

          /// <summary>
          /// Enables a contiguous sequence of source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), Op]
          public static short fill(short src, byte index, byte count)
          {
               var mask = (int)Max16u ^ ((int)lo64(count - 1) << index);
               return (short)(~(mask | (int)src));
          }

          /// <summary>
          /// Enables a contiguous sequence of source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin</param>
          /// <param name="count">The number of bits to fill</param>
          [MethodImpl(Inline), Op]
          public static uint fill(uint src, byte index, byte count)
          {
               var mask = Max32u ^ ((uint)lo64(count - 1) << index);
               return ~(mask | src);
          }

          /// <summary>
          /// Enables a contiguous sequence of source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin</param>
          /// <param name="count">The number of bits to fill</param>
          [MethodImpl(Inline), Op]
          public static int fill(int src, byte index, byte count)
               => (int)fill((uint)src,index,count);

          /// <summary>
          /// Enables a contiguous sequence of source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin</param>
          /// <param name="count">The number of bits to fill</param>
          [MethodImpl(Inline), Op]
          public static ulong fill(ulong src, byte index, byte count)
          {
               
               var mask = Max64u ^ (lo64(count - 1) << index);
               return ~(mask | src);
          }

          /// <summary>
          /// Enables a contiguous sequence of source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin</param>
          /// <param name="count">The number of bits to fill</param>
          [MethodImpl(Inline), Op]
          public static long fill(long src, byte index, byte count)
               => (long)fill((ulong)src, index, count);
     }
}