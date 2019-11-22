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

        [MethodImpl(Inline)]
        public static void xnor<T>(in ConstBlock128<T> xb, in ConstBlock128<T> yb, in Block128<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vxnor(xb.LoadVector(block), yb.LoadVector(block)), ref zb.SeekBlock(block));
        } 

        [MethodImpl(Inline)]
        public static void xnor<T>(in ConstBlock256<T> xb, in ConstBlock256<T> yb, in Block256<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vxnor(xb.LoadVector(block), yb.LoadVector(block)), ref zb.SeekBlock(block));
        } 
    }

}