//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct LlvmPaths : IFsPathRules<LlvmPaths>
    {
        public FS.FolderPath Root {get;}

        internal LlvmPaths(FS.FolderPath root)
        {
            Root = root;
        }

        [MethodImpl(Inline)]
        public LlvmPaths Update(FS.FolderPath root)
            => new LlvmPaths(root);

        FS.FolderPath LlvmSrcDir => Root + FS.folder("llvm");

        FS.FolderPath BuildRootDir => Root + FS.folder("build");

        FS.FolderPath LlvmTestSrcDir => LlvmSrcDir + FS.folder("test");

        public LlvmSourcePaths Source => new LlvmSourcePaths(LlvmSrcDir);

        public LlvmTestCasePaths Test => new LlvmTestCasePaths(LlvmTestSrcDir);

        public LlvmBuildPaths Build => new LlvmBuildPaths(BuildRootDir);

        public FS.FolderPath ClangSrcDir => Root + FS.folder("clang");
    }
}