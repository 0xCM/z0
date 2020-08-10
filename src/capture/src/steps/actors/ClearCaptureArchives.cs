//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;
    using static z;

    [Step(WfStepKind.ClearCaptureArchives)]
    public readonly ref struct ClearCaptureArchives 
    {        
        readonly IWfContext Wf;
        
        readonly WfConfig Config;
        
        readonly CorrelationToken Ct;

        public ClearCaptureArchives(IWfContext wf, WfConfig config, CorrelationToken ct)
        {
            Wf = wf;
            Config = config;
            Ct = ct;            
            Wf.Created(nameof(ClearCaptureArchives), Ct);            
        }

        /// <summary>
        /// Obliterates all content in archive-owned directories, returning the obliteration subjects upon completion
        /// </summary>
        void Clear(Action<FilePath> deleted, params PartId[] parts)
        {
            var archive = Archives.Services.CaptureArchive(Config.Target.ArchiveRoot);
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
            Wf.Finished(nameof(ClearCaptureArchives), Ct);
        }
    }
}