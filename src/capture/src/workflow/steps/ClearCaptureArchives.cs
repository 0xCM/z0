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
    using static ClearCaptureArchivesStep;

    public readonly ref struct ClearCaptureArchives
    {
        readonly IWfShell Wf;

        readonly IWfInit Config;

        readonly CorrelationToken Ct;

        [MethodImpl(Inline)]
        public ClearCaptureArchives(IWfShell wf, IWfInit config, CorrelationToken ct)
        {
            Wf = wf;
            Config = config;
            Ct = ct;
            Wf.Created(StepId, Ct);
        }

        /// <summary>
        /// Obliterates all content in archive-owned directories, returning the obliteration subjects upon completion
        /// </summary>
        void Clear(PartId[] parts)
        {
            var archive = Archives.capture(Config.TargetArchive.Root);
            foreach(var part in parts)
            ClearPartFiles(archive,part);
        }

        Outcome<uint> Clear(PartId part, FS.Files src, [CallerMemberName] string caller = null)
        {
            static void Success(IWfShell wf,  PartId part, Outcome<uint> result, string caller)
                => wf.Trace(StepId, text.nest(part.Format(), caller, result.Data));

            static void Failure(IWfShell wf,  PartId part, Outcome<uint> result, string caller)
                => wf.Error(StepId, result.Error);

            var wf = Wf;
            return src.Delete().OnSuccess(x => Success(wf, part,x, caller)).OnFailure(x => Failure(wf,part,x, caller));
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
            Wf.Running<string>(StepId, text.delimit(FieldDelimiter, nameof(ClearPartFiles), part));
            total += ClearExtracts(archive,part);
            total += ClearParsed(archive,part);
            total += ClearAsm(archive,part);
            total += ClearX86(archive,part);
            total += ClearCil(archive,part);
            Wf.Ran<string>(StepId, text.delimit(FieldDelimiter, nameof(ClearPartFiles), part, total));

        }

        public void Run()
        {
            var parts = Config.PartIdentities;
            Clear(Config.PartIdentities);
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }
    }
}