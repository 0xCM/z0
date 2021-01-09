//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Llvm
    {
        public readonly struct ToolPaths
        {
            public FS.FolderPath Root {get;}

            internal ToolPaths(FS.FolderPath root)
            {
                Root = root;
            }

            [MethodImpl(Inline)]
            public ToolPaths Update(FS.FolderPath root)
                => new ToolPaths(root);

            FS.FolderPath LlvmSrcDir => Root + FS.folder("llvm");

            FS.FolderPath BuildRootDir => Root + FS.folder("build");

            FS.FolderPath LlvmTestSrcDir => LlvmSrcDir + FS.folder("test");

            public SourcePaths Source => new SourcePaths(LlvmSrcDir);

            public TestCasePaths Test => new TestCasePaths(LlvmTestSrcDir);

            public BuildPaths Build => new BuildPaths(BuildRootDir);

            public FS.FolderPath ClangSrcDir => Root + FS.folder("clang");
        }
    }
}