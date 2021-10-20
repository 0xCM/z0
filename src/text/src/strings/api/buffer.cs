//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Strings
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct strings
    {
        [Op, Closures(Closure)]
        public static StringBuffer<S> buffer<S>(uint length)
            where S : unmanaged
                => new StringBuffer<S>(length);

        [Op, Closures(Closure)]
        public static StringBuffer buffer(uint length)
            => new StringBuffer(length);
    }
}