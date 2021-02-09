//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    partial class LogicSquare
    {
        [MethodImpl(Inline), Select, Closures(Closure)]
        public static Vector128<T> vselect<T>(W128 n, in T a, in T b, in T c)
            where T : unmanaged
        {
            gcpu.vload(a, out Vector128<T> vA);
            gcpu.vload(b, out Vector128<T> vB);
            gcpu.vload(c, out Vector128<T> vC);
            return gcpu.vselect(vA,vB,vC);
        }

        [MethodImpl(Inline), Select, Closures(Closure)]
        public static Vector256<T> vselect<T>(W256 n, in T a, in T b, in T c)
            where T : unmanaged
        {
            gcpu.vload(a, out Vector256<T> vA);
            gcpu.vload(b, out Vector256<T> vB);
            gcpu.vload(c, out Vector256<T> vC);
            return gcpu.vselect(vA,vB,vC);
        }

        [MethodImpl(Inline), Select, Closures(Closure)]
        public static void select<T>(W128 n, in T a, in T b, in T c, ref T dst)
            where T : unmanaged
                => gcpu.vstore(vselect(n, a, b, c), ref dst);

        [MethodImpl(Inline), Select, Closures(Closure)]
        public static void select<T>(W256 n, in T a, in T b, in T c, ref T dst)
            where T : unmanaged
                => gcpu.vstore(vselect(n, a, b, c), ref dst);

        [MethodImpl(Inline), Select, Closures(Closure)]
        public static void select<T>(W128 n, int vcount, int blocklen, in T a, in T b, in T c, ref T dst)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                select(n, skip(a, offset), skip(b, offset), skip(c, offset), ref seek(dst, offset));
        }

        [MethodImpl(Inline), Select, Closures(Closure)]
        public static void select<T>(W256 n, int vcount, int blocklen, in T a, in T b, in T c, ref T dst)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i<vcount; i++, offset += blocklen)
                select(n, in skip(in a, offset), in skip(in b, offset), in skip(in c, offset), ref seek(dst, offset));
        }
    }
}