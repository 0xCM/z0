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

    ref struct ExtractHostMembersStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IApiHost Api;

        public ApiMemberExtract[] Extracts;

        [MethodImpl(Inline)]
        public ExtractHostMembersStep(IWfShell wf, WfHost host, IApiHost src)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Api = src;
            Extracts = new ApiMemberExtract[0]{};
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            using var flow = Wf.Running();

            try
            {
                using var step = new ExtractMembers(Wf, new ExtractMembersHost());
                Extracts = step.Extract(Api);
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }
    }
}