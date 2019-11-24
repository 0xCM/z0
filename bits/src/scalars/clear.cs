//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    
     partial class Bits
     {                
          /// <summary>
          /// Clears a contiguous range of bits from the source
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="first">The position of the first bit to clear</param>
          /// <param name="last">The position of the last bit to clear</param>
          [MethodImpl(Inline)]
          public static byte clear(byte src, int first, int last)
          {
               var before = extract(src,0,first);
               var after = extract(src, last + 1, 8 - last);
               var cleared = (byte)(((after << (last - first)) << (first + 1)) | before);
               return cleared;                      
          }

          /// <summary>
          /// Clears a contiguous range of bits from the source
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="first">The position of the first bit to clear</param>
          /// <param name="last">The position of the last bit to clear</param>
          [MethodImpl(Inline)]
          public static ushort clear(ushort src, int first, int last)
          {
               var before = extract(src,0,first);
               var after = extract(src, last + 1, 16 - last);
               var cleared = (ushort)(((after << (last - first)) << (first + 1)) | before);
               return cleared;                      
          }

          /// <summary>
          /// Clears a contiguous range of bits from the source
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="first">The position of the first bit to clear</param>
          /// <param name="last">The position of the last bit to clear</param>
          [MethodImpl(Inline)]
          public static uint clear(uint src, int first, int last)
          {
               var before = extract(src,0,first);
               var after = extract(src, last + 1, 32 - last);
               var cleared = ((after << (last - first)) << (first + 1)) | before;
               return cleared;                      
          }

          /// <summary>
          /// Clears a contiguous range of bits from the source
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="first">The position of the first bit to clear</param>
          /// <param name="last">The position of the last bit to clear</param>
          [MethodImpl(Inline)]
          public static ulong clear(ulong src, int first, int last)
          {
               var part0 = extract(src,0,first);
               var part2 = extract(src, last + 1, 64 - last);
               var cleared = ((part2 << (last - first)) << (first + 1)) | part0;
               return cleared;                      
          }

         [MethodImpl(Inline)]
         public static ulong inject(ulong src, ulong dst, byte first, byte len)
         {
            var last = first + len;
            var part0 = Bits.zerohi(dst,first);
            var part1 = src << first;
            var part2 = Bits.extract(dst, last, 64 - last) << last;
            return part0 | part1 | part2;
         }

         [MethodImpl(Inline)]
         public static uint inject(uint src, uint dst, byte first, byte len)
         {
            var last = first + len;
            var part0 = Bits.zerohi(dst,first);
            var part1 = src << first;
            var part2 = Bits.extract(dst, last, 64 - last) << last;
            return part0 | part1 | part2;
         }

     }
}