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

        [MethodImpl(Inline)]
        public static void blend32x8<T>(in ConstBlock256<T> xb, in ConstBlock256<T> yb, in ConstBlock256<byte> zb, in Block256<T> dst)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block=0; block< count; block++)
                vstore(ginx.vblend32x8(xb.LoadVector(block), yb.LoadVector(block), zb.LoadVector(block)), ref dst.BlockSeek(block));                             
        } 
    }
}