//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static ArchiveFolderNames;

    using L = ArchiveFolderNames;

    /// <summary>
    /// Defines common part path components
    /// </summary>
    public interface IPartFolderNames
    {

        FolderName ExtractFolderName
            => FolderName.Define("extracted", "Raw binary extracts");

        FolderName ParsedFolderName
            => FolderName.Define(Parsed);

        FolderName AsmFolderName
            => FolderName.Define(L.AsmFolder);

        FolderName X86FolderName
            => FolderName.Define("code", "Hex formatted encoded x86 assembly");

        FolderName CilFolderName
            => FolderName.Define(CilData);

        /// <summary>
        /// The imm root folder name
        /// </summary>
        FolderName ImmFolderName
            => FolderName.Define(ImmFolder);

        /// <summary>
        /// Defines a part-specific folder name {part}
        /// </summary>
        /// <param name="part">The source part</param>
        FolderName PartFolderName(PartId part)
            => FolderName.Define(part);
    }
}