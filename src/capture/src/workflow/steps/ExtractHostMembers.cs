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
    public sealed class ExtractHostMembers : WfHost<ExtractHostMembers, IApiHost, TableSpan<ApiMemberExtract>>
    {
        protected override ref TableSpan<ApiMemberExtract> Execute(IWfShell wf, in IApiHost api, out TableSpan<ApiMemberExtract> dst)
        {
            using var step = new ExtractHostMembersStep(wf, this, api);
            step.Run();
            dst = step.Extracts;
            return ref dst;
        }
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
            Wf.Running();

            try
            {
                using var step = new ExtractMembers(Wf, new ExtractMembersHost());
                Extracts = step.Extract(Api);

            }
            catch(Exception e)
            {
                Wf.Error(e);
            }

            Wf.Ran();
        }
    }
}