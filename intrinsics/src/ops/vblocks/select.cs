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

        [MethodImpl(Inline)]
        public static void select<T>(in ConstBlock128<T> xb, in ConstBlock128<T> yb, in ConstBlock128<T> zb, in Block128<T> dst)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block=0; block< count; block++)
                vstore(ginx.vselect(xb.LoadVector(block), yb.LoadVector(block), zb.LoadVector(block)), ref dst.BlockSeek(block));                             
        } 

        [MethodImpl(Inline)]
        public static void select<T>(in ConstBlock256<T> xb, in ConstBlock256<T> yb, in ConstBlock256<T> zb, in Block256<T> dst)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block=0; block< count; block++)
                vstore(ginx.vselect(xb.LoadVector(block), yb.LoadVector(block), zb.LoadVector(block)), ref dst.BlockSeek(block));                             
        } 
    }

}