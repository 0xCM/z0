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
    }
}

