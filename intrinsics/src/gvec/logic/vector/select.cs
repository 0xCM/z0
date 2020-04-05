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
    using static refs;
    using static Vectors;
    
    partial class LogicSquares
    {     
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Unsigned)]
        public static Vector128<T> vselect<T>(N128 n, in T a, in T b, in T c)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            vload(b, out Vector128<T> vB);
            vload(c, out Vector128<T> vC);
            return gvec.vselect(vA,vB,vC);
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Unsigned)]
        public static Vector256<T> vselect<T>(N256 n, in T a, in T b, in T c)
            where T : unmanaged
        {                    
            Vectors.vload(a, out Vector256<T> vA);
            Vectors.vload(b, out Vector256<T> vB);
            Vectors.vload(c, out Vector256<T> vC);
            return gvec.vselect(vA,vB,vC);
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Unsigned)]
        public static void select<T>(N128 n, in T a, in T b, in T c, ref T z)
            where T : unmanaged
                => Vectors.vstore(vselect(n, in a, in b, in c), ref z);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Unsigned)]
        public static void select<T>(N256 n, in T a, in T b, in T c, ref T z)
            where T : unmanaged
                => Vectors.vstore(vselect(n, in a, in b, in c), ref z);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Unsigned)]
        public static void select<T>(N128 n, int vcount, int blocklen, in T a, in T b, in T c, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                select(n, in skip(in a, offset), in skip(in b, offset), in skip(in c, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Unsigned)]
        public static void select<T>(N256 n, int vcount, int blocklen, in T a, in T b, in T c, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                select(n, in skip(in a, offset), in skip(in b, offset), in skip(in c, offset), ref seek(ref z, offset));
        }
    }
}