//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;
 
    using static zfunc;
    
     partial class Bits
     {                
          [MethodImpl(Inline)]
          public static ulong bitmap(ulong src, int srcOffset, int len, int dstOffset, ulong dst)
          {
               var target = dst << dstOffset;
               return target | BitFieldExtract(src, (byte)srcOffset, (byte)len);
          }

          [MethodImpl(Inline)]
          public static uint bitmap(uint src, int srcOffset, int len, int dstOffset, uint dst)
          {
               var target = dst << dstOffset;
               return target | BitFieldExtract(src, (byte)srcOffset, (byte)len);
          }

          /// <summary>
          /// Projects a contiguous sequence of bits from a source value to a target value
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="srcOffset">The source offset index</param>
          /// <param name="len">The number of bits in the sequence</param>
          /// <param name="dstOffset">The target offset index</param>
          /// <param name="dst">The target</param>
          [MethodImpl(Inline)]
          public static ref byte bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
          {
               dst <<= (int)dstOffset;
               dst |= (byte)Bits.extract(src, srcOffset, len);
               return ref dst;
          }

          /// <summary>
          /// Projects a contiguous sequence of bits from a source value to a target value
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="srcOffset">The source offset index</param>
          /// <param name="len">The number of bits in the sequence</param>
          /// <param name="dstOffset">The target offset index</param>
          /// <param name="dst">The target</param>
          [MethodImpl(Inline)]
          public static ref ulong bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
          {
               dst <<= (int)dstOffset;
               dst |= Bits.extract(src, srcOffset, len);
               return ref dst;
          }

          /// <summary>
          /// Projects a contiguous sequence of bits from a source value to a target value
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="srcOffset">The source offset index</param>
          /// <param name="len">The number of bits in the sequence</param>
          /// <param name="dstOffset">The target offset index</param>
          /// <param name="dst">The target</param>
          [MethodImpl(Inline)]
          public static ref ushort bitmap(ushort src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
          {
               dst <<= (int)dstOffset;
               dst |= (ushort)Bits.extract(src, srcOffset, len);
               return ref dst;
          }

          /// <summary>
          /// Projects a contiguous sequence of bits from a source value to a target value
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="srcOffset">The source offset index</param>
          /// <param name="len">The number of bits in the sequence</param>
          /// <param name="dstOffset">The target offset index</param>
          /// <param name="dst">The target</param>
          [MethodImpl(Inline)]
          public static ref uint bitmap(uint src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
          {
               dst <<= (int)dstOffset;
               dst |= (uint)Bits.extract(src, srcOffset, len);
               return ref dst;
          }

          /// <summary>
          /// Projects a contiguous sequence of bits from a source value into a target value
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="srcOffset">The source offset index</param>
          /// <param name="len">The number of bits in the sequence</param>
          /// <param name="dstOffset">The target offset index</param>
          /// <param name="dst">The target</param>
          [MethodImpl(Inline)]
          public static ref ulong bitmap(ulong src, byte srcOffset, byte len,  byte dstOffset, ref ulong dst)
          {
               dst <<= (int)dstOffset;
               dst |= (ulong)Bits.extract(src, srcOffset, len);
               return ref dst;
          }
     }
}