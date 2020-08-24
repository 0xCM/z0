//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct AB
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static WfDataHandler<T> handler<T>(DataReceiver<T> receiver)
            => new WfDataHandler<T>(receiver);
    }
}