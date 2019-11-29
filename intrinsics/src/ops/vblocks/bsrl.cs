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
        public static Vector128<T> vbsrl<T>(N128 n, in T a, int shift)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            return ginx.vbsrl(vA, shift);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vbsrl<T>(N256 n, in T a, int shift)
            where T : unmanaged
        {                    
            vload(in a, out Vector256<T> vA);
            return ginx.vbsrl(vA,shift);
        }

        [MethodImpl(Inline)]
        public static void bsrl<T>(N128 n, in T a, int shift, ref T z)
            where T : unmanaged
                => vstore(vbsrl(n, in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void bsrl<T>(N256 n, in T a, int shift, ref T z)
            where T : unmanaged
                => vstore(vbsrl(n, in a, shift), ref z);

        [MethodImpl(Inline)]
        public static void bsrl<T>(N128 n, int vcount, int blocklen, in T a, int shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                bsrl(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void bsrl<T>(N256 n, int vcount, int blocklen, in T a, int shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                bsrl(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void bsrl<T>(in ConstBlock128<T> xb, int shift, in Block128<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vbsrl(xb.LoadVector(block), shift), ref zb.BlockSeek(block));
        } 

        [MethodImpl(Inline)]
        public static void bsrl<T>(in ConstBlock256<T> xb, int shift, in Block256<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vbsrl(xb.LoadVector(block), shift), ref zb.BlockSeek(block));
        } 

    }

}