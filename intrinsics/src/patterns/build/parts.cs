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
    using static ginx;
    using static As;

    partial class vbuild
    {
        /// <summary>
        /// Defines a 128-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> parts(N128 w,
            byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7,
            byte x8, byte x9, byte xa, byte xb, byte xc, byte xd, byte xe, byte xf)
                => Vector128.Create(x0,x1, x2, x3, x4, x5, x6, x7,x8,x9,xa,xb,xc,xd,xe,xf);

        /// <summary>
        /// Defines a 128-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> parts(N128 w, ushort x0, ushort x1, ushort x2, ushort x3, ushort x4, ushort x5, ushort x6, ushort x7)
            => Vector128.Create(x0,x1, x2, x3, x4, x5, x6, x7);

        /// <summary>
        /// Defines a 128-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> parts(N128 w,uint x0, uint x1, uint x2, uint x3)
            => Vector128.Create(x0, x1, x2, x3);

        /// <summary>
        /// Defines a 128-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> parts(uint x0, uint x1, uint x2, uint x3)
            => Vector128.Create(x0,x1, x2, x3);

        /// <summary>
        /// Defines a 128-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> partsi(N128 w, int x0, int x1, int x2, int x3)
            => Vector128.Create(x0,x1, x2, x3);

        /// <summary>
        /// Defines a 128-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> partsi(N128 w, long x0, long x1)
            => Vector128.Create(x0,x1);

        /// <summary>
        /// Defines a 128-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> parts(N128 w, ulong x0, ulong x1)
            => Vector128.Create(x0,x1);

        /// <summary>
        /// Defines a 128-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector128<float> partsf(N128 w, float x0, float x1, float x2, float x3)
            => Vector128.Create(x0,x1,x2,x3);

        /// <summary>
        /// Defines a 128-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector128<double> partsf(N128 w,double x0, double x1)
            => Vector128.Create(x0,x1);

        /// <summary>
        /// Defines a 256-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> parts(N256 w,
            byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7,
            byte x8, byte x9, byte xa, byte xb, byte xc, byte xd, byte xe, byte xf,
            byte x10, byte x11, byte x12, byte x13, byte x14, byte x15, byte x16, byte x17,
            byte x18, byte x19, byte x1a, byte x1b, byte x1c, byte x1d, byte x1e, byte x1f            
            )   => Vector256.Create(
                    x0,x1,x2,x3,x4,x5,x6, x7,x8,x9,xa,xb,xc,xd,xe,xf,
                    x10,x11,x12,x13,x14,x15, x16,x17,x18,x19,x1a,x1b,x1c,x1d,x1e,x1f);

        /// <summary>
        /// Defines a 256-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> parts(N256 w, 
            ushort x0, ushort x1, ushort x2, ushort x3, ushort x4, ushort x5, ushort x6, ushort x7,
            ushort x8, ushort x9, ushort xA, ushort xB, ushort xC, ushort xD, ushort xE, ushort xF)
                => Vector256.Create(x0,x1, x2, x3, x4, x5, x6, x7,x8,x9,xA,xB,xC,xD,xE,xF);

        /// <summary>
        /// Defines a 256-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> partsi(N256 w, 
            short x0, short x1, short x2, short x3, short x4, short x5, short x6, short x7,
            short x8, short x9, short xA, short xB, short xC, short xD, short xE, short xF)
                => Vector256.Create(x0,x1, x2, x3, x4, x5, x6, x7,x8,x9,xA,xB,xC,xD,xE,xF);

        /// <summary>
        /// Defines a 256-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> partsi(N256 w, int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7)
            => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Defines a 256-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> parts(N256 w,
            uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Defines a 256-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> partsi(N256 w, long x0, long x1, long x2, long x3)
            => Vector256.Create(x0,x1,x2,x3);

        /// <summary>
        /// Defines a 256-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> parts(N256 w, ulong x0, ulong x1, ulong x2, ulong x3)
            => Vector256.Create(x0,x1,x2,x3);

        /// <summary>
        /// Defines a 256-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector256<float> partsf(N256 w, float x0, float x1, float x2, float x3, float x4, float x5, float x6, float x7)
            => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Defines a 256-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector256<double> partsf(N256 w, double x0, double x1, double x2, double x3)
            => Vector256.Create(x0,x1,x2,x3);

        /// <summary>
        /// Defines a 512-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector512<int> partsi(N512 w, int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7,
            int x8, int x9, int x10, int x11, int x12, int x13, int x14, int x15)        
                => Vector512.Create(x0,x1, x2, x3,x4,x5,x6,x7,x8,x9,x10,x11,x12,x13,x14,x15); 
                        
        /// <summary>
        /// Defines a 512-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector512<uint> parts(N512 w,uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7,
            uint x8, uint x9, uint x10, uint x11, uint x12, uint x13, uint x14, uint x15)        
                => Vector512.Create(x0,x1, x2, x3,x4,x5,x6,x7,x8,x9,x10,x11,x12,x13,x14,x15); 

        /// <summary>
        /// Defines a 512-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector512<long> partsi(N512 w, long x0, long  x1, long  x2, long  x3, long x4, long  x5, long  x6, long  x7)
            => Vector512.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Defines a 512-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector512<ulong> parts(N512 w, ulong x0, ulong  x1, ulong  x2, ulong  x3, ulong x4, ulong  x5, ulong  x6, ulong  x7)
            => Vector512.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Defines a 512-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector512<float> partsf(N512 w, float x0, float x1, float x2, float x3, float x4, float x5, float x6, float x7,
            float x8, float x9, float x10, float x11, float x12, float x13, float x14, float x15)        
                => Vector512.Create(x0,x1, x2, x3,x4,x5,x6,x7,x8,x9,x10,x11,x12,x13,x14,x15); 

        /// <summary>
        /// Defines a 512-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        public static Vector512<double> partsf(N512 w, double x0, double  x1, double  x2, double  x3, double x4, double  x5, double  x6, double  x7)
            => Vector512.Create(x0,x1,x2,x3,x4,x5,x6,x7);

    }

}