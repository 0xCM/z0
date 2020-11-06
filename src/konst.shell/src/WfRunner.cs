//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    [ApiHost]
    public class WfRunner : IDisposable
    {
        readonly IWfShell Wf;

        readonly WfStepId Id;

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public WfRunner(IWfShell wf)
        {
            Wf = wf;
            Id = typeof(WfRunner);
            Host = WfSelfHost.create(typeof(WfRunner));
            Wf.Created(Host);

        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        void FxWf()
        {
            var fx = new FxWf(Wf);
            var f = fx.RunF();
            var g = fx.RunG();
            Wf.Status(f.Delimit());
            Wf.Status(g.Delimit());

            f.SequenceEqual(g);
        }

        [Op]
        public void Run()
        {

        }
    }
}