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
    using static vgeneric;
    using static gvec;    
    
    partial class vblock
    {     
        [MethodImpl(Inline)]
        public static Vector128<T> vselect<T>(N128 n, in T a, in T b, in T c)
            where T : unmanaged
        {                    
            vgeneric.vload(a, out Vector128<T> vA);
            vgeneric.vload(b, out Vector128<T> vB);
            vgeneric.vload(c, out Vector128<T> vC);
            return gvec.vselect(vA,vB,vC);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vselect<T>(N256 n, in T a, in T b, in T c)
            where T : unmanaged
        {                    
            vgeneric.vload(a, out Vector256<T> vA);
            vgeneric.vload(b, out Vector256<T> vB);
            vgeneric.vload(c, out Vector256<T> vC);
            return gvec.vselect(vA,vB,vC);
        }

        [MethodImpl(Inline)]
        public static void select<T>(N128 n, in T a, in T b, in T c, ref T z)
            where T : unmanaged
                => vstore(vselect(n, in a, in b, in c), ref z);

        [MethodImpl(Inline)]
        public static void select<T>(N256 n, in T a, in T b, in T c, ref T z)
            where T : unmanaged
                => vstore(vselect(n, in a, in b, in c), ref z);

        [MethodImpl(Inline)]
        public static void select<T>(N128 n, int vcount, int blocklen, in T a, in T b, in T c, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                select(n, in skip(in a, offset), in skip(in b, offset), in skip(in c, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline)]
        public static void select<T>(N256 n, int vcount, int blocklen, in T a, in T b, in T c, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                select(n, in skip(in a, offset), in skip(in b, offset), in skip(in c, offset), ref seek(ref z, offset));
        }
    }
}