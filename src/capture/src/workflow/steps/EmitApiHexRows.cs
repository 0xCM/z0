//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [WfHost]
    public sealed class EmitApiHexRows : WfHost<EmitApiHexRows>
    {
        ApiHostUri HostUri;

        ApiMemberCode[] MemberBlocks;

        public static EmitApiHexRows create(ApiHostUri uri, params ApiMemberCode[] src)
        {
            var dst = new EmitApiHexRows();
            dst.HostUri = uri;
            dst.MemberBlocks = src;
            return dst;
        }

        protected override void Execute(IWfShell wf)
        {
           if(MemberBlocks != null && MemberBlocks.Length != 0)
           {
                using var step = new EmitApiHexRowsStep(wf, this, HostUri, MemberBlocks);
                step.Run();
           }
        }
    }

    ref struct EmitApiHexRowsStep
    {
        public ApiHexRow[] Emitted;

        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly ApiHostUri Uri;

        readonly ApiMemberCodeBlocks Source;

        public EmitApiHexRowsStep(IWfShell wf, WfHost host, ApiHostUri uri, ApiMemberCode[] src)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Uri = uri;
            Source = src;
            Emitted = default;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            var target = Wf.Db().ParsedExtractFile(Uri);
            Emitted = ApiParseBlocks.create(Uri, Source);
            if(ApiParseBlocks.save(Emitted,target))
                Wf.EmittedTable<ApiHexRow>(Emitted.Length, target);
            else
                Wf.Error($"Could not save {target}");
        }
    }
}