//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static LimitValues;
    using static BitMasks;

    partial class Bits
    {
        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline), Disable]
        public static sbyte disable(sbyte src, int pos)
            => (sbyte)(src & (byte)~((sbyte)(1 << pos)));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline), Disable]
        public static byte disable(byte src, int pos)
            => (byte)(src & (byte)~((byte)(1 << pos)));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline), Disable]
        public static short disable(short src, int pos)
            => (short)(src & (short)~((short)(1 << pos)));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline), Disable]
        public static ushort disable(ushort src, int pos)
            => (ushort)(src & (ushort)~((ushort)(1 << pos)));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline), Disable]
        public static int disable(int src, int pos)
            => src & ~((1 << pos));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline), Disable]
        public static uint disable(uint src, int pos)
            => src & ~((1u << pos));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline), Disable]
        public static long disable(long src, int pos)
            => src & ~((1L << pos));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline), Disable]
        public static ulong disable(ulong src, int pos)
            => src & ~((1ul << pos));

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline), Disable]
        public static float disable(float src, int pos)
        {
            ref var bits = ref Unsafe.As<float,int>(ref src);
            var m = 1 << pos;
            bits &= ~m;
            return src;
        }

        /// <summary>
        /// Disables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline), Disable]
        public static double disable(double src, int pos)
        {
            ref var bits = ref Unsafe.As<double,long>(ref src);
            var m = 1L << pos;
            bits &= ~m;
            return src;
        }

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), Disable]
          public static byte disable(byte src, byte index, byte count)
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
          [MethodImpl(Inline), Disable]
          public static sbyte disable(sbyte src, byte index, byte count)
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
          [MethodImpl(Inline), Disable]
          public static ushort disable(ushort src, byte index, byte count)
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
          [MethodImpl(Inline), Disable]
          public static short disable(short src, byte index, byte count)
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
          [MethodImpl(Inline), Disable]
          public static uint disable(uint src, byte index, byte count)
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
          [MethodImpl(Inline), Disable]
          public static int disable(int src, byte index, byte count)
               => (int)disable((uint)src,index,count);

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), Disable]
          public static long disable(long src, byte index, byte count)
               => (long)disable((ulong)src, index, count);

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline), Disable]
          public static ulong disable(ulong src, byte index, byte count)
          {
               var mask = Max64u ^ (lo64(count - 1) << index);
               return mask & src;
          }
    }
}