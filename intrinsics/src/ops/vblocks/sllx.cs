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
        public static void sllx<T>(N128 n, int vcount, int blocklen, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                sllx(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void sllx<T>(N256 n, int vcount, int blocklen, in T a, byte shift, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                sllx(n, in skip(in a, offset), shift, ref seek(ref z, offset));
        }
    }
}