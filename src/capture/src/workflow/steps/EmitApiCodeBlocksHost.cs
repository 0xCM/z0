//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [WfHost]
    public sealed class EmitApiCodeBlocksHost : WfHost<EmitApiCodeBlocksHost>
    {
        ApiHostUri HostUri;

        ApiMemberCodeBlocks MemberBlocks;

        public static EmitApiCodeBlocksHost create(ApiHostUri uri, ApiMemberCodeBlocks src)
        {
            var dst = new EmitApiCodeBlocksHost();
            dst.HostUri = uri;
            dst.MemberBlocks = src;
            return dst;
        }

        protected override void Execute(IWfShell wf)
        {
            if(MemberBlocks.Count == 0)
                return;

            using var step = new EmitApiCodeBlocksStep(wf, this, HostUri, MemberBlocks);
            step.Run();
        }
    }

}