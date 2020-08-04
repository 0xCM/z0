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

    using static Konst;
    
    public readonly struct PartFiles
    {
        readonly TAppPaths AppPaths;

        [MethodImpl(Inline)]
        internal PartFiles(IAsmContext context)
            => AppPaths = context.AppPaths.ForApp(Part.ExecutingPart);            

        [MethodImpl(Inline)]
        public static PartFiles create(IAsmContext context)
            => new PartFiles(context);

        public static MemberParseRecord[] parsed(IAsmContext context, PartId part)
        {
            var pfs = PartFiles.create(context);
            var files = pfs.ParseFileIndex(part);
            var parser = ParseReportParser.Service;
            if(files.TryGetValue(part, out var partFiles))
            {
                for(var j= 0; j<partFiles.Length; j++)
                {
                    var path = partFiles[j].Path;
                    var records = parser.ParseRecords(path);
                    if(records)
                        return records.Value;
                }                    
            }       
            
            return sys.empty<MemberParseRecord>();
        }

        public static FilePath[] AsmPaths(FolderPath root, params PartId[] parts)
            => CaptureArchive(root).AsmFilePaths(parts);

        public static FilePath[] HexPaths(FolderPath root, params PartId[] parts)
            => CaptureArchive(root).HexFilePaths(parts);

        public static FilePath[] ParsePaths(FolderPath root, PartId[] parts)
            => CaptureArchive(root).ParseFilePaths(parts);
        
        public FolderPath ArchiveRoot 
            => AppPaths.AppCaptureRoot;
        
        public FilePath[] ParseFiles
            => CaptureArchive(AppPaths.AppCaptureRoot).ParseFiles;

        public FilePath[] AsmFiles
            => CaptureArchive(AppPaths.AppCaptureRoot).AsmFiles;

        public FilePath[] HexFiles
            => CaptureArchive(AppPaths.AppCaptureRoot).HexFiles;

        public Dictionary<PartId,PartFile[]> ParseFileIndex(params PartId[] parts)
            => SelectFiles(PartFileClass.Parsed, ParseFiles, parts);
        
        public Dictionary<PartId,PartFile[]> HexFileIndex(params PartId[] parts)
            => SelectFiles(PartFileClass.Hex, HexFiles, parts);

        public Dictionary<PartId,PartFile[]> AsmFileIndex(params PartId[] parts)
            => SelectFiles(PartFileClass.Asm, AsmFiles, parts);
        
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

        static TArchives ArchiveServices 
            => Archives.Services;

        [MethodImpl(Inline)]
        static TPartCaptureArchive CaptureArchive(FolderPath root)
            => ArchiveServices.CaptureArchive(root, null, null);
    }
}