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
    
    partial class gparts
    {     

        [MethodImpl(Inline)]
        public static void negate<T>(N256 n, in T a, ref T z)
            where T : unmanaged
        {
            ginx.vnegate(n, in a, ref z);
        }

        [MethodImpl(Inline)]
        public static void negate<T>(N256 n, int partcount, int partwidth, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vnegate(n, in skip(in a, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void inc<T>(N256 n, in T a, ref T z)
            where T : unmanaged
        {
            ginx.vinc(n, in a, ref z);
        }

        [MethodImpl(Inline)]
        public static void vinc<T>(N256 n, int partcount, int partwidth, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vinc(n, in skip(in a, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void dec<T>(N256 n, in T a, ref T z)
            where T : unmanaged
        {
            ginx.vdec(n, in a, ref z);
        }

        [MethodImpl(Inline)]
        public static void vdec<T>(N256 n, int partcount, int partwidth, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vdec(n, in skip(in a, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void not<T>(N256 n, in T a, ref T z)
            where T : unmanaged
        {
            ginx.vnot(n, in a, ref z);
        }

        [MethodImpl(Inline)]
        public static void not<T>(N256 n, int partcount, int partwidth, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vnot(n, in skip(in a, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void and<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vand(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void and<T>(N256 n, int partcount, int partwidth, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vand(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void nand<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vnand(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void nand<T>(N256 n, int partcount, int partwidth, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vnand(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void or<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vor(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void or<T>(N256 n, int partcount, int partwidth, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }


        [MethodImpl(Inline)]
        public static void nor<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vnor(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void nor<T>(N256 n, int partcount, int partwidth, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vnor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void xor<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vxor(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void xor<T>(N256 n, int partcount, int partwidth, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vxor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void xnor<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vxnor(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void xnor<T>(N256 n, int partcount, int partwidth, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vxnor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void imply<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vimply(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void imply<T>(N256 n, int partcount, int partwidth, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vimply(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void notimply<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vnotimply(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void notimply<T>(N256 n, int partcount, int partwidth, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vnotimply(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void cimply<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vcimply(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void cimply<T>(N256 n, int partcount, int partwidth, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vcimply(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void cnotimply<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vcnotimply(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void cnotimply<T>(N256 n, int partcount, int partwidth, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vcnotimply(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void select<T>(N256 n, in T a, in T b, in T c, ref T z)
            where T : unmanaged
        {
            ginx.vselect(n, in a, in b, in c, ref z);
        }

        [MethodImpl(Inline)]
        public static void select<T>(N256 n, int partcount, int partwidth, in T a, in T b, in T c, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vselect(n, in skip(in a, offset), in skip(in b, offset), in skip(in c, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void sll<T>(N256 n, in T a, byte count, ref T z)
            where T : unmanaged
        {
            ginx.vsll(n, in a, count, ref z);
        }

        [MethodImpl(Inline)]
        public static void sll<T>(N256 n, int partcount, int partwidth, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vsll(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void srl<T>(N256 n, in T a, byte count, ref T z)
            where T : unmanaged
        {
            ginx.vsrl(n, in a, count, ref z);
        }

        [MethodImpl(Inline)]
        public static void srl<T>(N256 n, int partcount, int partwidth, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vsrl(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void rotl<T>(N256 n, in T a, byte count, ref T z)
            where T : unmanaged
        {
            ginx.vrotl(n, in a, count, ref z);
        }

        [MethodImpl(Inline)]
        public static void rotl<T>(N256 n, int partcount, int partwidth, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vrotl(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void rotr<T>(N256 n, in T a, byte count, ref T z)
            where T : unmanaged
        {
            ginx.vrotr(n, in a, count, ref z);
        }

        [MethodImpl(Inline)]
        public static void rotr<T>(N256 n, int partcount, int partwidth, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vrotr(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void bsll<T>(N256 n, in T a, byte count, ref T z)
            where T : unmanaged
        {
            ginx.vbsll(n, in a, count, ref z);
        }

        [MethodImpl(Inline)]
        public static void bsll<T>(N256 n, int partcount, int partwidth, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vbsll(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void bsrl<T>(N256 n, in T a, byte count, ref T z)
            where T : unmanaged
        {
            ginx.vbsrl(n, in a, count, ref z);
        }

        [MethodImpl(Inline)]
        public static void bsrl<T>(N256 n, int partcount, int partwidth, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vbsrl(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void add<T>(N256 n, int partcount, int partwidth, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vadd(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void sub<T>(N256 n, int partcount, int partwidth, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vsub(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void max<T>(N256 n, int partcount, int partwidth, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vmax(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void eq<T>(N256 n, int partcount, int partwidth, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.veq(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void gt<T>(N256 n, int partcount, int partwidth, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vgt(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void lt<T>(N256 n, int partcount, int partwidth, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                ginx.vlt(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static bool nonz<T>(N256 n, int partcount, int partwidth, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                result &= ginx.vnonz(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bool testc<T>(N256 n, int partcount, int partwidth, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                result &= ginx.vtestc(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bool testc<T>(N256 n, int partcount, int partwidth, in T a, in T b)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                result &= ginx.vtestc(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bool testz<T>(N256 n, int partcount, int partwidth, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                result &= ginx.vtestz(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bool testz<T>(N256 n, int partcount, int partwidth, in T a, in T b)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                result &= ginx.vtestz(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bool testznc<T>(N256 n, int partcount, int partwidth, in T a, in T b)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < partcount; i++, offset += partwidth)
                result &= ginx.vtestznc(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }
    }

}



