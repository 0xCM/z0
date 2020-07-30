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

    partial struct V0
    {
        [MethodImpl(Inline)]
        public static void vsave<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
                => z.vsave(src, ref dst);

        [MethodImpl(Inline)]
        public static void vsave<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
                => z.vsave(src, ref dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vsave<T>(Vector512<T> src, ref T dst, int offset = 0)
            where T : unmanaged
                => z.vsave(src, ref dst, offset);
    }
}