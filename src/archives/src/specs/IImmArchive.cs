//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;
    using static Memories;

    public interface IImmArchive : IArchive
    {        
        /// <summary>
        /// The imm root folder name
        /// </summary>
        FolderName ImmRootFolder 
            => FolderName.Define("imm", "Immediate embedding emission root");

        /// <summary>
        /// The imm root directory path
        /// </summary>
        FolderPath ImmRootDir 
            => (ArchiveRoot + ImmRootFolder).Create();

        /// <summary>
        /// Defines the path of an imm part directory
        /// </summary>
        /// <param name="part">The owning part</param>
        FolderPath ImmDir(PartId part)
            => ImmRootDir + PartFolder(part);

        /// <summary>
        /// Defines the path of an imm host directory
        /// </summary>
        /// <param name="part">The owning part</param>
        FolderPath ImmDir(ApiHostUri host)
            => ImmDir(host.Owner) + HostFolder(host);

        /// <summary>
        /// Nonrecursively enumerates directory paths owned by a specified part
        /// </summary>
        /// <param name="part">The owning part</param>
        /// <param name="ext">The extension to match</param>
        FolderPath[] ImmDirs(PartId part)
            => ImmRootDir.SubDirs.Where(d => d.Name.EndsWith(part.Format()));

        FolderPath[] ImmHostDirs(PartId part)
            => ImmDirs(part).SelectMany(path => path.SubDirs).ToArray();

        FolderPath[] ImmHostDirs(params PartId[] parts)
            => parts.SelectMany(ImmHostDirs).ToArray();

        /// <summary>
        /// Nonrecursively enumerates directory paths owned by a specified part
        /// </summary>
        /// <param name="parts">The owning parts</param>
        /// <param name="ext">The extension to match</param>
        FolderPath[] ImmDirs(params PartId[] parts)
            => parts.SelectMany(part => ImmDirs(part)).ToArray();

        FolderPath[] ImmDirs(ApiHostUri host)
            => ImmDirs(host.Owner).Where(path => path.Name.EndsWith(host.Name));

        FolderPath[] ImmDirs(params ApiHostUri[] hosts)
            => hosts.SelectMany(host => ImmDirs(host)).ToArray();

        FilePath[] HexImmFiles(PartId part)
            => ImmDir(part).Files(part, Hex);

        FilePath[] AsmImmFiles(PartId part)
            => ImmDir(part).Files(part, Asm);

        FilePath[] HexImmFiles(ApiHostUri host)
            => ImmDir(host).Files(host, Hex);

        FilePath[] AsmImmFiles(ApiHostUri host)
            => ImmDir(host).Files(host, Asm);

        FilePath[] HexImmFiles(PartId[] parts)
            => parts.Select(HexImmFiles).Join();

        FilePath[] AsmImmFiles(PartId[] parts)
            => parts.Select(AsmImmFiles).Join();

        FolderPath ImmSubDir(FolderName name) 
            => (ImmRootDir + name);

        FolderPath ImmSubDir(RelativeLocation name) 
            => (ImmRootDir +  name);

        FilePath HexImmPath(PartId owner, ApiHostUri host, OpIdentity id)
            => ImmSubDir(RelativeLocation.Define(owner.Format(), host.Name)) + HexFileName(id);

        FilePath AsmImmPath(PartId owner, ApiHostUri host, OpIdentity id)
            => ImmSubDir(RelativeLocation.Define(owner.Format(), host.Name)) + AsmFileName(id);
    }

}