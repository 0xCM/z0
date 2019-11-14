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
    using static As;

    partial class math
    {

        [MethodImpl(Inline)]
        public static sbyte or(sbyte a, sbyte b)
            => (sbyte)(a | b);
            
        [MethodImpl(Inline)]
        public static byte or(byte a, byte b)
            => (byte)(a | b);

        [MethodImpl(Inline)]
        public static short or(short a, short b)
            => (short)(a | b);

        [MethodImpl(Inline)]
        public static ushort or(ushort a, ushort b)
            => (ushort)(a | b);

        [MethodImpl(Inline)]
        public static int or(int a, int b)
            => a | b;

        [MethodImpl(Inline)]
        public static uint or(uint a, uint b)
            => a | b;

        [MethodImpl(Inline)]
        public static long or(long a, long b)
            => a | b;

        [MethodImpl(Inline)]
        public static ulong or(ulong a, ulong b)
            => a | b;


        [MethodImpl(Inline)]
        public static float or(float a, float b)
            => BitConverter.Int32BitsToSingle(a.ToBits() | b.ToBits());

        [MethodImpl(Inline)]
        public static double or(double a, double b)
            => BitConverter.Int64BitsToDouble(a.ToBits() | b.ToBits());         
 
        [MethodImpl(Inline)]
        public static ref sbyte or(ref sbyte a, sbyte b)
        {
            a = (sbyte)(a | b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref byte or(ref byte a, byte b)
        {
            a = (byte)(a | b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref short or(ref short a, short b)
        {
            a = (short)(a | b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref ushort or(ref ushort a, ushort b)
        {
            a = (ushort)(a | b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref int or(ref int a, int b)
        {
            a = a | b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref uint or(ref uint a, uint b)
        {
            a = a | b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref long or(ref long a, long b)
        {
            a = a | b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref ulong or(ref ulong a, ulong b)
        {
            a = a | b;
            return ref a;
        }

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