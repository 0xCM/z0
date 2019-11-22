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
        public static Vector128<T> vnot<T>(N128 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vnot(vA);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vnot<T>(N256 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vnot(vA);
        }

        [MethodImpl(Inline)]
        public static void not<T>(N128 n, in T a, ref T z)
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
        public static void not<T>(N256 n, in T a, ref T z)
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
        public static Vector128<T> vand<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            vload(in b, out Vector128<T> vB);
            return ginx.vand(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vand<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector256<T> vA);
            vload(in b, out Vector256<T> vB);
            return ginx.vand(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void and<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vand(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void and<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                and(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void and<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vand(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void and<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                and(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ nand

        [MethodImpl(Inline)]
        public static Vector128<T> vnand<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            vload(in b, out Vector128<T> vB);
            return ginx.vnand(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vnand<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector256<T> vA);
            vload(in b, out Vector256<T> vB);
            return ginx.vnand(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void nand<T>(N128 n, in T a, in T b, ref T z)
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
        public static void nand<T>(N256 n, in T a, in T b, ref T z)
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
        public static void or<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vor(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void or<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                or(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void or<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vor(n, in a, in b), ref z);

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
        

        // ~ xnor

        [MethodImpl(Inline)]
        public static Vector128<T> vxnor<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            vload(in b, out Vector128<T> vB);
            return ginx.vxnor(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vxnor<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector256<T> vA);
            vload(in b, out Vector256<T> vB);
            return ginx.vxnor(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void xnor<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vxnor(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void xnor<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vxnor(n, in a, in b), ref z);

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

        // ~ impl

        [MethodImpl(Inline)]
        public static Vector128<T> vimpl<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            vload(in b, out Vector128<T> vB);
            return ginx.vimpl(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vimpl<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector256<T> vA);
            vload(in b, out Vector256<T> vB);
            return ginx.vimpl(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void impl<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vimpl(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void impl<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vimpl(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void impl<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                impl(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void impl<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                impl(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ nonimpl

        [MethodImpl(Inline)]
        public static Vector128<T> vnonimpl<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            vload(in b, out Vector128<T> vB);
            return ginx.vnonimpl(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vnotimply<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector256<T> vA);
            vload(in b, out Vector256<T> vB);
            return ginx.vnonimpl(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void nonimpl<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vnonimpl(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void nonimpl<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vnotimply(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void nonimpl<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                nonimpl(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void nonimpl<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                nonimpl(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ cimply

        [MethodImpl(Inline)]
        public static Vector128<T> vcimpl<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            vload(in b, out Vector128<T> vB);
            return ginx.vcimpl(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vcimpl<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector256<T> vA);
            vload(in b, out Vector256<T> vB);
            return ginx.vcimpl(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void cimpl<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vcimpl(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void cimpl<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vcimpl(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void cimpl<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                cimpl(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void cimpl<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                cimpl(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ cnonimpl

        [MethodImpl(Inline)]
        public static Vector128<T> vcnonimpl<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            vload(in b, out Vector128<T> vB);
            return ginx.vcnonimpl(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vcnonimpl<T>(N256 n, in T rX, in T b)
            where T : unmanaged
        {                    
            vload(in rX, out Vector256<T> vA);
            vload(in b, out Vector256<T> vB);
            return ginx.vcnonimpl(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void cnonimpl<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vcnonimpl(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void cnonimpl<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vcnonimpl(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void cnonimpl<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                cnonimpl(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void cnonimpl<T>(N256 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                cnonimpl(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ xornot

        [MethodImpl(Inline)]
        public static Vector128<T> vxornot<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            vload(in b, out Vector128<T> vB);
            return ginx.vxornot(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vxornot<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector256<T> vA);
            vload(in b, out Vector256<T> vB);
            return ginx.vxornot(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void xornot<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vxornot(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void xornot<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vxornot(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void xornot<T>(N128 n, int vcount, int step, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                xornot(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void xornot<T>(N256 n, int vcount, int step,  in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                xornot(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        // ~ select

        [MethodImpl(Inline)]
        public static Vector128<T> vselect<T>(N128 n, in T a, in T b, in T c)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            vload(b, out Vector128<T> vB);
            vload(c, out Vector128<T> vC);
            return ginx.vselect(vA,vB,vC);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vselect<T>(N256 n, in T a, in T b, in T c)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            vload(b, out Vector256<T> vB);
            vload(c, out Vector256<T> vC);
            return ginx.vselect(vA,vB,vC);
        }

        [MethodImpl(Inline)]
        public static void select<T>(N128 n, in T a, in T b, in T c, ref T z)
            where T : unmanaged
                => vstore(vselect(n, in a, in b, in c), ref z);

        [MethodImpl(Inline)]
        public static void select<T>(N256 n, in T a, in T b, in T c, ref T z)
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
        public static Vector128<T> vsll<T>(N128 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vsll(vA,shift);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vsll<T>(N256 n, in T b, byte shift)
            where T : unmanaged
        {                    
            vload(b, out Vector256<T> vA);
            return ginx.vsll(vA,shift);
        }

        [MethodImpl(Inline)]
        public static void sll<T>(N128 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vsll(n, in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void sll<T>(N256 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vsll(n,in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void sll<T>(N128 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                sll(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void sll<T>(N256 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                sll(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        // ~ sllx

        [MethodImpl(Inline)]
        public static Vector128<T> vsllx<T>(N128 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vsllx(vA,shift);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vsllx<T>(N256 n, in T b, byte shift)
            where T : unmanaged
        {                    
            vload(b, out Vector256<T> vA);
            return ginx.vsllx(vA,shift);
        }

        [MethodImpl(Inline)]
        public static void sllx<T>(N128 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vsllx(n, in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void sllx<T>(N256 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vsllx(n,in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void sllx<T>(N128 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                sllx(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void sllx<T>(N256 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                sllx(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        // ~ srl

        [MethodImpl(Inline)]
        public static Vector128<T> vsrl<T>(N128 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vsrl(vA,shift);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vsrl<T>(N256 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vsrl(vA,shift);
        }

        [MethodImpl(Inline)]
        public static void srl<T>(N128 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vsrl(n, in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void srl<T>(N256 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vsrl(n,in a, shift), ref z); 

        [MethodImpl(Inline)]
        public static void srl<T>(N128 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                srl(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void srl<T>(N256 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                srl(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        // ~ srlx

        [MethodImpl(Inline)]
        public static Vector128<T> vsrlx<T>(N128 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vsrlx(vA,shift);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vsrlx<T>(N256 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vsrlx(vA,shift);
        }

        [MethodImpl(Inline)]
        public static void srlx<T>(N128 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vsrlx(n, in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void srlx<T>(N256 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vsrlx(n,in a, shift), ref z); 

        [MethodImpl(Inline)]
        public static void srlx<T>(N128 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                srlx(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void srlx<T>(N256 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                srlx(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        // ~ rotl

        [MethodImpl(Inline)]
        public static Vector128<T> vrotl<T>(N128 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vrotl(vA,shift);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vrotl<T>(N256 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vrotl(vA,shift);
        }

        [MethodImpl(Inline)]
        public static void rotl<T>(N128 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vrotl(n, in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void rotl<T>(N256 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vrotl(n,in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void rotl<T>(N128 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                rotl(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void rotl<T>(N256 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                rotl(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        // ~ rotlx

        [MethodImpl(Inline)]
        public static Vector128<T> vrotlx<T>(N128 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vrotlx(vA,shift);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vrotlx<T>(N256 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vrotlx(vA,shift);
        }

        [MethodImpl(Inline)]
        public static void rotlx<T>(N128 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vrotlx(n, in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void rotlx<T>(N256 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vrotlx(n,in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void rotlx<T>(N128 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                rotlx(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void rotlx<T>(N256 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                rotlx(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        // ~ rotr

        [MethodImpl(Inline)]
        public static Vector128<T> vrotr<T>(N128 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vrotr(vA,shift);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vrotr<T>(N256 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vrotr(vA,shift);
        }

        [MethodImpl(Inline)]
        public static void rotr<T>(N128 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vrotr(n, in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void rotr<T>(N256 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vrotr(n,in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void rotr<T>(N128 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                rotr(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void rotr<T>(N256 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                rotr(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        // ~ rotrx

        [MethodImpl(Inline)]
        public static Vector128<T> vrotrx<T>(N128 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vrotrx(vA,shift);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vrotrx<T>(N256 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vrotrx(vA,shift);
        }

        [MethodImpl(Inline)]
        public static void rotrx<T>(N128 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vrotrx(n, in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void rotrx<T>(N256 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vrotrx(n,in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void rotrx<T>(N128 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                rotrx(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void rotrx<T>(N256 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                rotrx(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        // ~ xors

        [MethodImpl(Inline)]
        public static Vector128<T> vxors<T>(N128 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vxors(vA,shift);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vxors<T>(N256 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vxors(vA,shift);
        }

        [MethodImpl(Inline)]
        public static void xors<T>(N128 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vxors(n, in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void xors<T>(N256 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vxors(n,in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void xors<T>(N128 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                xors(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void xors<T>(N256 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                xors(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        // ~ xorsr

        [MethodImpl(Inline)]
        public static Vector128<T> vxorsr<T>(N128 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vxorsr(vA,shift);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vxorsr<T>(N256 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vxorsr(vA,shift);
        }

        [MethodImpl(Inline)]
        public static void xorsr<T>(N128 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vxorsr(n, in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void xorsr<T>(N256 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vxorsr(n,in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void xorsr<T>(N128 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                xorsr(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void xorsr<T>(N256 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                xorsr(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        // ~ xorsl

        [MethodImpl(Inline)]
        public static Vector128<T> vxorsl<T>(N128 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vxorsl(vA,shift);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vxorsl<T>(N256 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vxorsl(vA,shift);
        }

        [MethodImpl(Inline)]
        public static void xorsl<T>(N128 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vxorsl(n, in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void xorsl<T>(N256 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vxorsl(n,in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void xorsl<T>(N128 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                xorsl(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void xorsl<T>(N256 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                xorsl(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        // ~ bsll

        [MethodImpl(Inline)]
        public static Vector128<T> bsll<T>(N128 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            return ginx.vbsll(vA, shift);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vbsll<T>(N256 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(in a, out Vector256<T> vA);
            return ginx.vbsll(vA,shift);
        }

        [MethodImpl(Inline)]
        public static void bsll<T>(N128 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(bsll(n, in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void bsll<T>(N256 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vbsll(n, in a, shift), ref z); 
 
        [MethodImpl(Inline)]
        public static void bsll<T>(N128 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                bsll(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void bsll<T>(N256 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                bsll(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        // ~ bsrl

        [MethodImpl(Inline)]
        public static Vector128<T> vbsrl<T>(N128 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            return ginx.vbsrl(vA, shift);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vbsrl<T>(N256 n, in T a, byte shift)
            where T : unmanaged
        {                    
            vload(in a, out Vector256<T> vA);
            return ginx.vbsrl(vA,shift);
        }

        [MethodImpl(Inline)]
        public static void bsrl<T>(N128 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vbsrl(n, in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void bsrl<T>(N256 n, in T a, byte shift, ref T z)
            where T : unmanaged
                => vstore(vbsrl(n, in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void bsrl<T>(N128 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                bsrl(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }


        [MethodImpl(Inline)]
        public static void bsrl<T>(N256 n, int vcount, int step, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                bsrl(n, in skip(in a, offset), shift, ref seek(ref z, offset));
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

        [MethodImpl(Inline)]
        public static void add<T>(in ConstBlock128<T> xb, in ConstBlock128<T> yb, in Block128<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vadd(xb.LoadVector(block), yb.LoadVector(block)), ref zb.BlockHead(block));
        } 

        [MethodImpl(Inline)]
        public static void add<T>(in ConstBlock256<T> xb, in ConstBlock256<T> yb, in Block256<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vadd(xb.LoadVector(block), yb.LoadVector(block)), ref zb.BlockHead(block));
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
        public static Vector128<T> vmax<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            vload(b, out Vector128<T> vB);
            return ginx.vmax(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vmax<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            vload(b, out Vector256<T> vB);
            return ginx.vmax(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void max<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
            => vstore(vmax(n,in a, in b), ref z);                                       

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
                => vstore(vmax(n,in a,in b), ref z);                    

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
        public static bit vnonz<T>(N128 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vnonz(vA);
        }

        [MethodImpl(Inline)]
        public static bit vnonz<T>(N256 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vnonz(vA);
        }

        [MethodImpl(Inline)]
        public static bit nonz<T>(N128 n, int vcount, int step, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vnonz(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit nonz<T>(N256 n, int vcount, int step, in T a)
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
        public static bit testc<T>(N128 n, int vcount, int step, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vtestc(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit testc<T>(N128 n, int vcount, int step, in T a, in T b)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vtestc(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit testc<T>(N256 n, int vcount, int step, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vtestc(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit testc<T>(N256 n, int vcount, int step, in T a, in T b)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vtestc(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        // ~ testz

        [MethodImpl(Inline)]
        public static bit vtestz<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            vload(b, out Vector128<T> vB);
            return ginx.vtestz(vA,vB);
        }

        [MethodImpl(Inline)]
        public static bit vtestz<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            vload(b, out Vector256<T> vB);
            return ginx.vtestz(vA,vB);
        }

        [MethodImpl(Inline)]
        public static bit testz<T>(N128 n, in T a)
            where T : unmanaged
                => vtestz(n, a,a);

        [MethodImpl(Inline)]
        public static bit testz<T>(N128 n, in T a, in T b)
            where T : unmanaged
                => vtestz(n, a, b);

        [MethodImpl(Inline)]
        public static bit testz<T>(N256 n, in T a)
            where T : unmanaged
            => vtestz(n, a,a);

        [MethodImpl(Inline)]
        public static bit testz<T>(N256 n, in T a, in T b)
            where T : unmanaged
            => vtestz(n, a, b);

        [MethodImpl(Inline)]
        public static bit testz<T>(N128 n, int vcount, int step, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= testz(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit testz<T>(N128 n, int vcount, int step, in T a, in T b)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vtestz(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit testz<T>(N256 n, int vcount, int step, in T a)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= testz(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit testz<T>(N256 n, int vcount, int step, in T a, in T b)
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
        public static bit testznc<T>(N128 n, int vcount, int step, in T a, in T b)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vtestznc(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit testznc<T>(N256 n, int vcount, int step, in T a, in T b)
            where T : unmanaged
        {
            var result = true;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vtestznc(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        // ~ perm8x32

        [MethodImpl(Inline)]
        public static Vector256<T> vperm8x32<T>(N256 n, in T a, in uint spec)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            vload(spec, out Vector256<uint> vB);
            return ginx.vperm8x32(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void perm8x32<T>(N256 n, in T a, in uint spec, ref T z)
            where T : unmanaged
                => vstore(vperm8x32(n,in a,in spec), ref z);                    

        [MethodImpl(Inline)]
        public static void perm8x32<T>(N256 n, int vcount, int step, in T a, in uint spec, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                perm8x32(n, in skip(in a, offset), in skip(in spec, offset), ref seek(ref z, offset));
        }

        // ~ blend32x8

        [MethodImpl(Inline)]
        public static Vector256<T> vblend32x8<T>(N256 n, in T a, in T b, in byte spec)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            vload(b, out Vector256<T> vB);
            vload(spec, out Vector256<byte> vSpec);
            return ginx.vblend32x8(vA,vB,vSpec);
        }

        [MethodImpl(Inline)]
        public static void blend32x8<T>(N256 n, in T a, in T b, in byte spec, ref T z)
            where T : unmanaged
                => vstore(vblend32x8(n,in a, in b, in spec), ref z);                    

        [MethodImpl(Inline)]
        public static void blend32x8<T>(N256 n, int vcount, int step, in T a,  in T b, in byte spec, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                blend32x8(n, in skip(in a, offset), in skip(in b, offset), in skip(in spec, offset), ref seek(ref z, offset));
        }

        // ~ swaphilo

        [MethodImpl(Inline)]
        public static Vector128<T> vswaphl<T>(N128 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return ginx.vswaphl(vA);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vswaphl<T>(N256 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            return ginx.vswaphl(vA);
        }

        [MethodImpl(Inline)]
        public static void swaphl<T>(N128 n, in T a, ref T z)
            where T : unmanaged
                => vstore(vswaphl(n,in a), ref z);                    

        [MethodImpl(Inline)]
        public static void swaphl<T>(N128 n, int vcount, int step, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                swaphl(n, in skip(in a, offset), ref seek(ref z, offset));
        }        

        [MethodImpl(Inline)]
        public static void swaphl<T>(N256 n, in T a, ref T z)
            where T : unmanaged
                => vstore(vswaphl(n,in a), ref z);                    

        [MethodImpl(Inline)]
        public static void swaphl<T>(N256 n, int vcount, int step, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                swaphl(n, in skip(in a, offset), ref seek(ref z, offset));
        }
    }
}

