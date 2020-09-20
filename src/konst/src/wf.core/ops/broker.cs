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

    partial struct Flow
    {
        [MethodImpl(Inline)]
        public static DataBroker<K,C,T> broker<K,C,T>(IWfShell wf, int capacity, WfDelegates.Indexer<K> xf)
            where K : unmanaged, Enum
                => new DataBroker<K,C,T>(wf, capacity, xf);

        [MethodImpl(Inline)]
        public static DataBroker<K,T> broker<K,T>(int capacity, WfDelegates.Indexer<K> @if = null)
            where K : unmanaged, Enum
                => new DataBroker<K,T>(capacity, @if ?? Enums.e64u);
    }
}