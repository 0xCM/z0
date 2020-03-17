//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Root
    {
        [MethodImpl(Inline)]
        public static NK<T> nk<T>(T t = default)
            where T : unmanaged
                => NumericKinded.From(t);
    }
}