//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    using Ext = FileExtensions;

    public readonly struct AsmEmissionPaths
    {
        public static AsmEmissionPaths Current
            => default(AsmEmissionPaths);

        public FolderPath AsmReportRoot
            => Paths.DataDir(FolderName.Define("asm-reports"));

        public FolderPath AsmDataRoot
            => Paths.DataDir(FolderName.Define("asm"));

        public FolderPath AsmDumpDir
            => AsmDataDir(FolderName.Define(".dumps"));
        
        public FolderPath AsmDataDir(FolderName subject)
            => AsmDataRoot + subject; 

        public FolderPath AsmDataDir(RelativeLocation location)
            => AsmDataRoot +  location;

        public FilePath ResourceReport(AssemblyId id)
            => AsmReportRoot + FileName.Define(id.Format(), "csv");              

        public FilePath EmissionReport(AssemblyId id, AsmEmissionKind kind)
            => AsmDataRoot + FolderName.Define(".emissions") 
            + (kind == AsmEmissionKind.Imm 
                    ? FileName.Define($"{id.Format()}-imm", Ext.Csv) 
                    : FileName.Define($"{id.Format()}", Ext.Csv));

        FolderPath CaptureRoot
            =>  AsmReportRoot + FolderName.Define("capture");   

        FolderPath LocationRoot
            =>  AsmReportRoot + FolderName.Define("locations");   

        public FilePath ExtractReport(ApiHost host)
            => CaptureRoot + FileName.Define(concat(host.Owner.Format(), text.dot(), host.HostName, text.dash(), "extract"), Ext.Csv);

        public FilePath LocationReport(ApiHost host)
            => LocationRoot + FileName.Define(concat(host.Owner.Format(), text.dash(), host.HostName), Ext.Csv);

        public FilePath LocationReport(AssemblyId assembly)
            => LocationRoot + FileName.Define(assembly.Format(), Ext.Csv);

        /// <summary>
        /// Returns the path to the hex data file for an identified operation
        /// </summary>
        /// <param name="subject">The assembly log subfolder</param>
        /// <param name="m">The operation identifier</param>
        public FilePath AsmHexPath(FolderPath dir, OpIdentity m)
            => dir + AsmHexFile(m);

        /// <summary>
        /// Returns the path to the hex data file for a specified type and operation name
        /// </summary>
        /// <param name="t">The source type</param>
        /// <param name="m">The operation identifier</param>
        public FilePath AsmHexPath(Type t, OpIdentity m)
            => AsmDataDir(t) + AsmHexFile(m);

        /// <summary>
        /// Returns the path to the dissasembly folder for a specified type
        /// </summary>
        /// <param name="t">The source type</param>
        public FolderPath AsmDataDir(Type t)
            => AsmDataDir(FolderName.Define(t.DisplayName().ToLower()));

        public FolderPath OwnerRoot(AssemblyId owner)
            => AsmDataRoot + FolderName.Define(owner.Format());

        public FilePath ParseReport(ApiHost host)
            => OwnerRoot(host.Owner) + FileName.Define(concat(host.Owner.Format(), text.dot(), host.HostName), Ext.Csv);

        public FilePath DecodedAsmDetail(ApiHost host)
            => OwnerRoot(host.Owner) + FileName.Define(concat(host.Owner.Format(), text.dot(), host.HostName), Ext.Asm);

        public FilePath ArchivePath(ArchiveFileKind kind, AssemblyId origin, string host, OpIdentity id)
            => kind switch {
                ArchiveFileKind.Hex  => HexFilePath(origin, host, id),
                ArchiveFileKind.Raw  => RawFilePath(origin, host, id),
                ArchiveFileKind.Asm  => AsmFilePath(origin, host, id),
                ArchiveFileKind.Cil  => CilFilePath(origin, host, id),
                _  => FilePath.Empty,
            };

        public FilePath ArchivePath(ArchiveFileKind kind, ApiHostPath host, OpIdentity id)
            => kind switch {
                ArchiveFileKind.Hex  => HexFilePath(host, id),
                ArchiveFileKind.Raw  => RawFilePath(host, id),
                ArchiveFileKind.Asm  => AsmFilePath(host, id),
                ArchiveFileKind.Cil  => CilFilePath(host, id),
                _  => FilePath.Empty,
            };

        FileName AsmDetailFile(OpIdentity m)
            => FileName.Define(m, Ext.Asm);

        FileName AsmHexFile(OpIdentity m)
            => FileName.Define(m, Ext.Hex);

        FileName AsmRawFile(OpIdentity m)
            => FileName.Define(m, Ext.Raw);

        FileName CilFile(OpIdentity m)
            => FileName.Define(m, Ext.Il);

        FilePath HexFilePath(AssemblyId origin, string host, OpIdentity id)
            => AsmDataDir(RelativeLocation.Define(origin.Format(), host)) + AsmHexFile(id);

        FilePath RawFilePath(AssemblyId origin, string host, OpIdentity id)
            => AsmDataDir(RelativeLocation.Define(origin.Format(), host)) + AsmRawFile(id);

        FilePath AsmFilePath(AssemblyId origin, string host, OpIdentity id)
            => AsmDataDir(RelativeLocation.Define(origin.Format(), host)) + AsmDetailFile(id);

        FilePath CilFilePath(AssemblyId catalog, string host, OpIdentity id)
            => AsmDataDir(RelativeLocation.Define(catalog.Format(), host)) + CilFile(id);

        FilePath HexFilePath(ApiHostPath host, OpIdentity id)
            => AsmDataDir(RelativeLocation.Define(host.Owner.Format(), host.Name)) + AsmHexFile(id);

        FilePath RawFilePath(ApiHostPath host, OpIdentity id)
            => AsmDataDir(RelativeLocation.Define(host.Owner.Format(), host.Name)) + AsmRawFile(id);

        FilePath AsmFilePath(ApiHostPath host, OpIdentity id)
            => AsmDataDir(RelativeLocation.Define(host.Owner.Format(), host.Name)) + AsmDetailFile(id);

        FilePath CilFilePath(ApiHostPath host, OpIdentity id)
            => AsmDataDir(RelativeLocation.Define(host.Owner.Format(), host.Name)) + CilFile(id);

        /// <summary>
        /// Returns the path to the primary dissasembly file for a specified type and operation name
        /// </summary>
        /// <param name="t">The source type</param>
        /// <param name="m">The operation identifier</param>
        FilePath AsmInfoPath(Type t, OpIdentity m)
            => AsmDataDir(t) + AsmDetailFile(m);

        /// <summary>
        /// Returns the path to the asm info file for an identified operation
        /// </summary>
        /// <param name="subject">The assembly log subfolder</param>
        /// <param name="m">The operation moniker</param>
        FilePath AsmDetailPath(FolderPath dir, OpIdentity m)
            => dir + AsmDetailFile(m);

        /// <summary>
        /// Returns the path to the cil file for an identified operation
        /// </summary>
        /// <param name="subject">The assembly log subfolder</param>
        /// <param name="m">The operation moniker</param>
        FilePath CilPath(FolderPath dir, OpIdentity m)
            => dir + CilFile(m);

        /// <summary>
        /// Returns the path to the hex data file for a specified type and operation name
        /// </summary>
        /// <param name="t">The source type</param>
        /// <param name="m">The operation identifier</param>
        FilePath CilPath(Type t, OpIdentity m)
            => AsmDataDir(t) + CilFile(m);

        /// <summary>
        /// Returns the path to the hex data file for an identified operation
        /// </summary>
        /// <param name="subject">The assembly log subfolder</param>
        /// <param name="m">The operation identifier</param>
        FilePath AsmHexPath(FolderName subject, OpIdentity m)
            => AsmDataDir(subject) + AsmHexFile(m);
    }
}