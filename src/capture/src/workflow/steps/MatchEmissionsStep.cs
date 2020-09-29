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

    ref struct MatchEmissionsStep
    {
        readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        readonly WfHost Host;

        readonly TCheckEquatable Claim;

        public MatchedCapturedEmissions Event;

        [MethodImpl(Inline)]
        public MatchEmissionsStep(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Ct = Wf.Ct;
            Host = host;
            Claim = CheckEquatable.Checker;
            Wf.Created(Host.Id);
            Event = default;
        }


        public void Dispose()
        {
            Wf.Disposed(Host.Id);
        }

        public void Run(ApiHostUri host, ReadOnlySpan<ApiCodeRow> x86data, FS.FilePath x86file)
        {
            var wfStateless = Capture.Services;
            var reader = ApiHexArchives.reader<ApiCodeReader>();
            var fileSrc = @readonly(reader.Read(FilePath.Define(x86file.Name)));

            Claim.Eq(fileSrc.Length, x86data.Length);
            Claim.Eq(Spans.count<ApiCodeBlock>(fileSrc, s => s.OpUri.IsEmpty),0);
            for(var i=0; i<x86data.Length; i++)
            {
                Claim.Eq(skip(fileSrc,i).OpUri.Format(), skip(x86data,i).Uri);
                Claim.Eq(skip(fileSrc,i).Encoded.Length, skip(x86data, i).Encoded.Length);
            }

            Event = new MatchedCapturedEmissions(Host.Id, host, (uint)x86data.Length, x86file, Ct);
            Wf.Raise(Event);
        }
    }
}