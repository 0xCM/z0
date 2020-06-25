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

    using static Konst;

    public interface TCaptureArchive : TArchive, TImmArchive
    {
        /// <summary>
        /// Extract log extension
        /// </summary>
        FileExtension Extract 
            => FileExtension.Define("x.csv", "Extract log");

        /// <summary>
        /// Parse log extension
        /// </summary>
        FileExtension Parsed 
            => FileExtension.Define("p.csv", "Parse log");
    
        /// <summary>
        /// Parse failure log extension
        /// </summary>
        FileExtension Unparsed 
            => FileExtension.Define("u.csv","Parse failure log");

        FolderName ExtractFolder 
            => FolderName.Define("extracted", "Raw binary extracts");
    
        FolderName ParsedFolder 
            => FolderName.Define("parsed", "Parsed binary extracts");

        FolderName UnparsedFolder
            => FolderName.Define("unparsed", "Extraction parse failures");

        FolderName LogFolder
            => FolderName.Define("logs", "Application logs");

        FileName CilFileName(OpIdentity id) 
            => LegalFileName(id, Il);

        FileName ParseFileName(ApiHostUri host)
            => LegalFileName(host, Parsed);

        FolderPath RefDataDir
            => (ArchiveRoot + DataPartition).Create();

        FolderPath ExtractDir 
            => (ArchiveRoot + ExtractFolder).Create();

        FolderPath UnparsedDir 
            => (ArchiveRoot + UnparsedFolder).Create();

        FolderPath ParsedDir 
            => (ArchiveRoot + ParsedFolder).Create();
        
        FolderPath CodeDir 
            => (ArchiveRoot + CodeFolder).Create();
    
        FolderPath AsmDir 
            => (ArchiveRoot + AsmFolder).Create();

        FolderPath LogDir 
            => (ArchiveRoot + LogFolder).Create();

        TCaptureArchive Narrow(FolderName area, FolderName subject)
            => new CaptureArchive(ArchiveRoot, area, subject);        

        /// <summary>
        /// Obliterates all content in archive-owned directories, returning the obliteration subjects upon completion
        /// </summary>
        FolderPath[] Clear(params PartId[] parts)
        {
            if(parts.Length == 0)
            {
                var dst = Root.list<FolderPath>();
                dst.Add(ExtractDir.Clear());
                dst.Add(ParsedDir.Clear());
                dst.Add(AsmDir.Clear());
                dst.Add(CodeDir.Clear());
                dst.Add(UnparsedDir.Clear());
                return dst.ToArray();
            }
            else
            {
                for(var i=0; i<parts.Length; i++)
                {
                    var part = parts[i];
                    Root.iter(ExtractDir.Files(part, Extract), f => f.Delete());
                    Root.iter(ParsedDir.Files(part, Parsed), f => f.Delete());
                    Root.iter(AsmDir.Files(part, Asm), f => f.Delete());
                    Root.iter(CodeDir.Files(part, Hex), f => f.Delete());
                    Root.iter(UnparsedDir.Files(part, Unparsed), f => f.Delete());
                }
                return Root.array<FolderPath>();
            }
        }                
        
        [MethodImpl(Inline)]
        THostCaptureArchive HostArchive(ApiHostUri host)
            => new HostCaptureArchive(ArchiveRoot, host);

        FolderName AreaName 
            => FolderName.Empty;

        FolderName SubjectName 
            => FolderName.Empty;

        FilePath HexPath(FileName name)
            => CodeDir + name;

        FilePath AsmPath(FileName name)
            => AsmDir + name;

        FilePath AsmPath<T>()
            => AsmPath(FileName.Define(typeof(T).Name, Asm));

        FilePath HexPath<T>()
            => HexPath(FileName.Define(typeof(T).Name, Hex));

        FilePath HexPath(ApiHostUri host)
            => CodeDir + FileName.Define(host.Name, Hex);

        FilePath AsmPath(ApiHostUri host)
            => AsmDir + FileName.Define(host.Name, Asm);

        FilePath ExtractPath(ApiHostUri host)
            => ExtractDir + FileName.Define(host.Name, Extract);

        FilePath UnparsedPath(ApiHostUri host)
            => UnparsedDir + FileName.Define($"{host.Owner.Format()}.{host.Name}", Unparsed);

        FilePath ParsePath(ApiHostUri host)
            => ParsedDir + FileName.Define(host.Name, Parsed);

        FilePath LogPath(ApiHostUri host)
            => LogDir + FileName.Define(host.Name, Log);

        IEnumerable<FilePath> AsmFiles 
            => AsmDir.Files(Asm);  

        IEnumerable<FilePath> HexFiles 
            => CodeDir.Files(Hex);     

        IEnumerable<FilePath> ExtractFiles 
            => ExtractDir.Files(Extract);     

        IEnumerable<FilePath> ParseFiles 
            => ParsedDir.Files(Parsed);   
    }
}