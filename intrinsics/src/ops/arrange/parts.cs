//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    partial class dinx
    {
        /// <summary>
        /// Defines a 128-bit cpu vector componentwise, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector128<byte> vparts(N128 n,
            byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7,
            byte x8, byte x9, byte xa, byte xb, byte xc, byte xd, byte xe, byte xf)
                => Vector128.Create(x0,x1, x2, x3, x4, x5, x6, x7,x8,x9,xa,xb,xc,xd,xe,xf);


        /// <summary>
        /// Defines a 128-bit cpu vector componentwise, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vparts(N128 n, ushort x0, ushort x1, ushort x2, ushort x3, ushort x4, ushort x5, ushort x6, ushort x7)
            => Vector128.Create(x0,x1, x2, x3, x4, x5, x6, x7);

        /// <summary>
        /// Defines a 128-bit cpu vector componentwise, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector128<uint> vparts(N128 n,uint x0, uint x1, uint x2, uint x3)
            => Vector128.Create(x0, x1, x2, x3);

        /// <summary>
        /// Defines a 128-bit cpu vector componentwise, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector128<uint> vparts(uint x0, uint x1, uint x2, uint x3)
            => Vector128.Create(x0,x1, x2, x3);

        /// <summary>
        /// Defines a 128-bit cpu vector componentwise, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector128<int> vpartsi(N128 n, int x0, int x1, int x2, int x3)
            => Vector128.Create(x0,x1, x2, x3);

        /// <summary>
        /// Defines a 128-bit cpu vector componentwise, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector128<long> vpartsi(N128 n, long x0, long x1)
            => Vector128.Create(x0,x1);

        /// <summary>
        /// Defines a 128-bit cpu vector componentwise, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vparts(N128 n, ulong x0, ulong x1)
            => Vector128.Create(x0,x1);

        /// <summary>
        /// Defines a 128-bit cpu vector componentwise, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector128<float> vparts(N128 n, float x0, float x1, float x2, float x3)
            => Vector128.Create(x0,x1,x2,x3);

        /// <summary>
        /// Defines a 128-bit cpu vector componentwise, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector128<double> vparts(N128 n,double x0, double x1)
            => Vector128.Create(x0,x1);

        /// <summary>
        /// Defines a 256-bit cpu vector componentwise, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector256<byte> vparts(N256 n,
            byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7,
            byte x8, byte x9, byte xa, byte xb, byte xc, byte xd, byte xe, byte xf,
            byte x10, byte x11, byte x12, byte x13, byte x14, byte x15, byte x16, byte x17,
            byte x18, byte x19, byte x1a, byte x1b, byte x1c, byte x1d, byte x1e, byte x1f            
            )   => Vector256.Create(
                    x0,x1,x2,x3,x4,x5,x6, x7,x8,x9,xa,xb,xc,xd,xe,xf,
                    x10,x11,x12,x13,x14,x15, x16,x17,x18,x19,x1a,x1b,x1c,x1d,x1e,x1f);
        /// <summary>
        /// Defines a 256-bit cpu vector componentwise, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vparts(N256 n, 
            ushort x0, ushort x1, ushort x2, ushort x3, ushort x4, ushort x5, ushort x6, ushort x7,
            ushort x8, ushort x9, ushort xA, ushort xB, ushort xC, ushort xD, ushort xE, ushort xF)
                => Vector256.Create(x0,x1, x2, x3, x4, x5, x6, x7,x8,x9,xA,xB,xC,xD,xE,xF);

        /// <summary>
        /// Defines a 256-bit cpu vector componentwise, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector256<short> vpartsi(N256 n, 
            short x0, short x1, short x2, short x3, short x4, short x5, short x6, short x7,
            short x8, short x9, short xA, short xB, short xC, short xD, short xE, short xF)
                => Vector256.Create(x0,x1, x2, x3, x4, x5, x6, x7,x8,x9,xA,xB,xC,xD,xE,xF);

        /// <summary>
        /// Defines a cpu vector by its constituent parts, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector256<int> vpartsi(N256 n, int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Defines a 256-bit cpu vector componentwise, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector256<uint> vparts(N256 n,
            uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Defines a cpu vector by its constituent parts, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector256<long> vpartsi(N256 n, long x0, long x1, long x2, long x3)
            => Vector256.Create(x0,x1,x2,x3);

        /// <summary>
        /// Defines a cpu vector by its constituent parts, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vparts(N256 n, ulong x0, ulong x1, ulong x2, ulong x3)
            => Vector256.Create(x0,x1,x2,x3);
    }
}