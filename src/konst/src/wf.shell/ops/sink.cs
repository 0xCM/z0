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

    partial class WfShell
    {
        /// <summary>
        /// Creates a T-parametric sink predicated on a <see cref='ValueReceiver{T}'/> process function
        /// </summary>
        /// <param name="wf">The workflow context</param>
        /// <param name="f">The process function</param>
        /// <typeparam name="T">The data type</typeparam>
        public static WfDataSink<T> sink<T>(IWfShell wf, ValueReceiver<T> f)
            where T : struct
                => new WfDataSink<T>(wf, f);
    }
}