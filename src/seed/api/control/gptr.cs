//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe T* gptr<T>(in T src)
            where T : unmanaged
                => (T*)Root.pvoid(ref edit(in src));
    }
}