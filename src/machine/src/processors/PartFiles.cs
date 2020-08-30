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

    using Z0.Asm;

    using static z;
    using static Konst;

    public readonly struct PartFiles
    {
        readonly IShellPaths AppPaths;

        [MethodImpl(Inline)]
        public PartFiles(IAsmContext context)
            => AppPaths = context.AppPaths.ForApp(Part.ExecutingPart);

        public static MemberParseRecord[] parsed(IAsmContext context, PartId part)
        {
            var pfs = new PartFiles(context);
            var files = pfs.ParseFileIndex(part);
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

        public FolderPath ArchiveRoot
            => AppPaths.AppCaptureRoot;

        public FilePath[] ParseFiles
            => CaptureArchive(AppPaths.MachineCaptureRoot).ParseFiles;

        public FilePath[] AsmFiles
            => CaptureArchive(AppPaths.MachineCaptureRoot).AsmFiles;

        public FilePath[] HexFiles
            => CaptureArchive(AppPaths.MachineCaptureRoot).HexFiles;

        public Dictionary<PartId,PartFile[]> ParseFileIndex(params PartId[] parts)
            => SelectFiles(PartFileClass.Parsed, ParseFiles, parts);

        static Dictionary<PartId,PartFile[]> SelectFiles(PartFileClass kind, IEnumerable<FilePath> src, params PartId[] parts)
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
        static IPartCapturePaths CaptureArchive(FolderPath root)
            => Archives.capture(root, null, null);
    }
}