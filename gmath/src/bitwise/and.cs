//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    

    partial class math
    {
        [MethodImpl(Inline)]
        public static sbyte and(sbyte a, sbyte b)
            => (sbyte)(a & b);

        [MethodImpl(Inline)]
        public static byte and(byte a, byte b)
            => (byte)(a & b);

        [MethodImpl(Inline)]
        public static short and(short a, short b)
            => (short)(a & b);

        [MethodImpl(Inline)]
        public static ushort and(ushort a, ushort b)
            => (ushort)(a & b);

        [MethodImpl(Inline)]
        public static int and(int a, int b)
            => a & b;

        [MethodImpl(Inline)]
        public static uint and(uint a, uint b)
            => a & b;

        [MethodImpl(Inline)]
        public static long and(long a, long b)
            => a & b;

        [MethodImpl(Inline)]
        public static ulong and(ulong a, ulong b)
            => a & b;

        [MethodImpl(Inline)]
        public static float and(float a, float b)
            => BitConverter.Int32BitsToSingle(a.ToBits() & b.ToBits());

        [MethodImpl(Inline)]
        public static double and(double a, double b)
            => BitConverter.Int64BitsToDouble(a.ToBits() & b.ToBits());

        [MethodImpl(Inline)]
        public static ref sbyte and(in sbyte a, in sbyte b, ref sbyte dst)
        {
            dst = (sbyte)(a & b);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref byte and(in byte a, in byte b, ref byte dst)
        {
            dst = (byte)(a & b);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref short and(in short a, in short b, ref short dst)
        {
            dst = (short)(a & b);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ushort and(in ushort a, in ushort b, ref ushort dst)
        {
            dst = (ushort)(a & b);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref int and(in int a, in int b, ref int dst)
        {
            dst = a & b;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint and(in uint a, in uint b, ref uint dst)
        {
            dst = a & b;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref long and(in long a, in long b, ref long dst)
        {
            dst = a & b;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong and(in ulong a, in ulong b, ref ulong dst)
        {
            dst = a & b;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref float and(in float a, in float b, ref float dst)
        {
            dst = BitConverter.Int32BitsToSingle(a.ToBits() & b.ToBits());
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref double and(in double a, in double b, ref double dst)
        {
            dst = BitConverter.Int64BitsToDouble(a.ToBits() & b.ToBits());
            return ref dst;
        }
            
        [MethodImpl(Inline)]
        public static ref sbyte and(ref sbyte a, sbyte b)
        {
            a = (sbyte)(a & b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref byte and(ref byte a, byte b)
        {
            a = (byte)(a & b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref short and(ref short a, short b)
        {
            a = (short)(a & b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref ushort and(ref ushort a, ushort b)
        {
            a = (ushort)(a & b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref int and(ref int a, int b)
        {
            a = a & b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref uint and(ref uint a, uint b)
        {
            a = a & b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref long and(ref long a, long b)
        {
            a = a & b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref ulong and(ref ulong a, ulong b)
        {
            a = a & b;
            return ref a;
        }
 
        [MethodImpl(Inline)]
        public static ref float and(ref float a, float b)
        {
            a = and(a,b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref double and(ref double a, double b)
        {
            a = and(a,b);
            return ref a;
        }


   }

}