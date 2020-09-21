//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    [ApiHost]
    public readonly ref struct WfRunner
    {
        readonly IWfShell Wf;

        readonly WfStepId Id;

        [MethodImpl(Inline)]
        public WfRunner(IWfShell wf)
        {
            Wf = wf;
            Id = typeof(WfRunner);
            Wf.Created(Id);

        }

        public void Dispose()
        {
            Wf.Disposed(Id);
        }

        [Op]
        public void Run()
        {
            Wf.Running(Id);
            var data = Resources.text(typeof(AsciLetterLoText));
            var resources = @readonly(data);
            var rows = Resources.rows(data).View;
            var count = resources.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var res = ref skip(resources,i);
                ref readonly var row = ref skip(rows,i);
                Wf.DataRow(delimit(row.Id, row.Address, row.Value));
            }

            Wf.Ran(Id);
        }
    }
}