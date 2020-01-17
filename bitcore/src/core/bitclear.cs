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
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), Op]
          public static byte bitclear(byte src, byte index, byte count)
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
          public static sbyte bitclear(sbyte src, byte index, byte count)
          {
               var mask = (int)ushort.MaxValue ^ ((int)BitMask.lo64(count - 1) << index);
               return (sbyte)(mask & src);
          }

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), Op]
          public static ushort bitclear(ushort src, byte index, byte count)
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
          public static short bitclear(short src, byte index, byte count)
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
          public static uint bitclear(uint src, byte index, byte count)
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
          public static int bitclear(int src, byte index, byte count)
               => (int)bitclear((uint)src,index,count);

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), Op]
          public static ulong bitclear(ulong src, byte index, byte count)
          {
               var mask = ulong.MaxValue ^ (BitMask.lo64(count - 1) << index);
               return mask & src;
          }

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), Op]
          public static long bitclear(long src, byte index, byte count)
               => (long)bitclear((ulong)src, index, count);

          /// <summary>
          /// Disables a sequence of 8 source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          [MethodImpl(Inline), Op]
          public static ushort clearbyte(ushort src, byte index)
          {
               var mask = uint.MaxValue ^ ((uint)byte.MaxValue << index);
               return (ushort)(mask & src);
          }
     
          /// <summary>
          /// Disables a sequence of 8 source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          [MethodImpl(Inline), Op]
          public static uint clearbyte(uint src, byte index)
          {
               var mask = uint.MaxValue ^ ((uint)byte.MaxValue << index);
               return mask & src;
          }

          /// <summary>
          /// Disables a sequence of 8 source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          [MethodImpl(Inline), Op]
          public static ulong clearbyte(ulong src, byte index)
          {
               var mask = ulong.MaxValue ^ ((ulong)byte.MaxValue << index);
               return mask & src;
          }

    }
}