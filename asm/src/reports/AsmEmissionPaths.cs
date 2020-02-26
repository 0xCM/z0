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

        const string EmissionIndicator = "emissions";

        const string EmissionImmSuffix = "imm";

        const string SummaryIndicator = "summary";

        const string ReportsIndicator = "reports";

        public FolderName ReportFolder => FolderName.Define($"{AsmIndicator}{IndicatorPrefix}{ReportsIndicator}");  
        
        public FolderPath ReportRootDir => Paths.DataDir(ReportFolder);

        public FolderName DataRootFolder => FolderName.Define(AsmIndicator);

        public FolderPath DataRootDir => Paths.DataDir(DataRootFolder);
        
        public FolderPath AsmDataDir(FolderName folder) => DataRootDir + folder; 

        public FolderPath AsmDataDir(RelativeLocation location) => DataRootDir +  location;

        public FolderName DataFolderName(AssemblyId owner) => FolderName.Define(owner.Format());

        public FolderPath DataFolderDir(AssemblyId owner) => DataRootDir + DataFolderName(owner);

        public FolderPath AsmDumpDir => AsmDataDir(FolderName.Define($"{IndicatorPrefix}dumps"));

        public FileExtension ResourceExt => FileExtensions.Csv;

        public FilePath ResourcePath(AssemblyId id) => ReportRootDir + FileName.Define(id.Format(), ResourceExt);              

        public FileExtension EmissionExt => FileExtensions.Csv;

        public FilePath EmissionPath(AssemblyId id, AsmEmissionKind kind)
            => DataRootDir + FolderName.Define($"{IndicatorPrefix}{EmissionIndicator}") 
            + (kind == AsmEmissionKind.Imm 
                    ? FileName.Define($"{id.Format()}{SuffixSep}{EmissionImmSuffix}", EmissionExt) 
                    : FileName.Define($"{id.Format()}", EmissionExt));                

        public FolderName CaptureSummaryFolder => FolderName.Define($"{IndicatorPrefix}{SummaryIndicator}");

        public FolderPath CaptureSummaryDir => DataRootDir + CaptureSummaryFolder;

        public FileExtension CaptureSummaryExt => FileExtensions.Csv;

        public FileName CaptureSummaryFileName(ApiHost host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.HostName, IndicatorPrefix, SummaryIndicator), CaptureSummaryExt);
        
        public FilePath CaptureSummaryPath(ApiHost host) => CaptureSummaryDir + CaptureSummaryFileName(host);

        public FileExtension LocationExt => FileExtensions.Csv;

        public FolderName LocationFolder => FolderName.Define("locations"); 

        public FolderPath LocationDir =>  ReportRootDir + LocationFolder;

        public FileName LocationFileName(ApiHost host)
            => FileName.Define(text.concat(host.Owner.Format(), SuffixSep, host.HostName), LocationExt);

        public FileName LocationFileName(AssemblyId assembly) => FileName.Define(assembly.Format(), LocationExt);    

        public FilePath LocationPath(ApiHost host) => LocationDir + LocationFileName(host);

        public FilePath LocationPath(AssemblyId assembly) => LocationDir + LocationFileName(assembly);

        public FileExtension ParsedExt => FileExtensions.Csv;

        public FileName ParsedFileName(ApiHost host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.HostName), ParsedExt);
        
        public FilePath ParsedPath(ApiHost host) => DataFolderDir(host.Owner) + ParsedFileName(host);

        public FileExtension DetailExt => FileExtensions.Asm;

        public FileName DetailFileName(OpIdentity m) => FileName.Define(m, DetailExt);

        public FileName DetailFileName(ApiHost host)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.HostName), DetailExt);
        
        public FilePath DetailPath(ApiHost host) => DataFolderDir(host.Owner) + DetailFileName(host);

        public FilePath DetailPath(AssemblyId origin, string host, OpIdentity id)
            => AsmDataDir(RelativeLocation.Define(origin.Format(), host)) + DetailFileName(id);

        public FilePath DetailPath(ApiHostPath host, OpIdentity id)
            => AsmDataDir(RelativeLocation.Define(host.Owner.Format(), host.Name)) + DetailFileName(id);

        public FileName HexFileName(OpIdentity m) => FileName.Define(m, Ext.Hex);

        public FilePath HexPath(AssemblyId origin, string host, OpIdentity id)
            => AsmDataDir(RelativeLocation.Define(origin.Format(), host)) + HexFileName(id);

        public FilePath HexPath(ApiHostPath host, OpIdentity id)
            => AsmDataDir(RelativeLocation.Define(host.Owner.Format(), host.Name)) + HexFileName(id);

        /// <summary>
        /// Returns the path to the hex data file for an identified operation
        /// </summary>
        /// <param name="subject">The assembly log subfolder</param>
        /// <param name="m">The operation identifier</param>
        public FilePath HexPath(FolderPath dir, OpIdentity m) => dir + HexFileName(m);

        public FileName RawFileName(OpIdentity m) => FileName.Define(m, Ext.Raw);

        public FilePath RawPath(AssemblyId origin, string host, OpIdentity id)
            => AsmDataDir(RelativeLocation.Define(origin.Format(), host)) + RawFileName(id);

        public FilePath RawFilePath(ApiHostPath host, OpIdentity id)
            => AsmDataDir(RelativeLocation.Define(host.Owner.Format(), host.Name)) + RawFileName(id);

        public FileName CilFileName(OpIdentity m) => FileName.Define(m, Ext.Il);

        public FilePath CilPath(AssemblyId catalog, string host, OpIdentity id)
            => AsmDataDir(RelativeLocation.Define(catalog.Format(), host)) + CilFileName(id);

        public FilePath CilPath(ApiHostPath host, OpIdentity id)
            => AsmDataDir(RelativeLocation.Define(host.Owner.Format(), host.Name)) + CilFileName(id);

        public FilePath ArchivePath(ArchiveFileKind kind, AssemblyId origin, string host, OpIdentity id)
            => kind switch {
                ArchiveFileKind.Hex  => HexPath(origin, host, id),
                ArchiveFileKind.Raw  => RawPath(origin, host, id),
                ArchiveFileKind.Asm  => DetailPath(origin, host, id),
                ArchiveFileKind.Cil  => CilPath(origin, host, id),
                _  => FilePath.Empty,
            };

        public FilePath ArchivePath(ArchiveFileKind kind, ApiHostPath host, OpIdentity id)
            => kind switch {
                ArchiveFileKind.Hex  => HexPath(host, id),
                ArchiveFileKind.Raw  => RawFilePath(host, id),
                ArchiveFileKind.Asm  => DetailPath(host, id),
                ArchiveFileKind.Cil  => CilPath(host, id),
                _  => FilePath.Empty,
            };
    }
}