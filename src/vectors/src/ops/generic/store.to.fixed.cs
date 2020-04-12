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
    
    partial class Vectors
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector128<T> src, ref Fixed128 dst)
            where T : unmanaged
                => vstore(src, ref Fixed.head<Fixed128,T>(ref dst));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector256<T> src, ref Fixed256 dst)
            where T : unmanaged
                => vstore(src, ref Fixed.head<Fixed256,T>(ref dst));
    }
}