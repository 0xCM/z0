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
        /// Defines a cpu vector by its constituent parts, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector128<byte> vparts(N128 n,
            byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7,
            byte x8, byte x9, byte xa, byte xb, byte xc, byte xd, byte xe, byte xf)
                => Vector128.Create(x0,x1, x2, x3, x4, x5, x6, x7,x8,x9,xa,xb,xc,xd,xe,xf);

        /// <summary>
        /// Defines a cpu vector by its constituent parts from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vparts(N128 n, ushort x0, ushort x1, ushort x2, ushort x3, ushort x4, ushort x5, ushort x6, ushort x7)
            => Vector128.Create(x0,x1, x2, x3, x4, x5, x6, x7);

        /// <summary>
        /// Defines a cpu vector by its constituent parts, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector128<uint> vparts(N128 n,uint x0, uint x1, uint x2, uint x3)
            => Vector128.Create(x0, x1, x2, x3);

        /// <summary>
        /// Defines a cpu vector by its constituent parts, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector128<uint> vparts(uint x0, uint x1, uint x2, uint x3)
            => Vector128.Create(x0,x1, x2, x3);

        /// <summary>
        /// Defines a cpu vector by its constituent parts, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector128<long> vparts(long x0, long x1)
            => Vector128.Create(x0,x1);

        /// <summary>
        /// Defines a cpu vector by its constituent parts, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vparts(N128 n, ulong x0, ulong x1)
            => Vector128.Create(x0,x1);

        /// <summary>
        /// Defines a cpu vector by its constituent parts, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector128<float> vparts(N128 n, float x0, float x1, float x2, float x3)
            => Vector128.Create(x0,x1,x2,x3);

        /// <summary>
        /// Defines a cpu vector by its constituent parts, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector128<double> vparts(N128 n,double x0, double x1)
            => Vector128.Create(x0,x1);

        /// <summary>
        /// Defines a cpu vector by its constituent parts, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector256<int> vparts(N256 n, int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7)
            => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Defines a cpu vector by its constituent parts, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector256<uint> vparts(N256 n,uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
            => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Defines a cpu vector by its constituent parts, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector256<long> vparts(long x0, long x1, long x2, long x3)
            => Vector256.Create(x0,x1,x2,x3);

        /// <summary>
        /// Defines a cpu vector by its constituent parts, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vparts(ulong x0, ulong x1, ulong x2, ulong x3)
            => Vector256.Create(x0,x1,x2,x3);

        /// <summary>
        /// Defines a cpu vector by its constituent parts, from least -> most significant
        /// </summary>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vparts(N256 n, ulong x0, ulong x1, ulong x2, ulong x3)
            => Vector256.Create(x0,x1,x2,x3);
    }
}