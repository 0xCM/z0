//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using Ext = FileExtensions;

    public readonly struct AsmEmissionPaths
    {
        public static AsmEmissionPaths Default => Define(Env.Current.LogDir);

        public FolderPath RootDir {get;}

        public FolderName AreaName {get;}

        public FolderName SubjectName {get;}
        
        [MethodImpl(Inline)]
        public static AsmEmissionPaths Define(FolderPath root  = null)
            => new AsmEmissionPaths(root ?? Env.Current.LogDir);

        [MethodImpl(Inline)]
        public AsmEmissionPaths Subject(FolderName area, FolderName subject)
            => new AsmEmissionPaths(Env.Current.LogDir, area, subject);

        [MethodImpl(Inline)]
        AsmEmissionPaths(FolderPath root, FolderName area = null, FolderName subject = null)
        {
            RootDir = root;
            AreaName = area ?? FolderName.Empty;
            SubjectName = subject ?? FolderName.Empty;
        }

        FolderName RootFolder => FolderName.Define("emissions");

        FolderPath DataRoot => RootDir + RootFolder;

        public FolderPath EmissionRoot => (RootDir + AreaName) + SubjectName;

        public FolderName ImmRootFolder => FolderName.Define("imm");

        public FolderName ExtractFolder => FolderName.Define("extracted");

        public FolderName ParsedFolder => FolderName.Define("parsed");                    

        public FolderName ReportFolder => FolderName.Define($"reports");  

        public FolderPath ReportRoot => RootDir + ReportFolder;

        public FolderPath ExtractDir => EmissionRoot + ExtractFolder;

        public FolderPath DataSubDir(FolderName folder) => DataRoot + folder;         

        public FolderPath DataSubDir(RelativeLocation location) => DataRoot +  location;

        public FolderPath ImmRootDir => RootDir + ImmRootFolder;

        public FolderPath ImmSubDir(RelativeLocation location) => ImmRootDir +  location;

        public FileExtension ExtractExt => FileExtensions.Csv;

        public FileName ExtractFileName(ApiHostUri host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.Name, text.dot(), "extracted"), ExtractExt);

        public FilePath ExtractPath(ApiHostUri host) => ExtractDir + ExtractFileName(host);

        public FileExtension ParsedExt => FileExtensions.Csv;

        public FolderPath ParsedDir => EmissionRoot + ParsedFolder;

        public FileName ParsedFileName(ApiHostUri host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.Name, "parsed"), ParsedExt);

        public FilePath ParsedPath(ApiHostUri host) => ParsedDir + ParsedFileName(host);

        public FolderName CodeFolder => FolderName.Define("code");

        public FolderPath CodeDir => EmissionRoot + CodeFolder;

        public FileExtension CodeExt => FileExtensions.Hex;

        public FileName CodeFileName(ApiHostUri host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.Name), CodeExt);

        public FilePath CodePath(ApiHostUri host) => CodeDir + CodeFileName(host);

        public FolderName AsmFolder => FolderName.Define("asm");

        public FileExtension AsmExt => FileExtensions.Asm;

        public FolderPath AsmDir =>  EmissionRoot +  AsmFolder;
        

        public FilePath DecodedPath(ApiHostUri host) => AsmDir + AsmFileName(host);

        FileExtension ResourceExt => FileExtensions.Csv;

        public FilePath ResourcePath(PartId id) => ReportRoot + FileName.Define(id.Format(), ResourceExt);              

        FileExtension LocationExt => FileExtensions.Csv;

        FolderName LocationFolder => FolderName.Define("locations"); 

        FolderPath LocationDir =>  ReportRoot + LocationFolder;

        FileName LocationFileName(ApiHostUri host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dash(), host.Name), LocationExt);

        FileName LocationFileName(PartId assembly) => FileName.Define(assembly.Format(), LocationExt);    

        public FilePath LocationPath(ApiHostUri host) => LocationDir + LocationFileName(host);

        public FilePath LocationPath(PartId assembly) => LocationDir + LocationFileName(assembly);


        public FilePath HexPath(PartId origin, ApiHostUri host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(origin.Format(), host.Name)) + HexFileName(id);

        public FilePath HexImmPath(PartId origin, ApiHostUri host, OpIdentity id)
            => ImmSubDir(RelativeLocation.Define(origin.Format(), host.Name)) + HexFileName(id);

        public FilePath AsmImmPath(PartId origin, ApiHostUri host, OpIdentity id)
            => ImmSubDir(RelativeLocation.Define(origin.Format(), host.Name)) + DecodedOpFileName(id);

        public FolderPath HexRootDir(PartId part, ApiHostUri host, bool imm)
            => imm ? ImmSubDir(RelativeLocation.Define(part.Format(), host.Name)) : DataSubDir(RelativeLocation.Define(part.Format(), host.Name));

        public FolderPath AsmRootDir(PartId part, ApiHostUri host, bool imm)
            => imm ? ImmSubDir(RelativeLocation.Define(part.Format(), host.Name)) : DataSubDir(RelativeLocation.Define(part.Format(), host.Name));

        FileName HexFileName(OpIdentity m) => FileName.Define(m, Ext.Hex);

        FileName CilFileName(OpIdentity m) => FileName.Define(m, Ext.Il);

        FilePath CilPath(PartId catalog, ApiHostUri host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(catalog.Format(), host.Name)) + CilFileName(id);

        public FileName AsmFileName(ApiHostUri host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.Name), AsmExt);

        public FileName DecodedOpFileName(OpIdentity m) => FileName.Define(m, AsmExt);

        public FilePath AsmPath(PartId origin, ApiHostUri host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(origin.Format(), host.Name)) + DecodedOpFileName(id);

        public FilePath OpArchivePath(ArchiveFileKind kind, PartId origin, ApiHostUri host, OpIdentity id, bool imm)
            => kind switch {
                ArchiveFileKind.Hex  => imm ? HexImmPath(origin,host,id) : HexPath(origin, host, id),
                ArchiveFileKind.Asm  =>  imm ? AsmImmPath(origin,host,id) : AsmPath(origin, host, id),
                ArchiveFileKind.Cil  => CilPath(origin, host, id),
                _  => FilePath.Empty,
            };
    }
}