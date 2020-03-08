//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static Root;
    using static gvec;
    using static ginx;
    
    partial class vblock
    {     
        [MethodImpl(Inline)]
        public static Vector128<T> vor<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            gvec.vload(in a, out Vector128<T> vA);
            gvec.vload(in b, out Vector128<T> vB);
            return ginx.vor(vA,vB);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vor<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            gvec.vload(in a, out Vector256<T> vA);
            gvec.vload(in b, out Vector256<T> vB);
            return ginx.vor(vA,vB);
        }

        [MethodImpl(Inline)]
        public static void or<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vor(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void or<T>(N128 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                or(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void or<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vor(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void or<T>(N256 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                or(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }
    }
}