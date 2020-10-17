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

    using Z0.Asm;

    [WfHost]
    public sealed class EmitCapturedExtracts : WfHost<EmitCapturedExtracts>
    {
        protected override void Execute(IWfShell shell)
            => throw missing();
    }

    public ref struct EmitCapturedExtractsStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly ApiHostUri Uri;

        readonly ApiMemberExtract[] Source;

        public ApiCodeRow[] Emitted;

        [MethodImpl(Inline)]
        public EmitCapturedExtractsStep(IWfShell wf,  WfHost host, ApiHostUri uri, ApiMemberExtract[] src)
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
            try
            {
                var target = Wf.Db().CapturedExtractFile(Uri);
                Emitted = ApiCodeBlocks.save(Source.Map(x => new ApiCodeBlock(x.Address, x.OpUri, x.Encoded)), target);
                Wf.EmittedTable<ApiCodeRow>(Emitted.Length, target);
                //var  = new ApiCodeTableSaved(Host.Id, Uri, Emitted, target, Wf.Ct);

                // Artifact = ApiExtractReport.Create(Uri, Source);
                // Wf.Raise(new ExtractReportCreated(Host, Uri, Artifact.RecordCount, Wf.Ct));
                // var result = Report.Save(target);
                // if(result)
                //     Wf.Raise(new ExtractReportSaved(Host, Artifact.RecordCount, target, Wf.Ct));
                // else
                //     Wf.Error(Host, "Unable to save extract report");
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }
    }
}