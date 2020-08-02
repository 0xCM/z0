//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    public readonly ref struct ClearCaptureArchives 
    {        
        readonly WfContext Context;
        
        readonly PartWfConfig Config;

        ReadOnlySpan<IPart> Parts 
            => Config.Parts;
        
        readonly Dictionary<PartId,FilePath[]> Deleted; 

        public ClearCaptureArchives(PartWfConfig config)
        {
            Config = config;
            Context = config.Context;
            Deleted = new Dictionary<PartId, FilePath[]>();
            term.print($"Clearing target archive {config.Target.ArchiveRoot}");
        }

        public void Run()
        {
            var count = Parts.Length;
            var archive = Archives.Services.CaptureArchive(Config.Target.ArchiveRoot);
            var files = list<FilePath>();       
            for(var i=0u; i<count; i++)
            {
                var part = skip(Parts,i);
                archive.ClearPartFiles(part.Id, file => files.Add(file));
                Deleted.Add(part.Id, files.ToArray());
            }                        
        }

        public KeyedValues<PartId,FilePath[]> Removed
            => KeyedValues.from(Deleted);
        
        public void Dispose()
        {
            term.print($"Cleared {Removed.Count} files from target archive {Config.Target.ArchiveRoot}");
            Context.Raise(new ClearedPartFiles(Removed));
        }
    }
}