//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        

    using Ext = FileExtensions;

    public readonly struct AsmEmissionPaths
    {
        public static AsmEmissionPaths Define(FolderPath root  = null)
            => new AsmEmissionPaths(root ?? Env.Current.LogDir);

        readonly FolderPath LogRoot;

        AsmEmissionPaths(FolderPath root)
        {
            this.LogRoot = root;
        }

        FolderName ReportFolder => FolderName.Define($"reports");  
        
        FolderPath ReportRootDir => LogRoot + ReportFolder;

        FolderName DataRootFolder => FolderName.Define("asm");

        FolderPath DataRootDir => LogRoot + DataRootFolder;

        public FolderPath DataSubDir(FolderName folder) => DataRootDir + folder; 

        public FolderPath DataSubDir(RelativeLocation location) => DataRootDir +  location;

        FolderName ExtractFolder => FolderName.Define("extracted");

        public FolderPath ExtractDir => DataSubDir(ExtractFolder);

        public FileExtension ExtractFileExt => FileExtensions.Csv;

        public FileName ExtractFileName(ApiHostUri host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.Name, text.dot(), "extracted"), ExtractFileExt);

        public FilePath ExtractPath(ApiHostUri host) => ExtractDir + ExtractFileName(host);

        FileExtension ParsedExt => FileExtensions.Csv;

        FolderName ParsedFolder => FolderName.Define("parsed");
    
        public FolderPath ParsedDir => DataSubDir(ParsedFolder);
        
        public FileName ParsedFileName(ApiHostUri host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.Name, "parsed"), ParsedExt);
        
        public FilePath ParsedPath(ApiHostUri host) => ParsedDir + ParsedFileName(host);

        FileExtension DecodedExt => FileExtensions.Asm;

        FolderName DecodedFolder => FolderName.Define("decoded");

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

        public FilePath EmissionPath(PartId id, AsmEmissionKind kind)
            => DataRootDir + FolderName.Define($".emissions") 
            + (kind == AsmEmissionKind.Imm 
                    ? FileName.Define($"{id.Format()}-imm", EmissionExt) 
                    : FileName.Define($"{id.Format()}", EmissionExt));                

        FileExtension LocationExt => FileExtensions.Csv;

        FolderName LocationFolder => FolderName.Define("locations"); 

        FolderPath LocationDir =>  ReportRootDir + LocationFolder;

        FileName LocationFileName(ApiHostUri host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dash(), host.Name), LocationExt);

        FileName LocationFileName(PartId assembly) => FileName.Define(assembly.Format(), LocationExt);    

        public FilePath LocationPath(ApiHostUri host) => LocationDir + LocationFileName(host);

        public FilePath LocationPath(PartId assembly) => LocationDir + LocationFileName(assembly);

        FileName HexFileName(OpIdentity m) => FileName.Define(m, Ext.Hex);

        public FilePath HexPath(PartId origin, string host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(origin.Format(), host)) + HexFileName(id);

        public FilePath HexPath(FolderPath dir, OpIdentity m) => dir + HexFileName(m);

        FileName RawFileName(OpIdentity m) => FileName.Define(m, Ext.Raw);

        public FilePath RawPath(PartId origin, string host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(origin.Format(), host)) + RawFileName(id);

        FileName CilFileName(OpIdentity m) => FileName.Define(m, Ext.Il);

        FilePath CilPath(PartId catalog, string host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(catalog.Format(), host)) + CilFileName(id);

        FilePath CilPath(ApiHostUri host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(host.Owner.Format(), host.Name)) + CilFileName(id);

        public FileName DecodedOpFileName(OpIdentity m) => FileName.Define(m, DecodedExt);

        public FilePath DecodedOpPath(PartId origin, string host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(origin.Format(), host)) + DecodedOpFileName(id);

        public FilePath OpArchivePath(ArchiveFileKind kind, PartId origin, string host, OpIdentity id)
            => kind switch {
                ArchiveFileKind.Hex  => HexPath(origin, host, id),
                ArchiveFileKind.Raw  => RawPath(origin, host, id),
                ArchiveFileKind.Asm  => DecodedOpPath(origin, host, id),
                ArchiveFileKind.Cil  => CilPath(origin, host, id),
                _  => FilePath.Empty,
            };
    }
}