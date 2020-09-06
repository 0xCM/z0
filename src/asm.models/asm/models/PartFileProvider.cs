//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static z;
    using static Konst;

    public readonly struct PartFileProvider
    {
        readonly IShellPaths Paths;

        readonly IWfShell Wf;

        public readonly FS.FolderPath Root;

        readonly IPartCapturePaths CapturePaths;

        public readonly FS.Files Parsed;

        public readonly FS.Files Hex;

        public readonly FS.Files Asm;

        [MethodImpl(Inline)]
        public PartFileProvider(IWfShell wf, FS.FolderPath root)
        {
            Wf = wf;
            Root = root;
            Paths = Wf.AppPaths;
            CapturePaths = CaptureArchive(Root);
            Parsed = CaptureArchive(Root).ParsePaths.Select(x => FS.path(x.Name));
            Hex = CaptureArchive(Root).HexPaths.Select(x => FS.path(x.Name));
            Asm = CaptureArchive(Root).AsmPaths.Select(x => FS.path(x.Name));
        }

        public MemberParseRecord[] ParseRecords(PartId part)
        {
            var files = ParseFileIndex(part);
            if(files.TryGetValue(part, out var partFiles))
            {
                var count = partFiles.Length;
                var view = @readonly(partFiles);
                for(var j=0; j<count; j++)
                {
                    ref readonly var file = ref skip(view, j);
                    var records = MemberParseRecord.load(file.Path);
                    if(records)
                        return records.Value;
                }
            }

            return sys.empty<MemberParseRecord>();
        }

        public FS.Files ParseFiles
            => CaptureArchive(Root).ParsePaths;

        public FS.Files AsmFiles
            => CaptureArchive(Root).AsmPaths;

        public FS.Files HexFiles
            => CaptureArchive(Root).HexPaths;

        public Dictionary<PartId,PartFile[]> ParseFileIndex(params PartId[] parts)
            => SelectFiles(PartFileClass.Parsed, ParseFiles, parts);

        static Dictionary<PartId,PartFile[]> SelectFiles(PartFileClass kind, FS.Files src, PartId[] parts)
        {
            var partSet = parts.ToHashSet();
            var files = (from f in src
                        let part = f.Owner
                        where part != PartId.None && partSet.Contains(part)
                        let pf = new PartFile(part, kind, f)
                        group pf by pf.Part).ToDictionary(x => x.Key, y => y.ToArray());
            return files;
        }

        [MethodImpl(Inline)]
        static IPartCapturePaths CaptureArchive(FS.FolderPath src)
            => Archives.capture(FolderPath.Define(src.Name));
    }
}