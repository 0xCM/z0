//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    partial struct Flow
    {
        [MethodImpl(Inline)]
        public static WfStepExec<H,T> executor<H,T>(IWfShell wf, WfStepArgs? args = null, WfStepId? id = null)
            where H : struct, IWfStepExec<T>, IWfStep<H>
        {
            var e = new WfStepExec<H,T>(wf, id ?? step<H>());
            e.Configure(args ?? WfStepArgs.Empty);
            return e;
        }

        [MethodImpl(Inline)]
        public static WfTableRunner<F,T,D,S,Y> runner<F,T,D,S,Y>(IWfShell wf, TableMaps<D,S,T,Y> processors, TableSectors<D,S> selectors)
            where F : unmanaged, Enum
            where T : struct, ITable<F,T,D>
            where D : unmanaged, Enum
            where S : unmanaged
                => new WfTableRunner<F,T,D,S,Y>(wf, processors, selectors);
    }
}