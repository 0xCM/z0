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
        readonly WfContext Wf;
        
        readonly PartWfConfig Config;
        
        readonly CorrelationToken Ct;

        public ClearCaptureArchives(PartWfConfig config, CorrelationToken? ct = null)
        {
            Config = config;
            Ct = ct ?? CorrelationToken.create();
            Wf = config.Context;
            Wf.Running(nameof(ClearCaptureArchives), Ct);            
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
            Wf.Ran(nameof(ClearCaptureArchives), Ct);
        }
    }
}