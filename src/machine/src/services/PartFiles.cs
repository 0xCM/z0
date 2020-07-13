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

    public readonly struct MachineFiles
    {            
        public IMachineContext Context {get;}
        
        public TPartCaptureArchive CaptureArchive {get;}
       
        [MethodImpl(Inline)]
        public static MachineFiles Service(IMachineContext context)
            => new MachineFiles(context);

        [MethodImpl(Inline)]
        public MachineFiles(IMachineContext context)
        {
            Context = context;
            CaptureArchive = context.Archive;
        }
    } 
    
    public readonly struct PartFiles
    {
        public static MemberParseRecord[] parsed(IAsmContext context, PartId part)
        {
            var pfs = PartFiles.Service(context);
            var files = PartFiles.Service(context).ParseFileIndex(part);
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
        
        public FilePath[] ParseFiles
            => CaptureArchive(AppPaths.AppCaptureRoot).ParseFiles;

        public FilePath[] AsmFiles
            => CaptureArchive(AppPaths.AppCaptureRoot).AsmFiles;

        public FilePath[] HexFiles
            => CaptureArchive(AppPaths.AppCaptureRoot).HexFiles;

        public FilePath[] PartParseFiles(PartId[] parts, PartId part)
            => CaptureArchive(AppPaths.AppCaptureRoot).PartParseFilePaths(parts,part);

        public FilePath[] PartAsmFiles(params PartId[] parts)
            => CaptureArchive(AppPaths.AppCaptureRoot).AsmFilePaths(parts);

        public FilePath[] PartHexFiles(params PartId[] parts)
            => CaptureArchive(AppPaths.AppCaptureRoot).HexFilePaths(parts);

        public Dictionary<PartId,PartFile[]> ParseFileIndex(params PartId[] parts)
            => SelectFiles(PartFileKind.Parsed, ParseFiles, parts);
        
        public Dictionary<PartId,PartFile[]> HexFileIndex(params PartId[] parts)
            => SelectFiles(PartFileKind.Hex, HexFiles, parts);

        public Dictionary<PartId,PartFile[]> AsmFileIndex(params PartId[] parts)
            => SelectFiles(PartFileKind.Asm, AsmFiles, parts);
        
        Dictionary<PartId,PartFile[]> SelectFiles(PartFileKind kind, IEnumerable<FilePath> src, params PartId[] parts)
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