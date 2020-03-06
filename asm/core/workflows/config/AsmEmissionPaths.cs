//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using Ext = FileExtensions;

    public readonly struct AsmEmissionPaths
    {
        static LogPaths Paths => LogPaths.The;

        public static AsmEmissionPaths Current => default(AsmEmissionPaths);

        public const char SuffixSep = '-';

        const string IndicatorPrefix = ".";

        const string AsmIndicator = "asm";

        const string CaptureWorkflow = "captured";

        const string ExtractWorkflow = "extracted";

        const string ParseWorkflow = "parsed";

        const string DecodeWorkflow = "decoded";

        const string ReportsIndicator = "reports";

        const string EmissionIndicator = "emissions";

        const string EmissionImmSuffix = "imm";

        public FolderName Folder(AssemblyId owner) => FolderName.Define(owner.Format());

        public FolderName ReportFolder => FolderName.Define($"{AsmIndicator}{IndicatorPrefix}{ReportsIndicator}");  
        
        public FolderPath ReportRootDir => Paths.DataDir(ReportFolder);

        public FolderName DataRootFolder => FolderName.Define(AsmIndicator);

        public FolderPath DataRootDir => Paths.DataDir(DataRootFolder);

        public FolderPath DataSubDir(FolderName folder) => DataRootDir + folder; 

        public FolderPath DataSubDir(RelativeLocation location) => DataRootDir +  location;

        public FolderName ExtractFolder => FolderName.Define(ExtractWorkflow);

        public FolderPath ExtractDir => DataSubDir(ExtractFolder);

        public FileExtension ExtractFileExt => FileExtensions.Csv;

        public FileName ExtractFileName(ApiHostUri host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.Name, IndicatorPrefix, ExtractWorkflow), ExtractFileExt);

        public FilePath ExtractPath(ApiHostUri host) => ExtractDir + ExtractFileName(host);

        public FileExtension ParsedExt => FileExtensions.Csv;

        public FolderName ParsedFolder => FolderName.Define(ParseWorkflow);
    
        public FolderPath ParsedDir => DataSubDir(ParsedFolder);
        
        public FileName ParsedFileName(ApiHostUri host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.Name, ParseWorkflow), ParsedExt);
        
        public FilePath ParsedPath(ApiHostUri host) => ParsedDir + ParsedFileName(host);

        public FileExtension DecodedExt => FileExtensions.Asm;

        public FolderName DecodedFolder => FolderName.Define(DecodeWorkflow);

        public FolderPath DecodedDir => DataSubDir(DecodedFolder);
        
        public FileName DecodedFileName(ApiHostUri host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.Name), DecodedExt);

        public FilePath DecodedPath(ApiHostUri host) => DecodedDir + DecodedFileName(host);

        public FolderPath CilDir => DecodedDir;

        public FileExtension CilExt => FileExtensions.Il;

        public FileName CilFileName(ApiHostUri host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.Name), CilExt);

        public FilePath CilPath(ApiHostUri host) => CilDir + CilFileName(host);

        public FolderPath AsmDumpDir => DataSubDir(FolderName.Define($"{IndicatorPrefix}dumps"));

        public FileExtension ResourceExt => FileExtensions.Csv;

        public FilePath ResourcePath(AssemblyId id) => ReportRootDir + FileName.Define(id.Format(), ResourceExt);              

        public FileExtension EmissionExt => FileExtensions.Csv;

        public FilePath EmissionPath(AssemblyId id, AsmEmissionKind kind)
            => DataRootDir + FolderName.Define($"{IndicatorPrefix}{EmissionIndicator}") 
            + (kind == AsmEmissionKind.Imm 
                    ? FileName.Define($"{id.Format()}{SuffixSep}{EmissionImmSuffix}", EmissionExt) 
                    : FileName.Define($"{id.Format()}", EmissionExt));                

        public FileExtension LocationExt => FileExtensions.Csv;

        public FolderName LocationFolder => FolderName.Define("locations"); 

        public FolderPath LocationDir =>  ReportRootDir + LocationFolder;

        public FileName LocationFileName(ApiHostUri host)
            => FileName.Define(text.concat(host.Owner.Format(), SuffixSep, host.Name), LocationExt);

        public FileName LocationFileName(AssemblyId assembly) => FileName.Define(assembly.Format(), LocationExt);    

        public FilePath LocationPath(ApiHostUri host) => LocationDir + LocationFileName(host);

        public FilePath LocationPath(AssemblyId assembly) => LocationDir + LocationFileName(assembly);

        public FileName HexFileName(OpIdentity m) => FileName.Define(m, Ext.Hex);

        public FilePath HexPath(AssemblyId origin, string host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(origin.Format(), host)) + HexFileName(id);

        public FilePath HexPath(ApiHostUri host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(host.Owner.Format(), host.Name)) + HexFileName(id);

        public FilePath HexPath(FolderPath dir, OpIdentity m) => dir + HexFileName(m);

        public FileName RawFileName(OpIdentity m) => FileName.Define(m, Ext.Raw);

        public FilePath RawPath(AssemblyId origin, string host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(origin.Format(), host)) + RawFileName(id);

        public FilePath RawFilePath(ApiHostUri host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(host.Owner.Format(), host.Name)) + RawFileName(id);

        public FileName CilFileName(OpIdentity m) => FileName.Define(m, Ext.Il);

        public FilePath CilPath(AssemblyId catalog, string host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(catalog.Format(), host)) + CilFileName(id);

        public FilePath CilPath(ApiHostUri host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(host.Owner.Format(), host.Name)) + CilFileName(id);

        public FileName DecodedOpFileName(OpIdentity m) => FileName.Define(m, DecodedExt);

        public FilePath DecodedOpPath(AssemblyId origin, string host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(origin.Format(), host)) + DecodedOpFileName(id);

        public FilePath DecodedOpPath(ApiHostUri host, OpIdentity id)
            => DataSubDir(RelativeLocation.Define(host.Owner.Format(), host.Name)) + DecodedOpFileName(id);

        public FilePath OpArchivePath(ArchiveFileKind kind, AssemblyId origin, string host, OpIdentity id)
            => kind switch {
                ArchiveFileKind.Hex  => HexPath(origin, host, id),
                ArchiveFileKind.Raw  => RawPath(origin, host, id),
                ArchiveFileKind.Asm  => DecodedOpPath(origin, host, id),
                ArchiveFileKind.Cil  => CilPath(origin, host, id),
                _  => FilePath.Empty,
            };
    }
}