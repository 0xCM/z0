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

        readonly IWfConfig Config;

        readonly CorrelationToken Ct;

        public ClearCaptureArchives(IWfShell wf, IWfConfig config, CorrelationToken ct)
        {
            Wf = wf;
            Config = config;
            Ct = ct;
            Wf.Created(StepId, Ct);
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
            var parts = Config.PartIdentities;
            Clear(OnDelete,Config.PartIdentities);
        }

        public void Dispose()
        {
            Wf.Finished(StepId, Ct);
        }
    }
}