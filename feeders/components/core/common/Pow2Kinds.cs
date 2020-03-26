//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
     using System;
     using System.Runtime.CompilerServices;

    using static Components;
     using static Pow2;

     public interface IP2Kind<T>
          where T : IP2Kind<T>
     {
          byte Exponent {get;}

          ulong Value {get;}
     }

     public interface IP2m1Kind<T> : IP2Kind<T>
          where T : IP2Kind<T>
     {

     }

     public static class P2K
     {
          /// <summary>
          /// 2^0 = 1
          /// </summary>
          public static P2x0 p2x0 => default;

          /// <summary>
          /// 2^1 = 2
          /// </summary>
          public static P2x1 p2x1 => default;        

          /// <summary>
          /// 2^2 = 4
          /// </summary>
          public static P2x2 p2x2 => default;

          /// <summary>
          /// 2^3 = 8
          /// </summary>
          public static P2x3 p2x3 => default;

          /// <summary>
          /// 2^4 = 16
          /// </summary>
          public static P2x4 p2x4 => default;

          /// <summary>
          /// 2^5 = 32
          /// </summary>
          public static P2x5 p2x5 => default;

          /// <summary>
          /// 2^6 = 64
          /// </summary>
          public static P2x6 p2x6 => default;

          /// <summary>
          /// 2^7 = 128
          /// </summary>
          public static P2x7 p2x7 => default;

          /// <summary>
          /// 2^8 = 256
          /// </summary>
          public static P2x8 p2x8 => default;

          /// <summary>
          /// 2^9 = 512
          /// </summary>
          public static P2x9 p2x9 => default;

          /// <summary>
          /// 2^10 = 1024
          /// </summary>
          public static P2x10 p2x10 => default;

          /// <summary>
          /// 2^11 = 2048
          /// </summary>
          public static P2x11 p2x11 => default;

          /// <summary>
          /// 2^12 = 4096
          /// </summary>
          public static P2x12 p2x12 => default;

          /// <summary>
          /// 2^13 = 8192
          /// </summary>
          public static P2x13 p2x13 => default;

          /// <summary>
          /// 2^14 = 16,384
          /// </summary>
          public static P2x14 p2x14 => default;

          /// <summary>
          /// 2^15 = 32,768
          /// </summary>
          public static P2x15 p2x15 => default;

          /// <summary>
          /// 2^16 = 65,536 = ushort.MaxValue + 1
          /// </summary>
          public static P2x16 p2x16 => default;

          /// <summary>
          /// 2^63 = 9,223,372,036,854,775,808
          /// </summary>
          public static P2x63 p2x63 => default;

          /// <summary>
          /// 2^64 - 1 = 18446744073709551615 = ulong.MaxVAlue
          /// </summary>
          public static P2x64m1 p2x64m1 => default;

          /// <summary>
          /// 2^0 = 1
          /// </summary>
          public readonly struct P2x0 : IP2Kind<P2x0> 
          {
               public byte Exponent {[MethodImpl(Inline)] get => 0;} 

               public ulong Value {[MethodImpl(Inline)] get => T00;} 
          }

          /// <summary>
          /// 2^1 = 2
          /// </summary>
          public readonly struct P2x1 : IP2Kind<P2x1> 
          {
               public byte Exponent {[MethodImpl(Inline)] get => 1;} 

               public ulong Value {[MethodImpl(Inline)] get => T01;} 
          }

          /// <summary>
          /// 2^2 = 4
          /// </summary>
          public readonly struct P2x2 : IP2Kind<P2x2>
          {
               public byte Exponent {[MethodImpl(Inline)] get => 2;} 

               public ulong Value {[MethodImpl(Inline)] get => T02;} 
          }

          /// <summary>
          /// 2^3 = 8
          /// </summary>
          public readonly struct P2x3 : IP2Kind<P2x3>
          {
               public byte Exponent {[MethodImpl(Inline)] get => 3;} 

               public ulong Value {[MethodImpl(Inline)] get => T03;} 
          }

          /// <summary>
          /// 2^4 = 16
          /// </summary>
          public readonly struct P2x4 : IP2Kind<P2x4>
          {
               public byte Exponent {[MethodImpl(Inline)] get => 4;} 

               public ulong Value {[MethodImpl(Inline)] get => T04;} 
          }

          /// <summary>
          /// 2^5 = 32
          /// </summary>
          public readonly struct P2x5 : IP2Kind<P2x5>
          {
               public byte Exponent {[MethodImpl(Inline)] get => 5;} 

               public ulong Value {[MethodImpl(Inline)] get => T05;} 
          }

          /// <summary>
          /// 2^6 = 64
          /// </summary>
          public readonly struct P2x6 : IP2Kind<P2x6>
          {
               public byte Exponent {[MethodImpl(Inline)] get => 6;} 

               public ulong Value {[MethodImpl(Inline)] get => T06;} 
          }

          /// <summary>
          /// 2^7 = 128
          /// </summary>
          public readonly struct P2x7 : IP2Kind<P2x7>
          {
               public byte Exponent {[MethodImpl(Inline)] get => 7;} 

               public ulong Value {[MethodImpl(Inline)] get => T07;} 
          }

          /// <summary>
          /// 2^8 = 256
          /// </summary>
          public readonly struct P2x8 : IP2Kind<P2x8>
          {
               public byte Exponent {[MethodImpl(Inline)] get => 8;} 

               public ulong Value {[MethodImpl(Inline)] get => T08;} 
          }

          /// <summary>
          /// 2^9 = 512
          /// </summary>
          public readonly struct P2x9 : IP2Kind<P2x9>
          {
               public byte Exponent {[MethodImpl(Inline)] get => 9;} 

               public ulong Value {[MethodImpl(Inline)] get => T09;} 
          }

          /// <summary>
          /// 2^10 = 1024
          /// </summary>
          public readonly struct P2x10 : IP2Kind<P2x10>
          {
               public byte Exponent {[MethodImpl(Inline)] get => 10;} 

               public ulong Value {[MethodImpl(Inline)] get => T10;} 
          }

          /// <summary>
          /// 2^11 = 2048
          /// </summary>
          public readonly struct P2x11  : IP2Kind<P2x11>
          {
               public byte Exponent {[MethodImpl(Inline)] get => 11;} 

               public ulong Value {[MethodImpl(Inline)] get => T11;} 
          }

          /// <summary>
          /// 2^12 = 4096
          /// </summary>
          public readonly struct P2x12  : IP2Kind<P2x12>
          {
               public byte Exponent {[MethodImpl(Inline)] get => 12;} 

               public ulong Value {[MethodImpl(Inline)] get => T12;} 
          }

          /// <summary>
          /// 2^13 = 8192
          /// </summary>
          public readonly struct P2x13 : IP2Kind<P2x13>
          {
               public byte Exponent {[MethodImpl(Inline)] get => 13;} 

               public ulong Value {[MethodImpl(Inline)] get => T13;} 
          }

          /// <summary>
          /// 2^14 = 16,384
          /// </summary>
          public readonly struct P2x14 : IP2Kind<P2x14>
          {
               public byte Exponent {[MethodImpl(Inline)] get => 14;} 

               public ulong Value {[MethodImpl(Inline)] get => T14;} 
          }

          /// <summary>
          /// 2^15 = 32,768
          /// </summary>
          public readonly struct P2x15 : IP2Kind<P2x15>
          {
               public byte Exponent {[MethodImpl(Inline)] get => 15;} 

               public ulong Value {[MethodImpl(Inline)] get => T15;} 
          }

          /// <summary>
          /// 2^16 = 65,536
          /// </summary>
          public readonly struct P2x16  : IP2Kind<P2x16>
          {
               public byte Exponent {[MethodImpl(Inline)] get => 16;} 

               public ulong Value {[MethodImpl(Inline)] get => T16;} 
          }

          /// <summary>
          /// 2^63 = 9,223,372,036,854,775,808
          /// </summary>
          public readonly struct P2x63  : IP2Kind<P2x63>
          {
               public byte Exponent {[MethodImpl(Inline)] get => 63;} 

               public ulong Value {[MethodImpl(Inline)] get => T63;} 
          }

          /// <summary>
          /// Unrepresentable with ulong; however, in a modular arithmetic context, 2^64 = 1 so
          /// the value property returns 1 and the cycle repeats... 
          /// </summary>
          public readonly struct P2x64 : IP2Kind<P2x64>
          {
               public byte Exponent {[MethodImpl(Inline)] get => 64;} 

               public ulong Value {[MethodImpl(Inline)] get => T00;} 
          }

          /// <summary>
          /// 2^32 - 1 = uint.MaxValue
          /// </summary>
          public readonly struct P2x32m1 
          {
               public byte Exponent {[MethodImpl(Inline)] get => 32;} 

               public ulong Value {[MethodImpl(Inline)] get => T32m1;} 
          }

          /// <summary>
          /// 2^64 - 1 = ulong.MaxValue
          /// </summary>
          public readonly struct P2x64m1 : IP2m1Kind<P2x64>
          {
               public byte Exponent {[MethodImpl(Inline)] get => 64;} 

               public ulong Value {[MethodImpl(Inline)] get => T64m1;} 
          }
     }
}