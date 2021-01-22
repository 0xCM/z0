//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Linq;

    public interface IPartImmPaths : IPartFilePaths
    {
        /// <summary>
        /// The imm root directory path
        /// </summary>
        FS.FolderPath ImmRoot
            => FS.dir(Root.Name);

        /// <summary>
        /// Nonrecursively enumerates directory paths owned by a specified part
        /// </summary>
        /// <param name="part">The owning part</param>
        /// <param name="ext">The extension to match</param>
        FS.FolderPath[] ImmDirs(PartId part)
            => ImmRoot.SubDirs().Where(d => d.Name.EndsWith(part.Format()));

        FS.FolderPath[] ImmHostDirs(PartId part)
            => ImmDirs(part).SelectMany(path => path.SubDirs());

        FS.FolderPath[] ImmHostDirs(params PartId[] parts)
            => parts.SelectMany(ImmHostDirs).ToArray();

        FS.FolderPath ImmSubDir(FS.FolderName name)
            => (ImmRoot + name);

        FS.FilePath HexImmPath(PartId owner, ApiHostUri host, OpIdentity id)
            => ImmSubDir(FS.folder(owner.Format(), host.Name)) + HexOpFileName(id);

        FS.FilePath AsmImmPath(PartId owner, ApiHostUri host, OpIdentity id)
            => ImmSubDir(FS.folder(owner.Format(), host.Name)) + AsmFileName(id);
    }
}