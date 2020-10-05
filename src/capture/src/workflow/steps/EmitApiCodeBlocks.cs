//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static z;

    [WfHost]
    public sealed class EmitApiCodeBlocks : WfHost<EmitApiCodeBlocks>
    {
        ApiHostUri HostUri;

        ApiMemberCodeBlocks MemberBlocks;

        public static EmitApiCodeBlocks create(ApiHostUri uri, ApiMemberCodeBlocks src)
        {
            var dst = new EmitApiCodeBlocks();
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

    ref struct EmitApiCodeBlocksStep
    {
        public ApiCodeRow[] Emitted;

        public ApiCodeTableSaved Event;

        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly ApiHostUri Uri;

        readonly ApiMemberCodeBlocks Source;

        readonly FS.FilePath Target;

        public EmitApiCodeBlocksStep(IWfShell wf, WfHost host, ApiHostUri uri, ApiMemberCodeBlocks src)
        {
            Wf = wf;
            Host = host;
            Uri = uri;
            Source = src;
            Target = FS.path(Wf.Paths.CaptureArchive(uri).HostX86Path.Name);
            Emitted = default;
            Event = default;
            Wf.Created(Host.Id);
        }

        public void Dispose()
        {
            Wf.Disposed(Host.Id);
        }

        public void Run()
        {
            Emitted = ApiCodeBlocks.save(Source.Storage.Map(x => new ApiCodeBlock(x.Uri, x.Address, x.Encoded)), Target);
            Event = new ApiCodeTableSaved(Host.Id, Uri, Emitted, Target, Wf.Ct);
            Wf.Raise(Event);
        }
    }
}