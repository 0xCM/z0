//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
     using System;
     using System.Runtime.CompilerServices;

     using static zfunc;

     partial class Bits
     {                
          [MethodImpl(Inline)]
          public static sbyte toggle(sbyte src, int pos)
               => src ^= (sbyte)(1 << pos);

          [MethodImpl(Inline)]
          public static byte toggle(byte src, int pos)
               => src ^= (byte)(1 << pos);

          [MethodImpl(Inline)]
          public static short toggle(short src, int pos)
               => src ^= (short)(1 << pos);

          [MethodImpl(Inline)]
          public static ushort toggle(ushort src, int pos)
               => src ^= (ushort)(1 << pos);

          [MethodImpl(Inline)]
          public static int toggle(int src, int pos)
               => src ^= (1 << pos);

          [MethodImpl(Inline)]
          public static uint toggle(uint src, int pos)
               => src ^= (1u << pos);

          [MethodImpl(Inline)]
          public static long toggle(long src, int pos)
               => src ^= (1L << pos);

          [MethodImpl(Inline)]
          public static ulong toggle(ulong src, int pos)
               => src ^= (1ul << pos);
     }
}