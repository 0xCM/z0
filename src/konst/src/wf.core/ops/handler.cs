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

    partial struct WfCore
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static DataHandler<T> handler<T>(DataReceiver<T> receiver)
            => new DataHandler<T>(receiver);

        [MethodImpl(Inline)]
        public static WfDataHandler<S,T> handler<S,T>(IWfShell wf, RefMap<S,T> f, S[] src, T[] dst)
            => new WfDataHandler<S,T>(wf, f,src,dst);
    }
}