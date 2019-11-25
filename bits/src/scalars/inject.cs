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
          /// Overwrites a contiguous seqence of target bits [first...first+len] with bits [0...count-1] from the source
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="dst">The bit target</param>
          /// <param name="first">The index of the first bit in the target where overwriting should begin</param>
          /// <param name="count">The number bits to overwrite</param>
          [MethodImpl(Inline)]
          public static byte inject(byte src, byte dst, int first, int count)
          {
               var last = first + count;
               var part0 = Bits.zerohi(dst,first);
               var part1 = (byte)(src << first);
               var part2 = (byte)(Bits.extract(dst, last, 8 - last) << last);
               return (byte)(part0 | part1 | part2);
          }

          /// <summary>
          /// Overwrites a contiguous seqence of target bits [first...first+len] with bits [0...count-1] from the source
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="dst">The bit target</param>
          /// <param name="first">The index of the first bit in the target where overwriting should begin</param>
          /// <param name="count">The number bits to overwrite</param>
          [MethodImpl(Inline)]
          public static ushort inject(ushort src, ushort dst, int first, int count)
          {
               var last = first + count;
               var part0 = Bits.zerohi(dst,first);
               var part1 = math.sll(src,  first);
               var part2 = math.sll(Bits.extract(dst, last, 16 - last), last);
               return math.or(part0,part1,part2);
          }

          /// <summary>
          /// Overwrites a contiguous seqence of target bits [first...first+len] with bits [0...count-1] from the source
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="dst">The bit target</param>
          /// <param name="first">The index of the first bit in the target where overwriting should begin</param>
          /// <param name="count">The number bits to overwrite</param>
          [MethodImpl(Inline)]
          public static uint inject(uint src, uint dst, int first, int count)
          {
               var last = first + count;
               var part0 = Bits.zerohi(dst,first);
               var part1 = src << first;
               var part2 = Bits.extract(dst, last, 32 - last) << last;
               return part0 | part1 | part2;
          }

          /// <summary>
          /// Overwrites a contiguous seqence of target bits [first...first+len] with bits [0...count-1] from the source
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="dst">The bit target</param>
          /// <param name="first">The index of the first bit in the target where overwriting should begin</param>
          /// <param name="count">The number bits to overwrite</param>
          [MethodImpl(Inline)]
          public static ulong inject(ulong src, ulong dst, int first, int count)
          {
               var last = first + count;
               var part0 = Bits.zerohi(dst,first);
               var part1 = src << first;
               var part2 = Bits.extract(dst, last, 64 - last) << last;
               return part0 | part1 | part2;
          }

     }

}