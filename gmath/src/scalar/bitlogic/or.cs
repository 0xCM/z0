//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class math
    {

        [MethodImpl(Inline)]
        public static sbyte or(sbyte a, sbyte b)
            => (sbyte)(a | b);

        [MethodImpl(Inline)]
        public static sbyte or(sbyte a, sbyte b, sbyte c)
            => (sbyte)or((int)a, (int)b, (int)c);

        [MethodImpl(Inline)]
        public static byte or(byte a, byte b)
            => (byte)(a | b);

        [MethodImpl(Inline)]
        public static byte or(byte a, byte b, byte c)
            => (byte)or((uint)a, (uint)b, (uint)c);

        [MethodImpl(Inline)]
        public static short or(short a, short b)
            => (short)(a | b);

        [MethodImpl(Inline)]
        public static short or(short a, short b, short c)
            => (short)or((int)a, (int)b, (int)c);

        [MethodImpl(Inline)]
        public static ushort or(ushort a, ushort b)
            => (ushort)(a | b);

        [MethodImpl(Inline)]
        public static ushort or(ushort a, ushort b, ushort c)
            => (ushort)or((uint)a, (uint)b, (uint)c);

        [MethodImpl(Inline)]
        public static int or(int a, int b)
            => a | b;

        [MethodImpl(Inline)]
        public static int or(int a, int b, int c)
            => a | b | c;

        [MethodImpl(Inline)]
        public static uint or(uint a, uint b)
            => a | b;

        [MethodImpl(Inline)]
        public static uint or(uint a, uint b, uint c)
            => a | b | c;

        [MethodImpl(Inline)]
        public static long or(long a, long b)
            => a | b;

        [MethodImpl(Inline)]
        public static long or(long a, long b, long c)
            => a | b | c;

        [MethodImpl(Inline)]
        public static ulong or(ulong a, ulong b)
            => a | b;

        [MethodImpl(Inline)]
        public static ulong or(ulong a, ulong b, ulong c)
            => a | b | c;

        [MethodImpl(Inline)]
        public static float or(float a, float b)
            => BitConverter.Int32BitsToSingle(a.ToBits() | b.ToBits());

        [MethodImpl(Inline)]
        public static float or(float a, float b, float c)
            => BitConverter.Int32BitsToSingle(a.ToBits() | b.ToBits() | c.ToBits());

        [MethodImpl(Inline)]
        public static double or(double a, double b)
            => BitConverter.Int64BitsToDouble(a.ToBits() | b.ToBits());         

        [MethodImpl(Inline)]
        public static double or(double a, double b, double c)
            => BitConverter.Int64BitsToDouble(a.ToBits() | b.ToBits() | c.ToBits());         

        [MethodImpl(Inline)]
        public static ref float or(ref float a, float b)
        {
            a = or(a,b);
            return ref a;
        }


        [MethodImpl(Inline)]
        public static ref double or(ref double a, double b)
        {
            a = or(a,b);
            return ref a;
        }

 
    }
}