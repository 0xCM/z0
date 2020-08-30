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

    [Step(typeof(ClearCaptureArchives))]
    public readonly struct ClearCaptureArchivesStep
    {
        public const string StepName = nameof(ClearCaptureArchives);
    }

    public readonly ref struct ClearCaptureArchives
    {
        readonly IWfContext Wf;

        readonly IWfConfig Config;

        readonly CorrelationToken Ct;

        public ClearCaptureArchives(IWfContext wf, IWfConfig config, CorrelationToken ct)
        {
            Wf = wf;
            Config = config;
            Ct = ct;
            Wf.Created(StepName, Ct);
        }

        /// <summary>
        /// Obliterates all content in archive-owned directories, returning the obliteration subjects upon completion
        /// </summary>
        void Clear(Action<FilePath> deleted, params PartId[] parts)
        {
            var archive = Archives.capture(Config.TargetArchive.Root);
            foreach(var part in parts)
            {
                foreach(var file in archive.ExtractDir.Files(part))
                    file.Delete().OnSome(deleted);

                foreach(var file in archive.ParsedDir.Files(part))
                    file.Delete().OnSome(deleted);

                foreach(var file in archive.AsmDir.Files(part))
                    file.Delete().OnSome(deleted);

                foreach(var file in archive.CodeDir.Files(part))
                    file.Delete().OnSome(deleted);
            }
        }

        static void OnDelete(FilePath src)
        {

        }

        public void Run()
        {
            var parts = Config.Parts;
            Clear(OnDelete,Config.Parts);
        }

        public void Dispose()
        {
            Wf.Finished(StepName, Ct);
        }
    }
}