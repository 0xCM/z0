//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Z0.Asm;

    using static z;

    [WfHost]
    public sealed class DecodeApiMembers : WfHost<DecodeApiMembers,ApiMemberCodeBlocks, AsmRoutines>
    {
        ICaptureContext Capture;

        ApiHostUri ApiHost;

        public static DecodeApiMembers create(ICaptureContext capture, ApiHostUri host)
        {
            var dst = create();
            dst.Capture = capture;
            dst.ApiHost = host;
            return dst;
        }

        protected override ref AsmRoutines Execute(IWfShell wf, in ApiMemberCodeBlocks src, out AsmRoutines dst)
        {
            using var step = new DecodeApiMembersStep(wf, this, Capture);
            dst = step.Run(ApiHost, src);
            return ref dst;
        }
    }
}