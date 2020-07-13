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

        public FilePath[] List<K>(params PartId[] parts)
            where K : IFileKind
        {
            if(typeof(K) == typeof(AsmFileKind))
                return PartAsmFiles(parts);            
            else if(typeof(K) == typeof(HexFileKind))
                return PartHexFiles(parts);            
            else if(typeof(K) == typeof(ParsedFileKind))
                return PartParseFiles(parts);            
            else 
                return sys.empty<FilePath>();
        }

        readonly IAsmContext Context;

        readonly TArchives DataSource; 

        readonly TAppPaths AppPaths;

        readonly object[] Collected;

        internal PartFiles(IAsmContext context)
        {
            Context = context;
            DataSource = Archives.Services;            
            AppPaths = Context.AppPaths.ForApp(PartId.Control);
            Collected = sys.alloc<object>(4);
        }
        
        public FolderPath ArchiveRoot 
            => AppPaths.AppCaptureRoot;
        
        public FilePath[] ParseFiles
            => CaptureArchive(AppPaths.AppCaptureRoot).ParseFiles;

        public FilePath[] AsmFiles
            => CaptureArchive(AppPaths.AppCaptureRoot).AsmFiles;

        public FilePath[] HexFiles
            => CaptureArchive(AppPaths.AppCaptureRoot).HexFiles;

        public FilePath[] PartParseFiles(PartId[] parts)
            => CaptureArchive(AppPaths.AppCaptureRoot).ParseFilePaths(parts);

        public FilePath[] PartAsmFiles(params PartId[] parts)
            => CaptureArchive(AppPaths.AppCaptureRoot).AsmFilePaths(parts);

        public FilePath[] PartHexFiles(params PartId[] parts)
            => CaptureArchive(AppPaths.AppCaptureRoot).HexFilePaths(parts);

        public Dictionary<PartId,PartFile[]> ParseFileIndex(params PartId[] parts)
            => SelectFiles(PartFileClass.Parsed, ParseFiles, parts);
        
        public Dictionary<PartId,PartFile[]> HexFileIndex(params PartId[] parts)
            => SelectFiles(PartFileClass.Hex, HexFiles, parts);

        public Dictionary<PartId,PartFile[]> AsmFileIndex(params PartId[] parts)
            => SelectFiles(PartFileClass.Asm, AsmFiles, parts);
        
        Dictionary<PartId,PartFile[]> SelectFiles(PartFileClass kind, IEnumerable<FilePath> src, params PartId[] parts)
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
        TPartCaptureArchive CaptureArchive(FolderPath root)
            => DataSource.CaptureArchive(root, null, null);
    }
}