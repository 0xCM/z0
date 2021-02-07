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
        [MethodImpl(Inline), Nand, Closures(Closure)]
        public static Vector128<T> vnand<T>(W128 w, in T a, in T b)
            where T : unmanaged
                => gcpu.vnand(gcpu.vload(w, a), gcpu.vload(w, b));

        [MethodImpl(Inline), Nand, Closures(Closure)]
        public static Vector256<T> vnand<T>(N256 w, in T a, in T b)
            where T : unmanaged
                => gcpu.vnand(gcpu.vload(w, a), gcpu.vload(w, b));

        [MethodImpl(Inline), Nand, Closures(Closure)]
        public static void nand<T>(W128 w, in T a, in T b, ref T z)
            where T : unmanaged
                => gcpu.vstore(vnand(w, a, b), ref z);

        [MethodImpl(Inline), Nand, Closures(Closure)]
        public static void nand<T>(W128 w, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                nand(w, in skip(in a, offset), in skip(in b, offset), ref seek(z, offset));
        }

        [MethodImpl(Inline), Nand, Closures(Closure)]
        public static void nand<T>(W256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => gcpu.vstore(vnand(n, in a, in b), ref z);

        [MethodImpl(Inline), Nand, Closures(Closure)]
        public static void nand<T>(W256 w, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i<vcount; i++, offset += blocklen)
                nand(w, in skip(in a, offset), in skip(in b, offset), ref seek(z, offset));
        }
    }
}