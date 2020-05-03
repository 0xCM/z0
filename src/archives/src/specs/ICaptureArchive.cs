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

    using static Seed;
    using static Memories;

    using static FileSystem;

    public interface ICaptureArchive : IArchive
    {
        ICaptureArchive Narrow(FolderName area, FolderName subject)
            => new CaptureArchive(RootDir, area, subject);        

        /// <summary>
        /// Obliterates all content in archive-owned directories, returning the obliteration subjects upon completion
        /// </summary>
        FolderPath[] Clear(params PartId[] parts)
        {
            if(parts.Length == 0)
            {
                var dst = list<FolderPath>();
                dst.Add(ExtractDir.Clear());
                dst.Add(ParsedDir.Clear());
                dst.Add(AsmDir.Clear());
                dst.Add(HexDir.Clear());
                dst.Add(UnparsedDir.Clear());
                return dst.ToArray();
            }
            else
            {
                for(var i=0; i<parts.Length; i++)
                {
                    var part = parts[i];
                    Control.iter(ExtractDir.Files(part, ExtractExt), f => f.Delete());
                    Control.iter(ParsedDir.Files(part, ParsedExt), f => f.Delete());
                    Control.iter(AsmDir.Files(part, AsmExt), f => f.Delete());
                    Control.iter(HexDir.Files(part, HexExt), f => f.Delete());
                    Control.iter(UnparsedDir.Files(part, UnparsedExt), f => f.Delete());
                }
                return Control.array<FolderPath>();
            }
        }                
        
        [MethodImpl(Inline)]
        IHostCaptureArchive HostArchive(ApiHostUri host)
            => new HostCaptureArchive(RootDir, host);

        FolderName AreaName 
            => FolderName.Empty;

        FolderName SubjectName 
            => FolderName.Empty;

        FolderName RootFolder 
            => FolderName.Define("emissions");

        FolderName ExtractFolder 
            => FolderName.Define("extracted");

        FolderName UnparsedFolder
            => FolderName.Define("unparsed");

        FolderName HexFolder 
            => FolderName.Define("code");

        FolderName ParsedFolder 
            => FolderName.Define("parsed");

        FolderName AsmFolder 
            => FolderName.Define("asm");

        FolderName LogFolder
            => FolderName.Define("logs");

        FolderName ImmRootFolder 
            => FolderName.Define("imm");

        FileExtension ExtractExt 
            => FileExtension.Define($"x.{FileExtensions.Csv}");

        FileExtension ParsedExt 
            => FileExtension.Define($"p.{FileExtensions.Csv}");

        FileExtension UnparsedExt 
            => FileExtension.Define($"u.{FileExtensions.Csv}");

        FolderPath DataRoot 
            => reify(RootDir + RootFolder);

        FolderPath ExtractDir 
            => reify(RootDir + ExtractFolder);

        FolderPath UnparsedDir 
            => reify(RootDir + UnparsedFolder);

        FolderPath ParsedDir 
            => reify(RootDir + ParsedFolder);
        
        FolderPath HexDir 
            => reify(RootDir + HexFolder);
    
        FolderPath AsmDir 
            => reify(RootDir + AsmFolder);

        FolderPath LogDir 
            => reify(RootDir + LogFolder);

        FolderPath ImmRootDir 
            => reify(RootDir + ImmRootFolder);

        FolderPath ImmSubDir(FolderName folder) 
            => reify(ImmRootDir + folder);         

        FolderPath ImmSubDir(RelativeLocation location) 
            => reify(ImmRootDir +  location);

        FileName HexFileName(OpIdentity id) 
            => FileName.Define(id, HexExt);

        FileName CilFileName(OpIdentity id) 
            => FileName.Define(id, CilExt);

        FileName AsmFileName(OpIdentity id) 
            => FileName.Define(id, AsmExt);

        FileName AsmFileName(ApiHostUri host)
            => HostFileName(host,AsmExt);

        FilePath HexImmPath(PartId owner, ApiHostUri host, OpIdentity id)
            => ImmSubDir(RelativeLocation.Define(owner.Format(), host.Name)) + HexFileName(id);

        FilePath AsmImmPath(PartId owner, ApiHostUri host, OpIdentity id)
            => ImmSubDir(RelativeLocation.Define(owner.Format(), host.Name)) + AsmFileName(id);

        FilePath HexPath(FileName fn)
            => HexDir + fn;

        FilePath AsmPath(FileName fn)
            => AsmDir + fn;

        FilePath AsmPath<T>()
            => AsmPath(FileName.Define(typeof(T).Name, AsmExt));

        FilePath HexPath<T>()
            => HexPath(FileName.Define(typeof(T).Name, HexExt));

        FilePath HexPath(ApiHostUri host)
            => HexDir + FileName.Define(host.Name, HexExt);

        FilePath AsmPath(ApiHostUri host)
            => AsmDir + FileName.Define(host.Name, AsmExt);

        FilePath ExtractPath(ApiHostUri host)
            => ExtractDir + FileName.Define(host.Name, ExtractExt);

        FilePath UnparsedPath(ApiHostUri host)
            => UnparsedDir + FileName.Define($"{host.Owner.Format()}.{host.Name}", UnparsedExt);

        FilePath ParsePath(ApiHostUri host)
            => ParsedDir + FileName.Define(host.Name, ParsedExt);

        FilePath LogPath(ApiHostUri host)
            => LogDir + FileName.Define(host.Name, LogExt);

        IEnumerable<FilePath> AsmFiles 
            => AsmDir.Files(AsmExt);  

        IEnumerable<FilePath> HexFiles 
            => HexDir.Files(HexExt);     

        IEnumerable<FilePath> ExtractFiles 
            => ExtractDir.Files(ExtractExt);     

        IEnumerable<FilePath> ParseFiles 
            => ParsedDir.Files(ParsedExt);    

        FolderPath ImmAsmDir 
            => ImmSubDir(AsmFolder);

        FolderPath ImmHexDir 
            => ImmSubDir(HexFolder);

        IEnumerable<FilePath> ImmAsmFiles 
            => ImmAsmDir.Files(AsmExt);

        IEnumerable<FilePath> ImmHexFiles 
            => ImmHexDir.Files(HexExt);
    }
}