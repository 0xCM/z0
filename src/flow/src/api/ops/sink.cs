//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static ProcessFx;
    using static Konst;
    using static z;

    partial struct OldFlow
    {
        /// <summary>
        /// Creates a T-parametric sink predicated on a <see cref='Receive{T}'/> process function
        /// </summary>
        /// <param name="wf">The workflow context</param>
        /// <param name="f">The process function</param>
        /// <typeparam name="T">The data type</typeparam>
        [MethodImpl(Inline)]
        public static WfTableSink<T> sink<T>(IWfContext wf, Receive<T> f)
            where T : struct, ITable<T>
                => new WfTableSink<T>(wf, f);
    }
}