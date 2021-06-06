//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    unsafe partial struct Pointers
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Ptr<T> cast<T>(in Ptr src)
            where T : unmanaged
                => ref @as<Ptr,Ptr<T>>(src);

        [MethodImpl(Inline)]
        public static ref Ptr<T> cast<S,T>(in Ptr<S> src)
            where S : unmanaged
            where T : unmanaged
                => ref @as<Ptr<S>,Ptr<T>>(src);
    }
}