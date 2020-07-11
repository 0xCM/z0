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
        public static MemberParseRecord[] parsed(IAsmContext context, PartId part)
        {
            var pfs = PartFiles.Service(context);
            var files = PartFiles.Service(context).ParseFiles(part);
            var parser = ParseReportParser.Service;
            if(files.TryGetValue(part, out var partFiles))
            {
                for(var j= 0; j<partFiles.Length; j++)
                {
                    var path = partFiles[j].Path;
                    var records = parser.ParseRecords(path);
                    if(records)
                    {
                        return records.Value;
                    }
                }                    
            }       
            return sys.empty<MemberParseRecord>();
        }

        public static PartFiles Service(IAsmContext context)
            => new PartFiles(context);

        readonly IAsmContext Context;

        readonly TArchives DataSource; 

        readonly PartFileKinds FileKinds;

        readonly TAppPaths AppPaths;

        internal PartFiles(IAsmContext context)
        {
            Context = context;
            DataSource = Archives.Services;            
            FileKinds = PartFileKinds.Service();
            AppPaths = Context.AppPaths.ForApp(PartId.Control);
        }
        
        IEnumerable<FilePath> ParseFilePaths
                => CaptureArchive(AppPaths.AppCaptureRoot).ParseFiles;

        IEnumerable<FilePath> AsmFilePaths
                => CaptureArchive(AppPaths.AppCaptureRoot).AsmFiles;

        IEnumerable<FilePath> HexFilePaths
                => CaptureArchive(AppPaths.AppCaptureRoot).HexFiles;

        public Dictionary<PartId,PartFile[]> ParseFiles(params PartId[] parts)
            => SelectFiles(PartFileKind.Parsed, ParseFilePaths, parts);
        
        public Dictionary<PartId,PartFile[]> HexFiles(params PartId[] parts)
            => SelectFiles(PartFileKind.Hex, HexFilePaths, parts);

        public Dictionary<PartId,PartFile[]> AsmFiles(params PartId[] parts)
            => SelectFiles(PartFileKind.Asm, AsmFilePaths, parts);
        
        Dictionary<PartId,PartFile[]> SelectFiles(PartFileKind kind, IEnumerable<FilePath> src, params PartId[] parts)
        {
            var partSet = parts.ToHashSet();

            var files = (from f in src
                        let part = f.Owner
                        where part != PartId.None && partSet.Contains(part)
                        let pf = DefinePartFile(part, kind, f)
                        group pf by pf.Part).ToDictionary(x => x.Key, y => y.ToArray());
            return files;
        }

        [MethodImpl(Inline)]
        TPartCaptureArchive CaptureArchive(FolderPath root)
            => DataSource.CaptureArchive(root, null, null);

        static PartFile DefinePartFile(PartId part, PartFileKind kind, FilePath path)
            => new PartFile(part, kind,path);


        // static PartId ParsePartId(FilePath src)
        // {
        //     var components = src.FileName.Name.SplitClean(Chars.Dot);
        //     if(components.Length != 0)
        //         return Enums.Parse(components[0], PartId.None);   
        //     else
        //         return PartId.None;
        // }
    }
}