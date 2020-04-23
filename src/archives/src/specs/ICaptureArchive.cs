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
        /// Obliterates all content in archive-owned directories, returning the obliteration subjects upon completion
        /// </summary>
        FolderPath[] Clear();
        
        ICaptureArchive Narrow(FolderName area, FolderName subject);

        [MethodImpl(Inline)]
        IHostCaptureArchive HostArchive(ApiHostUri host)
            => HostCaptureArchive.Define(this, host);        

        FolderName AreaName => FolderName.Empty;

        FolderName SubjectName => FolderName.Empty;

        FolderName RootFolder 
            => FolderName.Define("emissions");

        FolderName ExtractFolder 
            => FolderName.Define("extracted");
        
        FolderName HexFolder 
            => FolderName.Define("code");

        FolderName ParsedFolder 
            => FolderName.Define("parsed");

        FolderName AsmFolder 
            => FolderName.Define("asm");

        FolderName LogFolder
            => FolderName.Define("logs");

        FolderName ReportFolder 
            => FolderName.Define($"reports");  

        FolderName ImmRootFolder 
            => FolderName.Define("imm");

        FileExtension ExtractExt => FileExtension.Define($"x.{FileExtensions.Csv}");

        FileExtension ParsedExt => FileExtension.Define($"p.{FileExtensions.Csv}");

        FileExtension HexExt => FileExtensions.Hex;

        FileExtension AsmExt => FileExtensions.Asm;

        FileExtension CilExt => FileExtensions.Il;

        FolderPath RootDir {get;}

        FolderPath DataRoot => reify(RootDir + RootFolder);

        FolderPath ExtractDir => reify(RootDir + ExtractFolder);

        FolderPath ParsedDir => reify(RootDir + ParsedFolder);
        
        FolderPath HexDir => reify(RootDir + HexFolder);
    
        FolderPath AsmDir => reify(RootDir + AsmFolder);

        FolderPath LogDir => reify(RootDir + LogFolder);

        FolderPath ImmRootDir => reify(RootDir + ImmRootFolder);

        FolderPath ImmSubDir(FolderName folder) => reify(ImmRootDir + folder);         

        FolderPath ImmSubDir(RelativeLocation location) => reify(ImmRootDir +  location);

        FileName HexFileName(OpIdentity m) => FileName.Define(m, HexExt);

        FileName CilFileName(OpIdentity m) => FileName.Define(m, CilExt);

        FileName AsmFileName(OpIdentity m) => FileName.Define(m, AsmExt);

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

        FolderPath DataSubDir(RelativeLocation location) => DataRoot +  location;

        FilePath HexPath(PartId origin, ApiHostUri host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(origin.Format(), host.Name)) + HexFileName(id);

        FilePath AsmPath(PartId origin, ApiHostUri host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(origin.Format(), host.Name)) + AsmFileName(id);

        FilePath CilPath(PartId catalog, ApiHostUri host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(catalog.Format(), host.Name)) + CilFileName(id);

        FilePath OpArchivePath(ArchiveFileKind kind, PartId origin, ApiHostUri host, OpIdentity id, bool imm)
            => kind switch {
                ArchiveFileKind.Hex  => imm ? HexImmPath(origin,host,id) : HexPath(origin, host, id),
                ArchiveFileKind.Asm  =>  imm ? AsmImmPath(origin,host,id) : AsmPath(origin, host, id),
                ArchiveFileKind.Cil  => CilPath(origin, host, id),
                _  => FilePath.Empty,
            };

        IEnumerable<FilePath> AsmFiles => AsmDir.Files(AsmExt);  

        IEnumerable<FilePath> HexFiles => HexDir.Files(HexExt);     

        IEnumerable<FilePath> ExtractFiles => ExtractDir.Files(ExtractExt);     

        IEnumerable<FilePath> ParseFiles => ParsedDir.Files(ParsedExt);    

        FolderPath ImmAsmDir => ImmSubDir(AsmFolder);

        FolderPath ImmHexDir => ImmSubDir(HexFolder);

        IEnumerable<FilePath> ImmAsmFiles => ImmAsmDir.Files(AsmExt);

        IEnumerable<FilePath> ImmHexFiles => ImmHexDir.Files(HexExt);
    }
}