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

        [MethodImpl(Inline)]
        public static void sll<T>(in ConstBlock128<T> xb, byte shift, in Block128<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var i=0; i< count; i++)
                vstore(ginx.vsll(xb.LoadVector(i), shift), ref zb.SeekBlock(i));                             
        } 

        [MethodImpl(Inline)]
        public static void sll<T>(in ConstBlock256<T> xb, byte shift, in Block256<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var i=0; i< count; i++)
                vstore(ginx.vsll(xb.LoadVector(i), shift), ref zb.SeekBlock(i));                             
        } 

    }

}