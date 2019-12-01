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
        public static void inc<T>(N128 n, int vcount, int blocklen, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                inc(n, in skip(in a, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void inc<T>(N256 n, int vcount, int blocklen, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                inc(n, in skip(in a, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void inc<T>(in ConstBlock128<T> xb, in Block128<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vinc(xb.LoadVector(block)), ref zb.BlockRef(block));
        } 

        [MethodImpl(Inline)]
        public static void inc<T>(in ConstBlock256<T> xb, in Block256<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vinc(xb.LoadVector(block)), ref zb.BlockRef(block));
        } 



    }

}