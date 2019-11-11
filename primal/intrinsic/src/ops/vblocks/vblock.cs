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
    
    partial class vblock
    {     
        // ~ negate

        [MethodImpl(Inline)]
        public static Vector128<T> vnegate<T>(N128 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vnegate(vA);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vnegate<T>(N256 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vnegate(vA);
        }

        [MethodImpl(Inline)]
        public static void negate<T>(N128 n, in T a, ref T z)
            where T : unmanaged
                => vstore(vnegate(n,in a), ref z);                    

        [MethodImpl(Inline)]
        public static void negate<T>(N128 n, int vcount, int step, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                negate(n, in skip(in a, offset), ref seek(ref z, offset));
        }        

        [MethodImpl(Inline)]
        public static void negate<T>(N256 n, in T a, ref T z)
            where T : unmanaged
                => vstore(vnegate(n,in a), ref z);                    

        [MethodImpl(Inline)]
        public static void negate<T>(N256 n, int vcount, int step, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                negate(n, in skip(in a, offset), ref seek(ref z, offset));
        }

        // ~ inc

        [MethodImpl(Inline)]
        public static Vector128<T> vinc<T>(N128 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vinc(vA);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vinc<T>(N256 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vinc(vA);
        }

        [MethodImpl(Inline)]
        public static void inc<T>(N128 n, in T a, ref T z)
            where T : unmanaged
                => vstore(vinc(n,in a), ref z);                    
                    

        [MethodImpl(Inline)]
        public static void inc<T>(N256 n, in T a, ref T z)
            where T : unmanaged
                => vstore(vinc(n,in a), ref z);                    

        [MethodImpl(Inline)]
        public static void inc<T>(N128 n, int vcount, int step, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                inc(n, in skip(in a, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void inc<T>(N256 n, int vcount, int step, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                inc(n, in skip(in a, offset), ref seek(ref z, offset));
        }
        
        // ~ dec

        [MethodImpl(Inline)]
        public static Vector128<T> vdec<T>(N128 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vdec(vA);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vdec<T>(N256 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vdec(vA);
        }

        [MethodImpl(Inline)]
        public static void dec<T>(N128 n, in T a, ref T z)
            where T : unmanaged
                => vstore(vdec(n,in a), ref z);                    

        [MethodImpl(Inline)]
        public static void dec<T>(N128 n, int vcount, int step, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                dec(n, in skip(in a, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void dec<T>(N256 n, in T a, ref T z)
            where T : unmanaged
                => vstore(vdec(n,in a), ref z);                    
 
        [MethodImpl(Inline)]
        public static void dec<T>(N256 n, int vcount, int step, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                dec(n, in skip(in a, offset), ref seek(ref z, offset));
        }

        // ~ not

        [MethodImpl(Inline)]
        public static unsafe Vector128<T> vnot<T>(N128 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vnot(vA);
        }

        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vnot<T>(N256 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vnot(vA);
        }

        [MethodImpl(Inline)]
        public static unsafe void not<T>(N128 n, in T a, ref T z)
            where T : unmanaged
                => vstore(vnot(n, in a),ref z);

        [MethodImpl(Inline)]
        public static void not<T>(N128 n, int vcount, int step, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                not(n, in skip(in a, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static unsafe void not<T>(N256 n, in T a, ref T z)
            where T : unmanaged
                => vstore(vnot(n, in a),ref z);
        
        [MethodImpl(Inline)]
        public static void not<T>(N256 n, int vcount, int step, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                not(n, in skip(in a, offset), ref seek(ref z, offset));
        }

        // ~ and

        [MethodImpl(Inline)]
        public static void vand<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            vload(in b, out Vector128<T> vB);
            vstore(ginx.vand(vA,vB), ref z);
        }

        [MethodImpl(Inline)]
        public static void vand<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            vload(in a, out Vector256<T> vA);
            vload(in b, out Vector256<T> vB);
            vstore(ginx.vand(vA,vB), ref z);
        }

        [MethodImpl(Inline)]
        public static void and<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                vand(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void and<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            vand(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void and<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                vand(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ nand

        [MethodImpl(Inline)]
        public static Vector128<T> vnand<T>(N128 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(in rX, out Vector128<T> vA);
            vload(in rY, out Vector128<T> vB);
            return ginx.vnand(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vnand<T>(N256 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(in rX, out Vector256<T> vA);
            vload(in rY, out Vector256<T> vB);
            return ginx.vnand(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void nand<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vnand(n, in a, in b), ref z);


        [MethodImpl(Inline)]
        public static void nand<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                nand(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static unsafe void nand<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vnand(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void nand<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                nand(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ or

        [MethodImpl(Inline)]
        public static Vector128<T> vor<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            vload(in b, out Vector128<T> vB);
            return ginx.vor(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vor<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector256<T> vA);
            vload(in b, out Vector256<T> vB);
            return ginx.vor(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void or<T>(N128 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
                => vstore(vor(n, in rX, in rY), ref rDst);

        [MethodImpl(Inline)]
        public static void or<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                or(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void or<T>(N256 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
                => vstore(vor(n, in rX, in rY), ref rDst);

        [MethodImpl(Inline)]
        public static void or<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                or(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ nor

        [MethodImpl(Inline)]
        public static Vector128<T> vnor<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            vload(in b, out Vector128<T> vB);
            return ginx.vnor(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vnor<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector256<T> vA);
            vload(in b, out Vector256<T> vB);
            return ginx.vnor(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void nor<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vnor(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void nor<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                nor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void nor<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => ginx.vstore(vnor(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void nor<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                nor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ xor
        
        [MethodImpl(Inline)]
        public static Vector128<T> vxor<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            vload(in b, out Vector128<T> vB);
            return ginx.vxor(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vxor<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector256<T> vA);
            vload(in b, out Vector256<T> vB);
            return ginx.vxor(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void xor<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vxor(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void xor<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                xor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static unsafe void xor<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vxor(n, in a, in b), ref z);
 
        [MethodImpl(Inline)]
        public static void xor<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                xor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ xnor

        [MethodImpl(Inline)]
        public static Vector128<T> vxnor<T>(N128 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(in rX, out Vector128<T> vA);
            vload(in rY, out Vector128<T> vB);
            return ginx.vxnor(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vxnor<T>(N256 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(in rX, out Vector256<T> vA);
            vload(in rY, out Vector256<T> vB);
            return ginx.vxnor(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void xnor<T>(N128 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
                => vstore(vxnor(n, in rX, in rY), ref rDst);

        [MethodImpl(Inline)]
        public static unsafe void xnor<T>(N256 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
                => vstore(vxnor(n, in rX, in rY), ref rDst);

        [MethodImpl(Inline)]
        public static void xnor<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                xnor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void xnor<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                xnor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ imply

        [MethodImpl(Inline)]
        public static void imply<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                ginx.vimply(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void imply<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vimply(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void imply<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                ginx.vimply(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ notimply

        [MethodImpl(Inline)]
        public static Vector128<T> vnotimply<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            vload(in b, out Vector128<T> vB);
            return ginx.vnotimply(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vnotimply<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector256<T> vA);
            vload(in b, out Vector256<T> vB);
            return ginx.vnotimply(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void notimply<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vnotimply(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void notimply<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vnotimply(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void notimply<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                notimply(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void notimply<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                notimply(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ cimply

        [MethodImpl(Inline)]
        public static Vector128<T> vcimply<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            vload(in b, out Vector128<T> vB);
            return ginx.vcimply(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vcimply<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector256<T> vA);
            vload(in b, out Vector256<T> vB);
            return ginx.vcimply(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void cimply<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vcimply(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static unsafe void cimply<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vcimply(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void cimply<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                cimply(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void cimply<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                cimply(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ cnotimply

        [MethodImpl(Inline)]
        public static void cnotimply<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                ginx.vcnotimply(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void cnotimply<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vcnotimply(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void cnotimply<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                ginx.vcnotimply(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ select

        [MethodImpl(Inline)]
        public static unsafe Vector128<T> vselect<T>(N128 n, in T a, in T b, in T c)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            vload(b, out Vector128<T> vB);
            vload(c, out Vector128<T> vC);
            return ginx.vselect(vA,vB,vC);
        }

        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vselect<T>(N256 n, in T a, in T b, in T c)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            vload(b, out Vector256<T> vB);
            vload(c, out Vector256<T> vC);
            return ginx.vselect(vA,vB,vC);
        }

        [MethodImpl(Inline)]
        public static unsafe void select<T>(N128 n, in T a, in T b, in T c, ref T z)
            where T : unmanaged
                => vstore(vselect(n, in a, in b, in c), ref z);

        [MethodImpl(Inline)]
        public static unsafe void select<T>(N256 n, in T a, in T b, in T c, ref T z)
            where T : unmanaged
                => vstore(vselect(n, in a, in b, in c), ref z);

        [MethodImpl(Inline)]
        public static void select<T>(N128 n, int vcount, int step, in T a, in T b, in T c, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                select(n, in skip(in a, offset), in skip(in b, offset), in skip(in c, offset), ref seek(ref z, offset));
        }


        [MethodImpl(Inline)]
        public static void select<T>(N256 n, int vcount, int step, in T a, in T b, in T c, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                select(n, in skip(in a, offset), in skip(in b, offset), in skip(in c, offset), ref seek(ref z, offset));
        }

        // ~ sll

        [MethodImpl(Inline)]
        public static void sll<T>(N128 n, int vcount, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                ginx.vsll(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void sll<T>(N256 n, in T a, byte count, ref T z)
            where T : unmanaged
        {
            ginx.vsll(n, in a, count, ref z);
        }

        [MethodImpl(Inline)]
        public static void sll<T>(N256 n, int vcount, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                ginx.vsll(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        // ~ srl


        [MethodImpl(Inline)]
        public static unsafe Vector128<T> vsrl<T>(N128 n, in T a, byte offset)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vsrl(vA,offset);
        }

        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vsrl<T>(N256 n, in T a, byte offset)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vsrl(vA,offset);
        }

        [MethodImpl(Inline)]
        public static void srl<T>(N128 n, in T a, byte offset, ref T z)
            where T : unmanaged
                => vstore(vsrl(n, in a, offset), ref z);

        [MethodImpl(Inline)]
        public static void srl<T>(N256 n, in T a, byte offset, ref T z)
            where T : unmanaged
                => vstore(vsrl(n,in a, offset), ref z); 

        [MethodImpl(Inline)]
        public static void srl<T>(N128 n, int vcount, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                srl(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void srl<T>(N256 n, int vcount, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                srl(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        // ~ rotl

        [MethodImpl(Inline)]
        public static void rotl<T>(N128 n, int vcount, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                ginx.vrotl(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void rotl<T>(N256 n, in T a, byte count, ref T z)
            where T : unmanaged
        {
            ginx.vrotl(n, in a, count, ref z);
        }

        [MethodImpl(Inline)]
        public static void rotl<T>(N256 n, int vcount, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                ginx.vrotl(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        // ~ rotr

        [MethodImpl(Inline)]
        public static Vector128<T> vrotr<T>(N128 n, in T a, byte offset)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vrotr(vA,offset);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vrotr<T>(N256 n, in T a, byte offset)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vrotr(vA,offset);
        }

        [MethodImpl(Inline)]
        public static void rotr<T>(N128 n, in T a, byte offset, ref T z)
            where T : unmanaged
                => vstore(vrotr(n, in a, offset), ref z);

        [MethodImpl(Inline)]
        public static void rotr<T>(N256 n, in T a, byte offset, ref T z)
            where T : unmanaged
                => vstore(vrotr(n,in a, offset), ref z);

        [MethodImpl(Inline)]
        public static void rotr<T>(N128 n, int vcount, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                rotr(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void rotr<T>(N256 n, int vcount, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                rotr(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        // ~ bsll

        [MethodImpl(Inline)]
        public static Vector128<T> bsll<T>(N128 n, in T a, byte count)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            return ginx.vbsll(vA, count);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vbsll<T>(N256 n, in T a, byte count)
            where T : unmanaged
        {                    
            vload(in a, out Vector256<T> vA);
            return ginx.vbsll(vA,count);
        }

        [MethodImpl(Inline)]
        public static void bsll<T>(N128 n, in T a, byte count, ref T z)
            where T : unmanaged
                => vstore(bsll(n, in a, count), ref z);

        [MethodImpl(Inline)]
        public static void bsll<T>(N256 n, in T a, byte count, ref T z)
            where T : unmanaged
                => vstore(vbsll(n, in a, count), ref z); 
 
        [MethodImpl(Inline)]
        public static void bsll<T>(N128 n, int vcount, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                bsll(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void bsll<T>(N256 n, int vcount, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                bsll(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        // ~ bsrl

        [MethodImpl(Inline)]
        public static Vector128<T> vbsrl<T>(N128 n, in T a, byte count)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            return ginx.vbsrl(vA, count);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vbsrl<T>(N256 n, in T a, byte count)
            where T : unmanaged
        {                    
            vload(in a, out Vector256<T> vA);
            return ginx.vbsrl(vA,count);
        }

        [MethodImpl(Inline)]
        public static void bsrl<T>(N128 n, in T a, byte count, ref T z)
            where T : unmanaged
                => vstore(vbsrl(n, in a, count), ref z);

        [MethodImpl(Inline)]
        public static void bsrl<T>(N256 n, in T a, byte count, ref T z)
            where T : unmanaged
                => vstore(vbsrl(n, in a, count), ref z);

        [MethodImpl(Inline)]
        public static void bsrl<T>(N128 n, int vcount, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                bsrl(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }


        [MethodImpl(Inline)]
        public static void bsrl<T>(N256 n, int vcount, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                bsrl(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        // ~ add

        [MethodImpl(Inline)]
        public static Vector128<T> add<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            vload(b, out Vector128<T> vB);
            return vadd(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void add<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                add(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void add<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
            => vstore(add(n,in a, in b), ref z);                                       

        [MethodImpl(Inline)]
        public static Vector256<T> add<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            vload(b, out Vector256<T> vB);
            return vadd(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void add<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(add(n,in a,in b), ref z);                    
 

        [MethodImpl(Inline)]
        public static void add<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                add(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ sub

        [MethodImpl(Inline)]
        public static Vector128<T> vsub<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            vload(b, out Vector128<T> vB);
            return ginx.vsub(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vsub<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            vload(b, out Vector256<T> vB);
            return ginx.vsub(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void sub<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
            => vstore(vsub(n,in a, in b), ref z);                                       

        [MethodImpl(Inline)]
        public static void sub<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                sub(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void sub<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vsub(n,in a,in b), ref z);                    

        [MethodImpl(Inline)]
        public static void sub<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                sub(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ max

        [MethodImpl(Inline)]
        public static Vector128<T> max<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            vload(b, out Vector128<T> vB);
            return vmax(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> max<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            vload(b, out Vector256<T> vB);
            return vmax(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void max<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
            => vstore(max(n,in a, in b), ref z);                                       

        [MethodImpl(Inline)]
        public static void max<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                max(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void max<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(max(n,in a,in b), ref z);                    

        [MethodImpl(Inline)]
        public static void max<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                max(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ min

        [MethodImpl(Inline)]
        public static Vector128<T> vmin<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            vload(b, out Vector128<T> vB);
            return ginx.vmin(vA, vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vmin<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            vload(b, out Vector256<T> vB);
            return ginx.vmin(vA, vB);
        }

        [MethodImpl(Inline)]
        public static void min<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
            => vstore(vmin(n,in a, in b), ref z);                                       

        [MethodImpl(Inline)]
        public static void min<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                min(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void min<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
            => vstore(vmin(n,in a, in b), ref z);                                       

        [MethodImpl(Inline)]
        public static void min<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                min(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ eq

        [MethodImpl(Inline)]
        public static Vector128<T> veq<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            vload(b, out Vector128<T> vB);
            return ginx.veq(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> veq<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            vload(b, out Vector256<T> vB);
            return ginx.veq(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void eq<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(veq(n,in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void eq<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                eq(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void eq<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(veq(n,in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void eq<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                eq(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ gt

        [MethodImpl(Inline)]
        public static Vector128<T> vgt<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            vload(b, out Vector128<T> vB);
            return ginx.vgt(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vgt<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            vload(b, out Vector256<T> vB);
            return ginx.vgt(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void gt<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vgt(n,in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void gt<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vgt(n,in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void gt<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                gt(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void gt<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                gt(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ lt

        [MethodImpl(Inline)]
        public static Vector128<T> vlt<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            vload(b, out Vector128<T> vB);
            return ginx.vlt(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vlt<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            vload(b, out Vector256<T> vB);
            return ginx.vlt(vA,vB);
        }

        [MethodImpl(Inline)]
        static void lt<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => ginx.vstore(vlt(n,in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void lt<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                lt(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void lt<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vlt(n,in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void lt<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                lt(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ nonz

        [MethodImpl(Inline)]
        public static bit vnonz<T>(N128 n, in T rX)
            where T : unmanaged
        {                    
            vload(rX, out Vector128<T> vA);
            return ginx.vnonz(vA);
        }

        [MethodImpl(Inline)]
        public static bit vnonz<T>(N256 n, in T rX)
            where T : unmanaged
        {                    
            vload(rX, out Vector256<T> vA);
            return ginx.vnonz(vA);
        }

        [MethodImpl(Inline)]
        public static bool nonz<T>(N128 n, int vcount, int step, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vnonz(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bool nonz<T>(N256 n, int vcount, int step, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vnonz(n, in skip(in a, offset));
            return result;
        }

        // ~ testc

        [MethodImpl(Inline)]
        public static bit vtestc<T>(N128 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vtestc(vA);
        }

        [MethodImpl(Inline)]
        public static bit vtestc<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            vload(b, out Vector128<T> vB);
            return ginx.vtestc(vA,vB);
        }

        [MethodImpl(Inline)]
        public static bit vtestc<T>(N256 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vtestc(vA);
        }

        [MethodImpl(Inline)]
        public static bit vtestc<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            vload(b, out Vector256<T> vB);
            return ginx.vtestc(vA,vB);
        }

        [MethodImpl(Inline)]
        public static bool testc<T>(N128 n, int vcount, int step, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vtestc(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bool testc<T>(N128 n, int vcount, int step, in T a, in T b)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vtestc(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bool testc<T>(N256 n, int vcount, int step, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vtestc(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bool testc<T>(N256 n, int vcount, int step, in T a, in T b)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vtestc(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }


        // ~ testz

        [MethodImpl(Inline)]
        public static unsafe bit vtestz<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            vload(b, out Vector128<T> vB);
            return ginx.vtestz(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe bit vtestz<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            vload(b, out Vector256<T> vB);
            return ginx.vtestz(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe bit vtestz<T>(N128 n, in T a)
            where T : unmanaged
            => vtestz(n, a,a);

        [MethodImpl(Inline)]
        public static unsafe bit vtestz<T>(N256 n, in T a)
            where T : unmanaged
            => vtestz(n, a,a);

        [MethodImpl(Inline)]
        public static bool testz<T>(N128 n, int vcount, int step, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vtestz(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bool testz<T>(N128 n, int vcount, int step, in T a, in T b)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vtestz(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bool testz<T>(N256 n, int vcount, int step, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vtestz(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bool testz<T>(N256 n, int vcount, int step, in T a, in T b)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vtestz(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        // ~ testznc

        [MethodImpl(Inline)]
        public static bit vtestznc<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            vload(b, out Vector128<T> vB);
            return ginx.vtestznc(vA,vB);
        }

        [MethodImpl(Inline)]
        public static bit vtestznc<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            vload(b, out Vector256<T> vB);
            return ginx.vtestznc(vA,vB);
        }

        [MethodImpl(Inline)]
        public static bool testznc<T>(N128 n, int vcount, int step, in T a, in T b)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vtestznc(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bool testznc<T>(N256 n, int vcount, int step, in T a, in T b)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vtestznc(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }
    }

}

