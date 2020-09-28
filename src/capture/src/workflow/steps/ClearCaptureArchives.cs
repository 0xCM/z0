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

    public readonly ref struct ClearCaptureArchives
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IWfInit Config;

        [MethodImpl(Inline)]
        public ClearCaptureArchives(IWfShell wf, WfHost host, IWfInit config)
        {
            Wf = wf;
            Host = host;
            Config = config;
            Wf.Created(Host);
        }

        /// <summary>
        /// Obliterates all content in archive-owned directories, returning the obliteration subjects upon completion
        /// </summary>
        void Clear(PartId[] parts)
        {
            var archive = ApiArchives.capture(Config.TargetArchive.Root);
            foreach(var part in parts)
            ClearPartFiles(archive,part);
        }

        Outcome<uint> Clear(PartId part, FS.Files src, [CallerMemberName] string caller = null)
        {

            var wf = Wf;
            var result = src.Delete();
            if(result)
                wf.Trace(Host, delimit(part.Format(), caller, result.Data));
            else
                wf.Error(Host, result.Error);

            return result;
        }

        Outcome<uint> ClearExtracts(IPartCaptureArchive archive, PartId part)
            => Clear(part, archive.ExtractDir.Files(part));

        Outcome<uint> ClearParsed(IPartCaptureArchive archive, PartId part)
            => Clear(part, archive.ParsedDir.Files(part));

        Outcome<uint> ClearAsm(IPartCaptureArchive archive, PartId part)
            => Clear(part, archive.PartAsmDir(part).Files(part));

        Outcome<uint> ClearX86(IPartCaptureArchive archive, PartId part)
            => Clear(part, archive.X86Dir.Files(part));

        Outcome<uint> ClearCil(IPartCaptureArchive archive, PartId part)
            => Clear(part, archive.CilDir.Files(part));

        void ClearPartFiles(IPartCaptureArchive archive, PartId part)
        {
            var total = 0u;
            Wf.Running(Host, delimit(nameof(ClearPartFiles), part));
            total += ClearExtracts(archive,part);
            total += ClearParsed(archive,part);
            total += ClearAsm(archive,part);
            total += ClearX86(archive,part);
            total += ClearCil(archive,part);
            Wf.Ran(Host, delimit(nameof(ClearPartFiles), part, total));
        }

        public void Run()
        {
            Clear(Config.PartIdentities);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }
    }
}