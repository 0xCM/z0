//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Tests
    {
        [MethodImpl(Inline)]
        public static Tests<C> alloc<C>(uint count)
            => new Tests<C>(count);
    }
}