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
        /// <summary>
        /// Computes z := (a*b) mod m
        /// </summary>
        /// <param name="a">The first factor</param>
        /// <param name="b">The second factor</param>
        /// <param name="m">The modulus</param>
        [MethodImpl(Inline), Op]
        public static sbyte modmul(sbyte a, sbyte b, sbyte m)
            => (sbyte)((a*b) % m);

        /// <summary>
        /// Computes z := (a*b) mod m
        /// </summary>
        /// <param name="a">The first factor</param>
        /// <param name="b">The second factor</param>
        /// <param name="m">The modulus</param>
        [MethodImpl(Inline), Op]
        public static byte modmul(byte a, byte b, byte m)
            => (byte)((a*b) % m);

        /// <summary>
        /// Computes z := (a*b) mod m
        /// </summary>
        /// <param name="a">The first factor</param>
        /// <param name="b">The second factor</param>
        /// <param name="m">The modulus</param>
        [MethodImpl(Inline), Op]
        public static short modmul(short a, short b, short m)
            => (short)((a*b) % m);

        /// <summary>
        /// Computes z := (a*b) mod m
        /// </summary>
        /// <param name="a">The first factor</param>
        /// <param name="b">The second factor</param>
        /// <param name="m">The modulus</param>
        [MethodImpl(Inline), Op]
        public static ushort modmul(ushort a, ushort b, ushort m)
            => (ushort)((a*b) % m);

        /// <summary>
        /// Computes z := (a*b) mod m
        /// </summary>
        /// <param name="a">The first factor</param>
        /// <param name="b">The second factor</param>
        /// <param name="m">The modulus</param>
        [MethodImpl(Inline), Op]
        public static int modmul(int a, int b, int m)
            => (a*b) % m;

        /// <summary>
        /// Computes z := (a*b) mod m
        /// </summary>
        /// <param name="a">The first factor</param>
        /// <param name="b">The second factor</param>
        /// <param name="m">The modulus</param>
        [MethodImpl(Inline), Op]
        public static uint modmul(uint a, uint b, uint m)
            => (a*b) % m;

        /// <summary>
        /// Computes z := (a*b) mod m
        /// </summary>
        /// <param name="a">The first factor</param>
        /// <param name="b">The second factor</param>
        /// <param name="m">The modulus</param>
        [MethodImpl(Inline), Op]
        public static long modmul(long a, long b, long m)
            => (a*b) % m;

        /// <summary>
        /// Computes z := (a*b) mod m
        /// </summary>
        /// <param name="a">The first factor</param>
        /// <param name="b">The second factor</param>
        /// <param name="m">The modulus</param>
        [MethodImpl(Inline), Op]
        public static ulong modmul(ulong a, ulong b, ulong m)
            => (a*b) % m;

        /// <summary>
        /// Computes z := (a*b) mod m
        /// </summary>
        /// <param name="a">The first factor</param>
        /// <param name="b">The second factor</param>
        /// <param name="m">The modulus</param>
        [MethodImpl(Inline), Op]
        public static float modmul(float a, float b, float m)
            => (a*b) % m;

        /// <summary>
        /// Computes z := (a*b) mod m
        /// </summary>
        /// <param name="a">The first factor</param>
        /// <param name="b">The second factor</param>
        /// <param name="m">The modulus</param>
        [MethodImpl(Inline), Op]
        public static double modmul(double a, double b, double m)
            => (a*b) % m;

    }
}