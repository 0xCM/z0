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
        public static Vector128<T> negate<T>(N128 n, in T pX)
            where T : unmanaged
        {                    
            vload(pX, out Vector128<T> vA);
            return ginx.vnegate(vA);
        }

        [MethodImpl(Inline)]
        public static void negate<T>(N128 n, in T pX, ref T z)
            where T : unmanaged
                => vstore(negate(n,in pX), ref z);                    

        [MethodImpl(Inline)]
        public static void negate<T>(N128 n, int parts, int step, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                negate(n, in skip(in a, offset), ref seek(ref z, offset));
        }
        
        [MethodImpl(Inline)]
        public static Vector256<T> negate<T>(N256 n, in T pX)
            where T : unmanaged
        {                    
            vload(pX, out Vector256<T> vA);
            return ginx.vnegate(vA);
        }

        [MethodImpl(Inline)]
        public static void negate<T>(N256 n, in T pX, ref T z)
            where T : unmanaged
                => vstore(negate(n,in pX), ref z);                    

        [MethodImpl(Inline)]
        public static void negate<T>(N256 n, int parts, int step, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                negate(n, in skip(in a, offset), ref seek(ref z, offset));
        }

        // ~ inc

        [MethodImpl(Inline)]
        public static unsafe Vector128<T> inc<T>(N128 n, in T pX)
            where T : unmanaged
        {                    
            vload(pX, out Vector128<T> vA);
            return ginx.vinc(vA);
        }

        [MethodImpl(Inline)]
        public static unsafe void inc<T>(N128 n, in T a, ref T z)
            where T : unmanaged
                => vstore(inc(n,in a), ref z);                    
                    
        [MethodImpl(Inline)]
        public static unsafe Vector256<T> inc<T>(N256 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vinc(vA);
        }

        [MethodImpl(Inline)]
        public static unsafe void inc<T>(N256 n, in T a, ref T z)
            where T : unmanaged
                => vstore(inc(n,in a), ref z);                    

        [MethodImpl(Inline)]
        public static void inc<T>(N128 n, int parts, int step, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                inc(n, in skip(in a, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void inc<T>(N256 n, int parts, int step, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                inc(n, in skip(in a, offset), ref seek(ref z, offset));
        }
        
        // ~ dec

        [MethodImpl(Inline)]
        public static Vector128<T> dec<T>(N128 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vdec(vA);
        }

        [MethodImpl(Inline)]
        public static void dec<T>(N128 n, in T a, ref T z)
            where T : unmanaged
                => vstore(dec(n,in a), ref z);                    

        [MethodImpl(Inline)]
        public static void dec<T>(N128 n, int parts, int step, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                dec(n, in skip(in a, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static Vector256<T> dec<T>(N256 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vdec(vA);
        }

        [MethodImpl(Inline)]
        public static void dec<T>(N256 n, in T a, ref T z)
            where T : unmanaged
                => vstore(dec(n,in a), ref z);                    
 
        [MethodImpl(Inline)]
        public static void dec<T>(N256 n, int parts, int step, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                dec(n, in skip(in a, offset), ref seek(ref z, offset));
        }

        // ~ not

        [MethodImpl(Inline)]
        public static void not<T>(N128 n, int parts, int step, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                vnot(n, in skip(in a, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void not<T>(N256 n, in T a, ref T z)
            where T : unmanaged
        {
            ginx.vnot(n, in a, ref z);
        }

        [MethodImpl(Inline)]
        public static void not<T>(N256 n, int parts, int step, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vnot(n, in skip(in a, offset), ref seek(ref z, offset));
        }

        // ~ and

        [MethodImpl(Inline)]
        public static void and<T>(N128 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                vand(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void and<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vand(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void and<T>(N256 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vand(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ nand

        [MethodImpl(Inline)]
        public static void nand<T>(N128 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vnand(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void nand<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vnand(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void nand<T>(N256 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vnand(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ or

        [MethodImpl(Inline)]
        public static void or<T>(N128 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void or<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vor(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void or<T>(N256 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ nor

        [MethodImpl(Inline)]
        public static Vector128<T> nor<T>(N128 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(in rX, out Vector128<T> vA);
            vload(in rY, out Vector128<T> vB);
            return ginx.vnor(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void nor<T>(N128 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
                => vstore(nor(n, in rX, in rY), ref rDst);

        [MethodImpl(Inline)]
        public static void nor<T>(N128 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                nor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static Vector256<T> nor<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector256<T> vA);
            vload(in b, out Vector256<T> vB);
            return ginx.vnor(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void nor<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => ginx.vstore(nor(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void nor<T>(N256 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                nor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ xor

        [MethodImpl(Inline)]
        public static void xor<T>(N128 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vxor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void xor<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vxor(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void xor<T>(N256 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vxor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ xnor

        [MethodImpl(Inline)]
        public static void xnor<T>(N128 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vxor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void xnor<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vxnor(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void xnor<T>(N256 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vxnor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ imply

        [MethodImpl(Inline)]
        public static void imply<T>(N128 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vimply(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }


        [MethodImpl(Inline)]
        public static void imply<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vimply(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void imply<T>(N256 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vimply(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ notimply

        [MethodImpl(Inline)]
        public static void notimply<T>(N128 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vnotimply(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void notimply<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vnotimply(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void notimply<T>(N256 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vnotimply(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ cimply

        [MethodImpl(Inline)]
        public static void cimply<T>(N128 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vcimply(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void cimply<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vcimply(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void cimply<T>(N256 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vcimply(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ cnotimply

        [MethodImpl(Inline)]
        public static void cnotimply<T>(N128 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vcnotimply(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void cnotimply<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
        {
            ginx.vcnotimply(n, in a, in b, ref z);
        }

        [MethodImpl(Inline)]
        public static void cnotimply<T>(N256 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vcnotimply(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ select

        [MethodImpl(Inline)]
        public static void select<T>(N128 n, int parts, int step, in T a, in T b, in T c, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vselect(n, in skip(in a, offset), in skip(in b, offset), in skip(in c, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void select<T>(N256 n, in T a, in T b, in T c, ref T z)
            where T : unmanaged
        {
            ginx.vselect(n, in a, in b, in c, ref z);
        }

        [MethodImpl(Inline)]
        public static void select<T>(N256 n, int parts, int step, in T a, in T b, in T c, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vselect(n, in skip(in a, offset), in skip(in b, offset), in skip(in c, offset), ref seek(ref z, offset));
        }

        // ~ sll

        [MethodImpl(Inline)]
        public static void sll<T>(N128 n, int parts, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vsll(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }


        [MethodImpl(Inline)]
        public static void sll<T>(N256 n, in T a, byte count, ref T z)
            where T : unmanaged
        {
            ginx.vsll(n, in a, count, ref z);
        }

        [MethodImpl(Inline)]
        public static void sll<T>(N256 n, int parts, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vsll(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        // ~ srl

        [MethodImpl(Inline)]
        public static void srl<T>(N128 n, int parts, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vsrl(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void srl<T>(N256 n, in T a, byte count, ref T z)
            where T : unmanaged
        {
            ginx.vsrl(n, in a, count, ref z);
        }

        [MethodImpl(Inline)]
        public static void srl<T>(N256 n, int parts, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vsrl(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        // ~ rotl

        [MethodImpl(Inline)]
        public static void rotl<T>(N128 n, int parts, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vrotl(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }


        [MethodImpl(Inline)]
        public static void rotl<T>(N256 n, in T a, byte count, ref T z)
            where T : unmanaged
        {
            ginx.vrotl(n, in a, count, ref z);
        }

        [MethodImpl(Inline)]
        public static void rotl<T>(N256 n, int parts, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vrotl(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        // ~ rotr

        [MethodImpl(Inline)]
        public static void rotr<T>(N128 n, int parts, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vrotr(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void rotr<T>(N256 n, in T a, byte count, ref T z)
            where T : unmanaged
        {
            ginx.vrotr(n, in a, count, ref z);
        }

        [MethodImpl(Inline)]
        public static void rotr<T>(N256 n, int parts, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vrotr(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        // ~ bsll

        [MethodImpl(Inline)]
        public static Vector128<T> bsll<T>(N128 n, in T rX, byte count)
            where T : unmanaged
        {                    
            ginx.vload(in rX, out Vector128<T> vA);
            return ginx.vbsll(vA, count);
        }

        [MethodImpl(Inline)]
        public static unsafe void bsll<T>(N128 n, in T rX, byte count, ref T rDst)
            where T : unmanaged
                => ginx.vstore(bsll(n, in rX, count), ref rDst);

 
        [MethodImpl(Inline)]
        public static void bsll<T>(N128 n, int parts, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                bsll(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void bsll<T>(N256 n, in T a, byte count, ref T z)
            where T : unmanaged
        {
            ginx.vbsll(n, in a, count, ref z);
        }

        [MethodImpl(Inline)]
        public static void bsll<T>(N256 n, int parts, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vbsll(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        // ~ bsrl

        [MethodImpl(Inline)]
        public static void bsrl<T>(N128 n, int parts, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                ginx.vbsrl(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void bsrl<T>(N256 n, in T a, byte count, ref T z)
            where T : unmanaged
        {
            vbsrl(n, in a, count, ref z);
        }

        [MethodImpl(Inline)]
        public static void bsrl<T>(N256 n, int parts, int step, in T a, byte count, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                vbsrl(n, in skip(in a, offset), count, ref seek(ref z, offset));
        }

        // ~ add

        [MethodImpl(Inline)]
        public static unsafe Vector128<T> add<T>(N128 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(rX, out Vector128<T> vA);
            vload(rY, out Vector128<T> vB);
            return vadd(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void add<T>(N128 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                add(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static unsafe void add<T>(N128 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
            => vstore(add(n,in rX, in rY), ref rDst);                                       

        [MethodImpl(Inline)]
        public static unsafe Vector256<T> add<T>(N256 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(rX, out Vector256<T> vA);
            vload(rY, out Vector256<T> vB);
            return vadd(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void add<T>(N256 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
                => vstore(add(n,in rX,in rY), ref rDst);                    
 

        [MethodImpl(Inline)]
        public static void add<T>(N256 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                add(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ sub

        [MethodImpl(Inline)]
        public static unsafe Vector128<T> sub<T>(N128 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(rX, out Vector128<T> vA);
            vload(rY, out Vector128<T> vB);
            return ginx.vsub(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void sub<T>(N128 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
            => vstore(sub(n,in rX, in rY), ref rDst);                                       

        [MethodImpl(Inline)]
        public static void sub<T>(N128 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                sub(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static unsafe Vector256<T> sub<T>(N256 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(rX, out Vector256<T> vA);
            vload(rY, out Vector256<T> vB);
            return ginx.vsub(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void sub<T>(N256 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
                => vstore(sub(n,in rX,in rY), ref rDst);                    

        [MethodImpl(Inline)]
        public static void sub<T>(N256 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                sub(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ max

        [MethodImpl(Inline)]
        public static Vector128<T> max<T>(N128 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(rX, out Vector128<T> vA);
            vload(rY, out Vector128<T> vB);
            return vmax(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void max<T>(N128 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
            => vstore(max(n,in rX, in rY), ref rDst);                                       

        [MethodImpl(Inline)]
        public static void max<T>(N128 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                max(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static Vector256<T> max<T>(N256 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(rX, out Vector256<T> vA);
            vload(rY, out Vector256<T> vB);
            return vmax(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void max<T>(N256 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
                => vstore(max(n,in rX,in rY), ref rDst);                    

        [MethodImpl(Inline)]
        public static void max<T>(N256 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                max(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ min

        [MethodImpl(Inline)]
        public static Vector128<T> min<T>(N128 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(rX, out Vector128<T> vA);
            vload(rY, out Vector128<T> vB);
            return vmin(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void min<T>(N128 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
            => vstore(min(n,in rX, in rY), ref rDst);                                       

        [MethodImpl(Inline)]
        public static void min<T>(N128 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                min(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static Vector256<T> min<T>(N256 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(rX, out Vector256<T> vA);
            vload(rY, out Vector256<T> vB);
            return vmin(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void min<T>(N256 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
            => vstore(min(n,in rX, in rY), ref rDst);                                       

        [MethodImpl(Inline)]
        public static void min<T>(N256 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                min(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ eq

        [MethodImpl(Inline)]
        public static unsafe Vector128<T> eq<T>(N128 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(rX, out Vector128<T> vA);
            vload(rY, out Vector128<T> vB);
            return ginx.veq(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void eq<T>(N128 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
                => vstore(eq(n,in rX, in rY), ref rDst);

        [MethodImpl(Inline)]
        public static void eq<T>(N128 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                eq(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static unsafe Vector256<T> eq<T>(N256 n, in T pA, in T pB)
            where T : unmanaged
        {                    
            vload(pA, out Vector256<T> vA);
            vload(pB, out Vector256<T> vB);
            return ginx.veq(vA,vB);
        }

        [MethodImpl(Inline)]
        public static unsafe void eq<T>(N256 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
                => vstore(eq(n,in rX, in rY), ref rDst);

        [MethodImpl(Inline)]
        public static void eq<T>(N256 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                eq(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ gt

        [MethodImpl(Inline)]
        public static void gt<T>(N128 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                vgt(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void gt<T>(N256 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                vgt(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ lt

        [MethodImpl(Inline)]
        static Vector128<T> lt<T>(N128 n, in T rX, in T rY)
            where T : unmanaged
        {                    
            vload(rX, out Vector128<T> vA);
            vload(rY, out Vector128<T> vB);
            return ginx.vlt(vA,vB);
        }

        [MethodImpl(Inline)]
        static void lt<T>(N128 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
                => ginx.vstore(lt(n,in rX, in rY), ref rDst);

        [MethodImpl(Inline)]
        public static void lt<T>(N128 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                lt(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        static Vector256<T> lt<T>(N256 n, in T pA, in T pB)
            where T : unmanaged
        {                    
            vload(pA, out Vector256<T> vA);
            vload(pB, out Vector256<T> vB);
            return ginx.vlt(vA,vB);
        }

        [MethodImpl(Inline)]
        static void lt<T>(N256 n, in T rX, in T rY, ref T rDst)
            where T : unmanaged
                => vstore(lt(n,in rX, in rY), ref rDst);

        [MethodImpl(Inline)]
        public static void lt<T>(N256 n, int parts, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                lt(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ nonz

        [MethodImpl(Inline)]
        public static bool nonz<T>(N128 n, int parts, int step, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                result &= vnonz(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bool nonz<T>(N256 n, int parts, int step, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                result &= vnonz(n, in skip(in a, offset));
            return result;
        }

        // ~ testc

        [MethodImpl(Inline)]
        public static bit testc<T>(N128 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vtestc(vA);
        }

        [MethodImpl(Inline)]
        public static bit testc<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            vload(b, out Vector128<T> vB);
            return ginx.vtestc(vA,vB);
        }

        [MethodImpl(Inline)]
        public static bool testc<T>(N128 n, int parts, int step, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                result &= testc(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bool testc<T>(N128 n, int parts, int step, in T a, in T b)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                result &= testc(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit testc<T>(N256 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vtestc(vA);
        }

        [MethodImpl(Inline)]
        public static bit testc<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            vload(b, out Vector256<T> vB);
            return ginx.vtestc(vA,vB);
        }

        [MethodImpl(Inline)]
        public static bool testc<T>(N256 n, int parts, int step, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                result &= testc(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bool testc<T>(N256 n, int parts, int step, in T a, in T b)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                result &= testc(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        // ~ testz

        [MethodImpl(Inline)]
        public static bool testz<T>(N128 n, int parts, int step, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                result &= vtestz(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bool testz<T>(N128 n, int parts, int step, in T a, in T b)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                result &= vtestz(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bool testz<T>(N256 n, int parts, int step, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                result &= vtestz(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bool testz<T>(N256 n, int parts, int step, in T a, in T b)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                result &= vtestz(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        // ~ testznc

        [MethodImpl(Inline)]
        public static bool testznc<T>(N128 n, int parts, int step, in T a, in T b)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                result &= vtestznc(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bool testznc<T>(N256 n, int parts, int step, in T a, in T b)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < parts; i++, offset += step)
                result &= vtestznc(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }
    }

}



