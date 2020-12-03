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
        FS.FolderName ParsedFolderName
            => FS.folder(Parsed);

        FS.FolderName AsmFolderName
            => FS.folder(Asm);

        FS.FolderName AsmSemanticFolder
            => FS.folder(AsmSemantic);

        FS.FolderName X86FolderName
            => FS.folder(L.Hex);

        FS.FolderName CilFolderName
            => FS.folder(CilData);

        /// <summary>
        /// The imm root folder name
        /// </summary>
        FS.FolderName ImmFolder
            => FS.folder(Imm);

        /// <summary>
        /// Defines a part-specific folder name {part}
        /// </summary>
        /// <param name="part">The source part</param>
        FS.FolderName PartFolderName(PartId part)
            => FolderName.Define(part);
    }
}