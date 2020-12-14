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
    using static z;

    partial class LogicSquare
    {
        [MethodImpl(Inline), Or, Closures(Closure)]
        public static Vector128<T> vor<T>(W128 w, in T a, in T b)
            where T : unmanaged
        {
            vload(in a, out Vector128<T> vA);
            vload(in b, out Vector128<T> vB);
            return gvec.vor(vA,vB);
        }

        [MethodImpl(Inline), Or, Closures(Closure)]
        public static Vector256<T> vor<T>(W256 w, in T a, in T b)
            where T : unmanaged
        {
            vload(in a, out Vector256<T> vA);
            vload(in b, out Vector256<T> vB);
            return gvec.vor(vA,vB);
        }
    }
}