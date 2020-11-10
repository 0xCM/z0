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
    public sealed class EmitParsedExtracts : WfHost<EmitParsedExtracts>
    {
        ApiHostUri HostUri;

        ApiMemberCodeBlocks MemberBlocks;

        public static EmitParsedExtracts create(ApiHostUri uri, ApiMemberCodeBlocks src)
        {
            var dst = new EmitParsedExtracts();
            dst.HostUri = uri;
            dst.MemberBlocks = src;
            return dst;
        }

        protected override void Execute(IWfShell wf)
        {
            if(MemberBlocks.Count == 0)
                return;

            using var step = new EmitParsedExtractsStep(wf, this, HostUri, MemberBlocks);
            step.Run();
        }
    }

    ref struct EmitParsedExtractsStep
    {
        public ApiParseBlock[] Emitted;

        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly ApiHostUri Uri;

        readonly ApiMemberCodeBlocks Source;

        public EmitParsedExtractsStep(IWfShell wf, WfHost host, ApiHostUri uri, ApiMemberCodeBlocks src)
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
                Wf.EmittedTable<ApiParseBlock>(Emitted.Length, target);
            else
                Wf.Error($"Could not save {target}");
        }
    }
}