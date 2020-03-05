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
    
    using static ginx;
    using static Root;
    using static gvec;
    
    partial class vblock
    {     
        [MethodImpl(Inline)]
        public static Vector128<T> vand<T>(N128 w, in T a, in T b)
            where T : unmanaged
                => ginx.vand(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline)]
        public static Vector256<T> vand<T>(N256 w, in T a, in T b)
            where T : unmanaged
                => ginx.vand(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline)]
        public static void and<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vand(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void and<T>(N128 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                and(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void and<T>(N256 w, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vand(w, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void and<T>(N256 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                and(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }
    }
}