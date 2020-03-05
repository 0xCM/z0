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
    
    partial class vblock
    {     
        [MethodImpl(Inline)]
        public static Vector128<T> vnot<T>(N128 n, in T a)
            where T : unmanaged
        {                    
            gvec.vload(a, out Vector128<T> vA);
            return ginx.vnot(vA);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vnot<T>(N256 n, in T a)
            where T : unmanaged
        {                    
            gvec.vload(a, out Vector256<T> vA);
            return ginx.vnot(vA);
        }

        [MethodImpl(Inline)]
        public static void not<T>(N128 n, in T a, ref T z)
            where T : unmanaged
                => vstore(vnot(n, in a),ref z);

        [MethodImpl(Inline)]
        public static void not<T>(N128 n, int vcount, int blocklen, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                not(n, in skip(in a, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void not<T>(N256 n, in T a, ref T z)
            where T : unmanaged
                => vstore(vnot(n, in a),ref z);
        
        [MethodImpl(Inline)]
        public static void not<T>(N256 n, int vcount, int blocklen, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                not(n, in skip(in a, offset), ref seek(ref z, offset));
        }
    }
}