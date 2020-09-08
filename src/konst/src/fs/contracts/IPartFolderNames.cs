//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static FS.FolderNames;
    using L = FS.FolderNames;

    /// <summary>
    /// Defines common part path components
    /// </summary>
    public interface IPartFolderNames
    {
        /// <summary>
        /// An archive partition for files emitted during test execution
        /// </summary>
        FolderName TestFolder
            => FolderName.Define(Test);

        /// <summary>
        /// An archive partition for static data
        /// </summary>
        FolderName LogsFolder
            => FolderName.Define(Logs);

        /// <summary>
        /// Part folder name predicated on the entry assembly
        /// </summary>
        FolderName ShellFolder
            => FolderName.Define(Part.ExecutingPart);

        FolderName ExtractFolderName
            => FolderName.Define("extracted", "Raw binary extracts");

        FolderName ParsedFolderName
            => FolderName.Define(Parsed);

        FolderName UnparsedFolderName
            => FolderName.Define("unparsed", "Extraction parse failures");

        FolderName AsmFolderName
            => FolderName.Define(L.Asm);

        FolderName HexFolderName
            => FolderName.Define("code", "Hex formatted encoded x86 assembly");

        FolderName CilDataFolderName
            => FolderName.Define(CilData);

        /// <summary>
        /// The imm root folder name
        /// </summary>
        FolderName ImmFolderName
            => FolderName.Define(Imm);

        /// <summary>
        /// Defines a part-specific folder name {part}
        /// </summary>
        /// <param name="part">The source part</param>
        FolderName PartFolderName(PartId part)
            => FolderName.Define(part);

        /// <summary>
        /// Defines a host-specific folder name {host.Name}
        /// </summary>
        /// <param name="part">The source part</param>
        FolderName HostFolderName(ApiHostUri host)
            => FolderName.Define(host);
    }
}