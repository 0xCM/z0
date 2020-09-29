//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    ref struct ExtractHostMembersStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IApiHost Source;

        public ApiMemberExtract[] Extracts;

        [MethodImpl(Inline)]
        public ExtractHostMembersStep(IWfShell wf, WfHost host, IApiHost src, IPartCapturePaths dst)
        {
            Wf = wf;
            Host = host;
            Source = src;
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
                Extracts = step.Extract(Source);

            }
            catch(Exception e)
            {
                Wf.Error(Host, e);
            }

            Wf.Ran(Host);
        }
    }
}