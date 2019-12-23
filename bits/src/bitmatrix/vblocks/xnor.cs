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
    using static CpuVector;
    
    partial class vblock
    {     
        [MethodImpl(Inline)]
        public static Vector128<T> vxnor<T>(N128 w, in T a, in T b)
            where T : unmanaged
                => ginx.vxnor(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline)]
        public static Vector256<T> vxnor<T>(N256 w, in T a, in T b)
            where T : unmanaged
                => ginx.vxnor(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline)]
        public static void xnor<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vxnor(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void xnor<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vxnor(n, in a, in b), ref z);

        [MethodImpl(Inline)]
        public static void xnor<T>(N128 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                xnor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void xnor<T>(N256 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                xnor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }
    }
}