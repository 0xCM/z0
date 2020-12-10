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
            TotalStatus(part,total);
        }

        static Outcome<uint> Clear(FS.Files src)
            => src.Delete();

        const string TypeStatusPattern = "Cleared {0} *.{1} {2} files";

        const string TotalStatusPattern = "Cleared {0} total {1} files";

        void TypeStatus(PartId part, FS.FileExt ext, Count count)
            => Wf.Status(string.Format(TypeStatusPattern, count, ext, part.Format()));

        void TotalStatus(PartId part, Count count)
            => Wf.Status(string.Format(TotalStatusPattern, count, part.Format()));

        Outcome<uint> ClearExtracts(PartId part)
        {
            var kind = ArchiveFileExt.XCsv;
            var files = Wf.Db().CapturedExtractFiles(part);
            var result = Clear(files);
            if(result)
                TypeStatus(part, kind, result.Data);
            else
                Wf.Error(result.Error);
            return result;
        }

        Outcome<uint> ClearParsed(PartId part)
        {
            var kind = ArchiveFileExt.PCsv;
            var files = Wf.Db().ParsedExtractFiles(part);
            var result = Clear(files);
            if(result)
                TypeStatus(part, kind, result.Data);
            else
                Wf.Error(result.Error);
            return result;
        }

        Outcome<uint> ClearAsm(PartId part)
        {
            var kind = ArchiveFileExt.Asm;
            var files = Wf.Db().CapturedAsmFiles(part);
            var result = Clear(files);
            if(result)
                TypeStatus(part, kind, result.Data);
            else
                Wf.Error(result.Error);
            return result;
        }

        Outcome<uint> ClearHex(PartId part)
        {
            var kind = ArchiveFileExt.Hex;
            var files = Wf.Db().CapturedHexFiles(part);
            var result = Clear(files);
            if(result)
                TypeStatus(part, kind, result.Data);
            else
                Wf.Error(result.Error);
            return result;
        }

        Outcome<uint> ClearCil(PartId part)
        {
            var kind = ArchiveFileExt.IlData;
            var files = Wf.Db().CapturedCilDataFiles(part);
            var result = Clear(files);
            if(result)
                TypeStatus(part, kind, result.Data);
            else
                Wf.Error(result.Error);
            return result;
        }
    }
}