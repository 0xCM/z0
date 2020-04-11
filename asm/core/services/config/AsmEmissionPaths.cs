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
        readonly FolderPath EmissionRoot;

        public static AsmEmissionPaths Default => Define(Env.Current.LogDir);
        
        [MethodImpl(Inline)]
        public static AsmEmissionPaths Define(FolderPath root  = null)
            => new AsmEmissionPaths(root ?? Env.Current.LogDir);

        [MethodImpl(Inline)]
        public AsmEmissionPaths Rooted(FolderPath root)
            => new AsmEmissionPaths(root);

        [MethodImpl(Inline)]
        AsmEmissionPaths(FolderPath root)
        {
            EmissionRoot = root;
        }

        FolderName DataRootFolder => FolderName.Define("asm");

        FolderName ReportFolder => FolderName.Define($"reports");  

        FolderName ImmRootFolder => FolderName.Define("imm");

        FolderName ExtractFolder => FolderName.Define("extracted");

        FolderName ParsedFolder => FolderName.Define("parsed");
    
        FolderName DecodedFolder => FolderName.Define("decoded");

        FolderPath ReportRootDir => EmissionRoot + ReportFolder;

        FolderPath DataRootDir => EmissionRoot + DataRootFolder;

        public FolderPath DataSubDir(FolderName folder) => DataRootDir + folder;         

        public FolderPath DataSubDir(RelativeLocation location) => DataRootDir +  location;

        public FolderPath ImmRootDir => EmissionRoot + ImmRootFolder;

        public FolderPath ImmSubDir(FolderName folder) => ImmRootDir + folder;         

        public FolderPath ImmSubDir(RelativeLocation location) => ImmRootDir +  location;

        public FolderPath ExtractDir => DataSubDir(ExtractFolder);

        public FileExtension ExtractFileExt => FileExtensions.Csv;

        public FileName ExtractFileName(ApiHostUri host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.Name, text.dot(), "extracted"), ExtractFileExt);

        public FilePath ExtractPath(ApiHostUri host) => ExtractDir + ExtractFileName(host);

        FileExtension ParsedExt => FileExtensions.Csv;

        public FolderPath ParsedDir => DataSubDir(ParsedFolder);
        
        public FileName ParsedFileName(ApiHostUri host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.Name, "parsed"), ParsedExt);
        
        public FilePath ParsedPath(ApiHostUri host) => ParsedDir + ParsedFileName(host);

        FileExtension DecodedExt => FileExtensions.Asm;

        public FolderPath DecodedDir => DataSubDir(DecodedFolder);
        
        public FileName DecodedFileName(ApiHostUri host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.Name), DecodedExt);

        public FilePath DecodedPath(ApiHostUri host) => DecodedDir + DecodedFileName(host);

        public FolderPath CilDir => DecodedDir;

        FileExtension CilExt => FileExtensions.Il;

        FileName CilFileName(ApiHostUri host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.Name), CilExt);

        public FilePath CilPath(ApiHostUri host) => CilDir + CilFileName(host);

        FileExtension ResourceExt => FileExtensions.Csv;

        public FilePath ResourcePath(PartId id) => ReportRootDir + FileName.Define(id.Format(), ResourceExt);              

        FileExtension EmissionExt => FileExtensions.Csv;

        FileExtension LocationExt => FileExtensions.Csv;

        FolderName LocationFolder => FolderName.Define("locations"); 

        FolderPath LocationDir =>  ReportRootDir + LocationFolder;

        FileName LocationFileName(ApiHostUri host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dash(), host.Name), LocationExt);

        FileName LocationFileName(PartId assembly) => FileName.Define(assembly.Format(), LocationExt);    

        public FilePath LocationPath(ApiHostUri host) => LocationDir + LocationFileName(host);

        public FilePath LocationPath(PartId assembly) => LocationDir + LocationFileName(assembly);

        FileName HexFileName(OpIdentity m) => FileName.Define(m, Ext.Hex);
        
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

        public FilePath HexPath(FolderPath dir, OpIdentity m) => dir + HexFileName(m);

        FileName RawFileName(OpIdentity m) => FileName.Define(m, Ext.Raw);

        FileName CilFileName(OpIdentity m) => FileName.Define(m, Ext.Il);

        FilePath CilPath(PartId catalog, ApiHostUri host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(catalog.Format(), host.Name)) + CilFileName(id);

        FilePath CilPath(ApiHostUri host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(host.Owner.Format(), host.Name)) + CilFileName(id);

        public FileName DecodedOpFileName(OpIdentity m) => FileName.Define(m, DecodedExt);

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