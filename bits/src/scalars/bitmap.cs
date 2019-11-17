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
          /// Projects a contiguous sequence of bits from a source value to a target value
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="srcOffset">The source offset index</param>
          /// <param name="len">The number of bits in the sequence</param>
          /// <param name="dstOffset">The target offset index</param>
          /// <param name="dst">The target</param>
          [MethodImpl(Inline)]
          public static ref sbyte bitmap(sbyte src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
          {
               dst <<= (int)dstOffset;
               dst |= (sbyte)Bits.extract(src, srcOffset, len);
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
          public static ref short bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref short dst)
          {
               dst <<= (int)dstOffset;
               dst |= (short)Bits.extract(src, srcOffset, len);
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
          public static ref ushort bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
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
          public static ref int bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref int dst)
          {
               dst <<= (int)dstOffset;
               dst |= (int)Bits.extract(src, srcOffset, len);
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
          public static ref uint bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
          {
               dst <<= (int)dstOffset;
               dst |= (uint)Bits.extract(src, srcOffset, len);
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
          public static ref long bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref long dst)
          {
               dst <<= (int)dstOffset;
               dst |= (long)Bits.extract(src, srcOffset, len);
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
          public static ref sbyte bitmap(short src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
          {
               dst <<= (int)dstOffset;
               dst |= (sbyte)Bits.extract(src, srcOffset, len);
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
          public static ref byte bitmap(short src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
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
          public static ref short bitmap(short src, byte srcOffset, byte len, byte dstOffset, ref short dst)
          {
               dst <<= (int)dstOffset;
               dst |= (short)Bits.extract(src, srcOffset, len);
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
          public static ref ushort bitmap(short src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
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
          public static ref uint bitmap(ushort src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
          {
               dst <<= (int)dstOffset;
               dst |= (uint)Bits.extract(src, srcOffset, len);
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
          public static ref ulong bitmap(ushort src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
          {
               dst <<= (int)dstOffset;
               dst |= (ulong)Bits.extract(src, srcOffset, len);
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
          public static ref int bitmap(int src, byte srcOffset, byte len, byte dstOffset, ref int dst)
          {
               dst <<= (int)dstOffset;
               dst |= (int)Bits.extract(src, srcOffset, len);
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
          public static ref long bitmap(int src, byte srcOffset, byte len, byte dstOffset, ref long dst)
          {
               dst <<= (int)dstOffset;
               dst |= (long)Bits.extract(src, srcOffset, len);
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
          public static ref ulong bitmap(int src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
          {
               dst <<= (int)dstOffset;
               dst |= (uint)Bits.extract(src, srcOffset, len);
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
          /// Projects a contiguous sequence of bits from a source value to a target value
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="srcOffset">The source offset index</param>
          /// <param name="len">The number of bits in the sequence</param>
          /// <param name="dstOffset">The target offset index</param>
          /// <param name="dst">The target</param>
          [MethodImpl(Inline)]
          public static ref ulong bitmap(uint src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
          {
               dst <<= (int)dstOffset;
               dst |= (ulong)Bits.extract(src, srcOffset, len);
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
          public static ref long bitmap(long src, byte srcOffset, byte len,  byte dstOffset, ref long dst)
          {
               dst <<= (int)dstOffset;
               dst |= (long)Bits.extract(src, srcOffset, len);
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
          public static ref sbyte bitmap(ulong src, byte srcOffset, byte len,  byte dstOffset, ref sbyte dst)
          {
               dst <<= (int)dstOffset;
               dst |= (sbyte)Bits.extract(src, srcOffset, len);
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
          public static ref byte bitmap(ulong src, byte srcOffset, byte len,  byte dstOffset, ref byte dst)
          {
               dst <<= (int)dstOffset;
               dst |= (byte)Bits.extract(src, srcOffset, len);
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
          public static ref short bitmap(ulong src, byte srcOffset, byte len,  byte dstOffset, ref short dst)
          {
               dst <<= (int)dstOffset;
               dst |= (short)Bits.extract(src, srcOffset, len);
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
          public static ref ushort bitmap(ulong src, byte srcOffset, byte len,  byte dstOffset, ref ushort dst)
          {
               dst <<= (int)dstOffset;
               dst |= (ushort)Bits.extract(src, srcOffset, len);
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
          public static ref int bitmap(ulong src, byte srcOffset, byte len,  byte dstOffset, ref int dst)
          {
               dst <<= (int)dstOffset;
               dst |= (int)Bits.extract(src, srcOffset, len);
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
          public static ref uint bitmap(ulong src, byte srcOffset, byte len,  byte dstOffset, ref uint dst)
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
          public static ref long bitmap(ulong src, byte srcOffset, byte len,  byte dstOffset, ref long dst)
          {
               dst <<= (int)dstOffset;
               dst |= (long)Bits.extract(src, srcOffset, len);
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

          /// <summary>
          /// Projects a contiguous sequence of bits from a source value into a target value
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="srcOffset">The source offset index</param>
          /// <param name="len">The number of bits in the sequence</param>
          /// <param name="dstOffset">The target offset index</param>
          /// <param name="dst">The target</param>
          [MethodImpl(Inline)]
          public static ref float bitmap(float src, byte srcOffset, byte len,  byte dstOffset, ref float dst)
          {
               math.or(ref dst, extract(src.ToBits(), srcOffset, len) << dstOffset);
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
          public static ref double bitmap(double src, byte srcOffset, byte len,  byte dstOffset, ref double dst)
          {
               math.or(ref dst, extract(src.ToBits(), srcOffset, len) << dstOffset);
               return ref dst;
          }
     }
}