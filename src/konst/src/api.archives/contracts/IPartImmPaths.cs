//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Linq;

    public interface IPartImmPaths : IPartFilePaths
    {
        FolderPath ImmRootDirPath(FolderPath root)
            => (root + ImmFolder).Create();

        /// <summary>
        /// The imm root directory path
        /// </summary>
        FolderPath ImmRoot
            => ImmRootDirPath(ArchiveRoot);

        /// <summary>
        /// Nonrecursively enumerates directory paths owned by a specified part
        /// </summary>
        /// <param name="part">The owning part</param>
        /// <param name="ext">The extension to match</param>
        FolderPath[] ImmDirs(PartId part)
            => ImmRoot.SubDirs.Where(d => d.Name.EndsWith(part.Format()));

        FolderPath[] ImmHostDirs(PartId part)
            => ImmDirs(part).SelectMany(path => path.SubDirs).ToArray();

        FolderPath[] ImmHostDirs(params PartId[] parts)
            => parts.SelectMany(ImmHostDirs).ToArray();

        FolderPath ImmSubDir(RelativeLocation name)
            => (ImmRoot +  name);

        FilePath HexImmPath(PartId owner, ApiHostUri host, OpIdentity id)
            => ImmSubDir(RelativeLocation.Define(owner.Format(), host.Name)) + HexOpFileName(id);

        FilePath AsmImmPath(PartId owner, ApiHostUri host, OpIdentity id)
            => ImmSubDir(RelativeLocation.Define(owner.Format(), host.Name)) + AsmFileName(id);
    }
}