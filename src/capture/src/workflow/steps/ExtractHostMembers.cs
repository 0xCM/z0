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

    [WfHost]
    public sealed class ExtractHostMembers : WfHost<ExtractHostMembers>
    {
        protected override void Execute(IWfShell shell)
            => throw missing();
    }

    ref struct ExtractHostMembersStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IApiHost Api;

        public ApiMemberExtract[] Extracts;

        [MethodImpl(Inline)]
        public ExtractHostMembersStep(IWfShell wf, WfHost host, IApiHost src)
        {
            Wf = wf;
            Host = host;
            Api = src;
            Extracts = new ApiMemberExtract[0]{};
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public void Run()
        {
            Wf.Running(Host);
            try
            {
                using var step = new ExtractMembers(Wf, new ExtractMembersHost());
                Extracts = step.Extract(Api);

            }
            catch(Exception e)
            {
                Wf.Error(Host, e);
            }

            Wf.Ran(Host);
        }
    }
}