//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Root;
    using static V0;

    partial class LogicSquare
    {
        [MethodImpl(Inline), Nor, Closures(Closure)]
        public static Vector128<T> vnor<T>(W128 n, in T a, in T b)
            where T : unmanaged
        {
            vload(in a, out Vector128<T> vA);
            vload(in b, out Vector128<T> vB);
            return gvec.vnor(vA,vB);
        }

        [MethodImpl(Inline), Nor, Closures(Closure)]
        public static Vector256<T> vnor<T>(W256 n, in T a, in T b)
            where T : unmanaged
        {
            vload(in a, out Vector256<T> vA);
            vload(in b, out Vector256<T> vB);
            return gvec.vnor(vA,vB);
        }

        [MethodImpl(Inline), Nor, Closures(Closure)]
        public static void nor<T>(W128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vsave(vnor(n, in a, in b), ref z);

        [MethodImpl(Inline), Nor, Closures(Closure)]
        public static void nor<T>(W128 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                nor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline), Nor, Closures(Closure)]
        public static void nor<T>(W256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => Vectors.vstore(vnor(n, in a, in b), ref z);

        [MethodImpl(Inline), Nor, Closures(Closure)]
        public static void nor<T>(W256 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                nor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }
    }
}