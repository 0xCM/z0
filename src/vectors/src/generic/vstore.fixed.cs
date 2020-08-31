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

    partial class Vectors
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector128<T> src, ref FixedCell128 dst)
            where T : unmanaged
                => V0.vsave(src, ref Fixed.head<FixedCell128,T>(ref dst));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector256<T> src, ref FixedCell256 dst)
            where T : unmanaged
                => V0.vsave(src, ref Fixed.head<FixedCell256,T>(ref dst));
    }
}