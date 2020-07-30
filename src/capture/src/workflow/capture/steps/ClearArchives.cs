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
        readonly Arrow<ArchiveConfig>  Config;

        readonly ReadOnlySpan<PartId> Parts;

        readonly Dictionary<PartId,FilePath[]> Deleted; 

        public ClearCaptureArchives(Arrow<ArchiveConfig> config, params PartId[] parts)
        {
            Config = config;
            Parts = parts;
            Deleted = new Dictionary<PartId, FilePath[]>();
        }

        public void Run()
        {
            var count = Parts.Length;
            var archive = Archives.Services.CaptureArchive(Config.Dst.ArchiveRoot);
            var files = list<FilePath>();       
            for(var i=0u; i<count; i++)
            {
                var part = skip(Parts,i);
                archive.ClearPartFiles(part, file => files.Add(file));
                Deleted.Add(part, files.ToArray());
            }                        
        }

        public KeyedValues<PartId,FilePath[]> Removed
            => KeyedValues.from(Deleted);
        
        public void Dispose()
        {

        }
    }
}