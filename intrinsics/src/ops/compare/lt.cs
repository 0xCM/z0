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
    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static X86Missing;

    using static zfunc;    

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vector128<sbyte> vlt(Vector128<sbyte> x, Vector128<sbyte> y)
            => CompareLessThan(x,y);

        [MethodImpl(Inline)]
        public static Vector128<byte> vlt(Vector128<byte> x, Vector128<byte> y)
        {
            var mask = CpuVector.vbroadcast(n128,CmpMask8u);
            var mx = vxor(x,mask).AsSByte();
            var my = vxor(y,mask).AsSByte();
            return CompareLessThan(mx,my).AsByte();
        }

        [MethodImpl(Inline)]
        public static Vector128<short> vlt(Vector128<short> x, Vector128<short> y)
            => CompareLessThan(x,y);

        [MethodImpl(Inline)]
        public static Vector128<ushort> vlt(Vector128<ushort> x, Vector128<ushort> y)
        {
            var mask = CpuVector.vbroadcast(n128,CmpMask16u);
            var mx = vxor(x,mask).AsInt16();
            var my = vxor(y,mask).AsInt16();
            return CompareLessThan(mx,my).AsUInt16();
        }

        /// <summary>
        /// __m128i _mm_vcmplt_epi32 (__m128i a, __m128i b)PCMPGTD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vlt(Vector128<int> x, Vector128<int> y)
            => CompareLessThan(x,y);

        /// <summary>
        /// __m128i _mm_vcmplt_epi32 (__m128i a, __m128i b)PCMPGTD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vlt(Vector128<uint> x, Vector128<uint> y)
        {
            var mask = CpuVector.vbroadcast(n128,CmpMask32u);
            var mx = vxor(x,mask).AsInt32();
            var my = vxor(y,mask).AsInt32();
            return CompareLessThan(mx,my).AsUInt32();
        }

        [MethodImpl(Inline)]
        public static Vector128<long> vlt(Vector128<long> x, Vector128<long> y)
        {
            var a = vconcat(x,y);
            var b = vswaphl(a);
            return vlo(vlt(a,b));
        }

        [MethodImpl(Inline)]
        public static Vector128<ulong> vlt(Vector128<ulong> x, Vector128<ulong> y)
        {
            var a = vconcat(x,y);
            var b = vswaphl(a);
            return vlo(vlt(a,b));
        }
        
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vlt(Vector256<sbyte> x, Vector256<sbyte> y)
            => CompareLessThan(x,y);

        [MethodImpl(Inline)]
        public static Vector256<byte> vlt(Vector256<byte> x, Vector256<byte> y)
        {
            var mask = CpuVector.vbroadcast(n256,CmpMask8u);
            var mx = vxor(x,mask).AsSByte();
            var my = vxor(y,mask).AsSByte();
            return CompareLessThan(mx,my).AsByte();
        }

        [MethodImpl(Inline)]
        public static Vector256<short> vlt(Vector256<short> x, Vector256<short> y)
            => CompareLessThan(x,y);

        [MethodImpl(Inline)]
        public static Vector256<ushort> vlt(Vector256<ushort> x, Vector256<ushort> y)
        {
            var mask = CpuVector.vbroadcast(n256,CmpMask16u);
            var mx = vxor(x,mask).AsInt16();
            var my = vxor(y,mask).AsInt16();
            return CompareLessThan(mx,my).AsUInt16();
        }

        [MethodImpl(Inline)]
        public static Vector256<int> vlt(Vector256<int> x, Vector256<int> y)
            => CompareLessThan(x,y);

        [MethodImpl(Inline)]
        public static Vector256<uint> vlt(Vector256<uint> x, Vector256<uint> y)
        {
            var mask = CpuVector.vbroadcast(n256,CmpMask32u);
            var mx = vxor(x,mask).AsInt32();
            var my = vxor(y,mask).AsInt32();
            return CompareLessThan(mx,my).AsUInt32();
        }

        [MethodImpl(Inline)]
        public static Vector256<long> vlt(Vector256<long> x, Vector256<long> y)
            => CompareLessThan(x,y);

    
        [MethodImpl(Inline)]
        public static Vector256<ulong> vlt(Vector256<ulong> x, Vector256<ulong> y)
        {
            var mask = CpuVector.vbroadcast(n256,CmpMask64u);
            var mx = vxor(x,mask).AsInt64();
            var my = vxor(y,mask).AsInt64();
            return CompareLessThan(mx,my).AsUInt64();
        }
    }

    static class X86Missing
    {
        [MethodImpl(Inline)]
        public static Vector256<sbyte> CompareLessThan(Vector256<sbyte> x, Vector256<sbyte> y)
            => CompareGreaterThan(y,x);

        [MethodImpl(Inline)]
        public static Vector256<short> CompareLessThan(Vector256<short> x, Vector256<short> y)
            => CompareGreaterThan(y,x);

        [MethodImpl(Inline)]
        public static Vector256<int> CompareLessThan(Vector256<int> x, Vector256<int> y)
            => CompareGreaterThan(y,x);

        [MethodImpl(Inline)]
        public static Vector256<long> CompareLessThan(Vector256<long> x, Vector256<long> y)
            => CompareGreaterThan(y,x);
    }
}