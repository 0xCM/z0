//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    unsafe partial struct Pointers
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Ptr<T> prior<T>(in Ptr<T> src)
            where T : unmanaged
        {
            ref var dst = ref z.edit(src);
            dst.P--;
            return ref dst;
        }
    }
}