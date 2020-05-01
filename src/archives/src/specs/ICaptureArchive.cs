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

    using static FileSystem;

    public interface ICaptureArchive : IService
    {
        /// <summary>
        /// The folder to which all path calculation is relative
        /// </summary>
        FolderPath RootDir {get;}

        FolderName AreaName => FolderName.Empty;

        FolderName SubjectName => FolderName.Empty;

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

        FileExtension ExtractExt => FileExtension.Define($"x.{FileExtensions.Csv}");

        FileExtension ParsedExt => FileExtension.Define($"p.{FileExtensions.Csv}");

        FileExtension UnparsedExt => FileExtension.Define($"u.{FileExtensions.Csv}");

        FileExtension HexExt => FileExtensions.Hex;

        FileExtension AsmExt => FileExtensions.Asm;

        FileExtension CilExt => FileExtensions.Il;

        FileExtension LogExt => FileExtensions.Log;

        FolderPath DataRoot => reify(RootDir + RootFolder);

        FolderPath ExtractDir => reify(RootDir + ExtractFolder);

        FolderPath UnparsedDir => reify(RootDir + UnparsedFolder);

        FolderPath ParsedDir => reify(RootDir + ParsedFolder);
        
        FolderPath HexDir => reify(RootDir + HexFolder);
    
        FolderPath AsmDir => reify(RootDir + AsmFolder);

        FolderPath LogDir => reify(RootDir + LogFolder);

        FolderPath ImmRootDir => reify(RootDir + ImmRootFolder);

        FolderPath ImmSubDir(FolderName folder) => reify(ImmRootDir + folder);         

        FolderPath ImmSubDir(RelativeLocation location) => reify(ImmRootDir +  location);

        FileName HexFileName(OpIdentity m) 
            => FileName.Define(m, HexExt);

        FileName CilFileName(OpIdentity m) 
            => FileName.Define(m, CilExt);

        FileName AsmFileName(OpIdentity m) 
            => FileName.Define(m, AsmExt);

        FileName AsmFileName(ApiHostUri host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.Name), AsmExt);

        FilePath HexImmPath(PartId origin, ApiHostUri host, OpIdentity id)
            => ImmSubDir(RelativeLocation.Define(origin.Format(), host.Name)) + HexFileName(id);

        FilePath AsmImmPath(PartId origin, ApiHostUri host, OpIdentity id)
            => ImmSubDir(RelativeLocation.Define(origin.Format(), host.Name)) + AsmFileName(id);

        FilePath HexPath(FileName filename)
            => HexDir + filename;

        FilePath AsmPath(FileName filename)
            => AsmDir + filename;

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

        IEnumerable<FilePath> AsmFiles => AsmDir.Files(AsmExt);  

        IEnumerable<FilePath> HexFiles => HexDir.Files(HexExt);     

        IEnumerable<FilePath> ExtractFiles => ExtractDir.Files(ExtractExt);     

        IEnumerable<FilePath> ParseFiles => ParsedDir.Files(ParsedExt);    

        FolderPath ImmAsmDir => ImmSubDir(AsmFolder);

        FolderPath ImmHexDir => ImmSubDir(HexFolder);

        IEnumerable<FilePath> ImmAsmFiles => ImmAsmDir.Files(AsmExt);

        IEnumerable<FilePath> ImmHexFiles => ImmHexDir.Files(HexExt);

        /// <summary>
        /// Obliterates all content in archive-owned directories, returning the obliteration subjects upon completion
        /// </summary>
        FolderPath[] Clear(params PartId[] parts);
        
        ICaptureArchive Narrow(FolderName area, FolderName subject);

        [MethodImpl(Inline)]
        IHostCaptureArchive CaptureArchive(ApiHostUri host)
            => Archives.Services.HostCaptureArchive(this, host);        
    }
}