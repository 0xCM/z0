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
    using static System.Runtime.Intrinsics.X86.Popcnt.X64;
    using Z0;
 
    using static zfunc;
    using static dinx;

    /// <summary>
    /// Implements pop count alogirhtms that follow: 
    /// https://arxiv.org/pdf/1611.07612.pdf 
    /// https://github.com/WojciechMula/sse-popcount
    /// </summary>    
    public static class AvxPops
    {          
        [MethodImpl(Inline)]
        public static ulong pop64(ulong src)
            => PopCount(src);

        [MethodImpl(Inline)]
        public static ulong pop64<T>(Vector256<T> a)      
            where T : unmanaged
        {        
            ginx.vlo(a, out var x0, out var x1);
            var result = pop64(x0) + pop64(x1);
            ginx.vhi(a, out x0, out x1);
            return result + pop64(x0) + pop64(x1);
        }

        [MethodImpl(Inline)]
        public static ulong pop64(ulong a, ulong b, ulong c, ulong d)
            => pop64(a) + pop64(b) + pop64(c) + pop64(d);

        /// <summary>
        /// Implements a carry-save adder that deposits the bitwise sum of three input vectors into two output vectors
        /// </summary>
        /// <param name="a">The first input vector</param>
        /// <param name="b">The second input vector</param>
        /// <param name="c">The third input vector</param>
        /// <param name="lo">The lo part of the result</param>
        /// <param name="hi">THe hi part of the result</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static void vcsa<T>(Vector256<T> a, Vector256<T> b, Vector256<T> c, out Vector256<T> lo, out Vector256<T> hi)
            where T : unmanaged
        {
            var u = ginx.vxor(a,b);
            hi = ginx.vor(ginx.vand(a,b), ginx.vand(u,c));
            lo = ginx.vxor(u,c);            
        }

        /// <summary>
        /// Implements a carry-save adder that deposits the bitwise sum of three input scalars into two output scalars
        /// </summary>
        /// <param name="a">The first input vector</param>
        /// <param name="b">The second input vector</param>
        /// <param name="c">The third input vector</param>
        /// <param name="lo">The lo part of the result</param>
        /// <param name="hi">THe hi part of the result</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static void csa<T>(T a, T b, T c, out T lo, out T hi)
            where T : unmanaged
        {
            var u = gmath.xor(a,b);
            hi = gmath.or(gmath.and(a,b), gmath.and(u,c));
            lo = gmath.xor(u,c);
        }

        [MethodImpl(Inline)]
        static Vector128<byte> M1(N128 n)  
            => vbroadcast(n128,(byte)0x55);

        [MethodImpl(Inline)]
        static Vector128<byte> M2(N128 n)   
            => vbroadcast(n128,(byte)0x33);

        [MethodImpl(Inline)]
        static Vector128<byte> M4(N128 n)  
            => vbroadcast(n128,(byte)0x0F);

        [MethodImpl(Inline)]
        static Vector256<byte> M1(N256 n) 
            => vbroadcast(n256,(byte)0x55);

        [MethodImpl(Inline)]
        static Vector256<byte> M2(N256 n)  
            => vbroadcast(n256,(byte)0x33);

        [MethodImpl(Inline)]
        static Vector256<byte> M4(N256 n)  
            => vbroadcast(n256,(byte)0x0F);

        [MethodImpl(Inline)]
        public static Vector128<ushort> avxpop(Vector128<ushort> v, N128 n = default)
        {
            var t1 = vsub(v8u(v),           vand(v8u(vsrl(v,  1)), M1(n)));
            var t2 = vadd(vand(t1, M2(n)),  vand(v8u(vsrl(t1, 2)), M2(n)));
            var t3 = vadd(t2,               vand(v8u(vsrl(t2, 4)), M4(n)));
            return vsad(t3, default);
        }

        [MethodImpl(Inline)]
        public static Vector256<ushort> avxpop(Vector256<ushort> v, N256 n = default)
        {
            var t1 = vsub(v8u(v),           vand(v8u(vsrl(v,  1)), M1(n)));
            var t2 = vadd(vand(t1, M2(n)),  vand(v8u(vsrl(t1, 2)), M2(n)));
            var t3 = vadd(t2,               vand(v8u(vsrl(t2, 4)), M4(n)));
            return vsad(t3, default);
        }

        /// <summary>
        /// Creates a zero-filled 256x64u cpu vector
        /// </summary>
        /// <param name="n">The bitness selector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vzero64u(N256 n)
            => default;


        [MethodImpl(Inline)]
        public static ulong popcsa_1(in ulong data)
        {
            const int step = 4;
            var n = n256;            
            var total = vzero64u(n);

            Vector256<ulong> v1 = vzero64u(n), v2 = vzero64u(n), v4 = vzero64u(n), 
                v8 = vzero64u(n), v16 = vzero64u(n256);

            Vector256<ulong> v2a = vzero64u(n), v2b = vzero64u(n), v4a = vzero64u(n), v4b = vzero64u(n);

            vcsa(v1, vload(n,in data, 0*step), vload(n, in data, 1*step), out v2a, out v1);
            vcsa(v1, vload(n,in data, 2*step), vload(n, in data, 3*step), out v2b, out v1);
            vcsa(v2, v2a, v2b, out v4a, out v2);

            return vsum(v4a);
        }

    }

}