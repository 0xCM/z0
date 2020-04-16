//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IApiCodeArchive : ICodeArchive
    {
        FolderPath RootDir {get;}

        FolderName AreaName {get;}

        FolderName SubjectName {get;}

        FolderPath EmissionRoot => (RootDir + AreaName) + SubjectName;

        FolderPath DataRoot => RootDir + RootFolder;

        FolderPath ExtractDir => RootDir + ExtractFolder;

        FolderPath ParsedDir => RootDir + ParsedFolder;
        
        FolderPath HexDir => RootDir + HexFolder;
    
        FolderPath DecodedDir => RootDir + AsmFolder;

        FolderPath LogDir => RootDir + LogFolder;

        FolderPath ImmRootDir => RootDir + ImmRootFolder;

        FolderPath ImmSubDir(FolderName folder) => ImmRootDir + folder;         

        FolderPath ImmSubDir(RelativeLocation location) => ImmRootDir +  location;

        FileName HexFileName(OpIdentity m) => FileName.Define(m, HexExt);

        FileName CilFileName(OpIdentity m) => FileName.Define(m, CilExt);

        FileName AsmFileName(OpIdentity m) => FileName.Define(m, AsmExt);

        FileName AsmFileName(ApiHostUri host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.Name), AsmExt);

        FilePath HexImmPath(PartId origin, ApiHostUri host, OpIdentity id)
            => ImmSubDir(RelativeLocation.Define(origin.Format(), host.Name)) + HexFileName(id);

        FilePath AsmImmPath(PartId origin, ApiHostUri host, OpIdentity id)
            => ImmSubDir(RelativeLocation.Define(origin.Format(), host.Name)) + AsmFileName(id);

        [MethodImpl(Inline)]
        IApiHostArchive HostArchive(ApiHostUri host)
            => ApiHostArchive.Define(this, host);        

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

        IApiCodeArchive Clear()
        {
            ExtractDir.Clear();
            ParsedDir.Clear();
            DecodedDir.Clear();
            HexDir.Clear();
            return this;
        }                        
    }

    public readonly struct ApiCodeArchive : IApiCodeArchive
    {
        public static IApiCodeArchive Default => Define(Env.Current.LogDir);

        [MethodImpl(Inline)]
        public static IApiCodeArchive Define(FolderPath root = null, FolderName area = null, FolderName subject = null)
            => new ApiCodeArchive(root ?? Env.Current.LogDir, area ?? FolderName.Empty, subject ?? FolderName.Empty);
        
        [MethodImpl(Inline)]
        ApiCodeArchive(FolderPath root, FolderName area, FolderName subject)
        {
            this.RootDir = root;
            this.AreaName = area;
            this.SubjectName = subject;
        }

        public FolderPath RootDir {get;}

        public FolderName AreaName {get;}

        public FolderName SubjectName {get;}

    }
}