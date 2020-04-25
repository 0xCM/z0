//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static Seed;
    using static Memories;
    using static Vectors;
        
    partial class LogicSquare
    {     
        [MethodImpl(Inline), Nand, Closures(UnsignedInts)]
        public static Vector128<T> vnand<T>(W128 w, in T a, in T b)
            where T : unmanaged
                => gvec.vnand(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), Nand, Closures(UnsignedInts)]
        public static Vector256<T> vnand<T>(N256 w, in T a, in T b)
            where T : unmanaged
                => gvec.vnand(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), Nand, Closures(UnsignedInts)]
        public static void nand<T>(W128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => Vectors.vstore(vnand(n, in a, in b), ref z);

        [MethodImpl(Inline), Nand, Closures(UnsignedInts)]
        public static void nand<T>(W128 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                nand(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline), Nand, Closures(UnsignedInts)]
        public static void nand<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => Vectors.vstore(vnand(n, in a, in b), ref z);

        [MethodImpl(Inline), Nand, Closures(UnsignedInts)]
        public static void nand<T>(N256 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                nand(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }
    }
}