//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WfBrokers
    {
        /// <summary>
        /// Creates a T-parametric sink predicated on a <see cref='ValueReceiver{T}'/> process function
        /// </summary>
        /// <param name="wf">The workflow context</param>
        /// <param name="f">The process function</param>
        /// <typeparam name="T">The data type</typeparam>
        [MethodImpl(Inline)]
        public static TableSink<T> sink<T>(IWfShell wf, ValueReceiver<T> f)
            where T : struct, ITable<T>
                => new TableSink<T>(wf, f);

        [MethodImpl(Inline)]
        public static DataBroker<K,C,T> broker<K,C,T>(IWfShell wf, int capacity, WfDelegates.Indexer<K> xf)
            where K : unmanaged, Enum
                => new DataBroker<K,C,T>(wf, capacity, xf);

        [MethodImpl(Inline)]
        public static DataBroker<K,T> create<K,T>(int capacity, WfDelegates.Indexer<K> @if = null)
            where K : unmanaged, Enum
                => new DataBroker<K,T>(capacity, @if ?? Enums.e64u);
    }
}