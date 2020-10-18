//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [WfHost]
    public sealed class ClearCaptureArchives : WfHost<ClearCaptureArchives>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new ClearCaptureArchivesStep(wf,this);
            step.Run();
        }
    }

    readonly ref struct ClearCaptureArchivesStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public ClearCaptureArchivesStep(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            foreach(var part in Wf.Api.PartIdentities)
                Clear(part);
        }

        void Clear(PartId part)
        {
            var total = 0u;
            total += ClearExtracts(part);
            total += ClearParsed(part);
            total += ClearAsm(part);
            total += ClearHex(part);
            total += ClearCil(part);
            Wf.Status(delimit(part, total));
        }

        Outcome<uint> Clear(PartId part, FS.Files src, [CallerMemberName] string caller = null)
        {
            var wf = Wf;
            var result = src.Delete();
            if(result)
                wf.Trace(delimit(part.Format(), caller, result.Data));
            else
                wf.Error(result.Error);

            return result;
        }

        Outcome<uint> ClearExtracts(PartId part)
            => Clear(part, Wf.Db().CapturedExtractFiles(part));

        Outcome<uint> ClearParsed(PartId part)
            => Clear(part, Wf.Db().ParsedExtractFiles(part));

        Outcome<uint> ClearAsm(PartId part)
            => Clear(part, Wf.Db().CapturedAsmFiles(part));

        Outcome<uint> ClearHex(PartId part)
            => Clear(part, Wf.Db().CapturedHexFiles(part));

        Outcome<uint> ClearCil(PartId part)
            => Clear(part, Wf.Db().CapturedCilFiles(part));
    }
}