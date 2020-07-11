//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System.Linq;
    public interface TPartImmFilePaths : TPartFilePaths
    {
        FolderPath ImmRootDirPath(FolderPath root)
            => (root + ImmFolderName).Create();

        /// <summary>
        /// Defines the path of an imm part directory
        /// </summary>
        /// <param name="part">The owning part</param>
        FolderPath ImmDirPath(FolderPath root, PartId part)
            => ImmRootDirPath(root) + PartFolderName(part);
    }
}