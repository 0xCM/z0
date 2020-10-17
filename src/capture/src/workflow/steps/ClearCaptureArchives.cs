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

    [Step]
    public sealed class ClearCaptureArchives : WfHost<ClearCaptureArchives>
    {

    }

    readonly ref struct ClearCaptureArchivesStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IWfInit Config;

        [MethodImpl(Inline)]
        public ClearCaptureArchivesStep(IWfShell wf, WfHost host, IWfInit config)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Config = config;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            var parts = Config.PartIdentities;
            var root = Wf.Db().CaptureRoot();
            var archive = Archives.capture(Config.TargetArchive.Root);
            foreach(var part in parts)
            Clear(part);
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