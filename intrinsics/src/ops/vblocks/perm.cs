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
        public static void perm8x32<T>(N256 n, int vcount, int blocklen, in T a, in uint spec, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                perm8x32(n, in skip(in a, offset), in skip(in spec, offset), ref seek(ref z, offset));
        }


        [MethodImpl(Inline)]
        public static void perm8x32<T>(in ConstBlock256<T> xb, ConstBlock256<uint> yb, in Block256<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var i=0; i< count; i++)
                vstore(ginx.vperm8x32(xb.LoadVector(i), yb.LoadVector(i)), ref zb.BlockSeek(i));                             
        } 

        [MethodImpl(Inline)]
        public static void perm2x128<T>(in ConstBlock256<T> xb, ConstBlock256<T> yb, Perm2x4 spec, in Block256<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var i=0; i< count; i++)
                vstore(ginx.vperm2x128(xb.LoadVector(i), yb.LoadVector(i), spec), ref zb.BlockSeek(i));                             
        } 

    }
}

