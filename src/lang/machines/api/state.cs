//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Lang;

    using static Root;

    partial struct api
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DfaState<T> state<T>(int order, Atom<T> src)
            where T : unmanaged
                => new DfaState<T>(order, src);
    }
}