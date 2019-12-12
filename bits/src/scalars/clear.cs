//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
          /// Disables a sequence of 8 source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          [MethodImpl(Inline)]
          public static ushort clearbyte(ushort src, int index)
          {
               var mask = uint.MaxValue ^ ((uint)byte.MaxValue << index);
               return (ushort)(mask & src);
          }
     
          /// <summary>
          /// Disables a sequence of 8 source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          [MethodImpl(Inline)]
          public static uint clearbyte(uint src, int index)
          {
               var mask = uint.MaxValue ^ ((uint)byte.MaxValue << index);
               return mask & src;
          }

          /// <summary>
          /// Disables a sequence of 8 source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          [MethodImpl(Inline)]
          public static ulong clearbyte(ulong src, int index)
          {
               var mask = ulong.MaxValue ^ ((ulong)byte.MaxValue << index);
               return mask & src;
          }

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline)]
          public static byte clear(byte src, int index, int count)
          {
               var mask = (uint)ushort.MaxValue ^ ((uint)BitMask.lomask64(count - 1) << index);
               return (byte)(mask & src);
          }

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline)]
          public static ushort clear(ushort src, int index, int count)
          {
               var mask = (uint)ushort.MaxValue ^ ((uint)BitMask.lomask64(count - 1) << index);
               return (ushort)(mask & src);
          }

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline)]
          public static uint clear(uint src, int index, int count)
          {
               var mask = uint.MaxValue ^ ((uint)BitMask.lomask64(count - 1) << index);
               return mask & src;
          }

          /// <summary>
          /// Disables a sequence of bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          /// <param name="count">The number of bits to clear</param>
          [MethodImpl(Inline)]
          public static ulong clear(ulong src, int index, int count)
          {
               var mask = ulong.MaxValue ^ (BitMask.lomask64(count - 1) << index);
               return mask & src;
          }
     }
}