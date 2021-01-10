//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    public interface ILlvmToolPaths : IFileArchive
    {
        FS.FolderPath SrcDir => Root + FS.folder("llvm");

        FS.FolderPath BuildRootDir => Root + FS.folder("build");

        FS.FolderPath TestSrcDir => SrcDir + FS.folder("test");

    }

    partial struct Llvm
    {
        public readonly struct ToolPaths : ILlvmToolPaths
        {
            public FS.FolderPath Root {get;}

            internal ToolPaths(FS.FolderPath root)
                => Root = root;

            // public FS.FolderPath SrcDir => Root + FS.folder("llvm");

            // public FS.FolderPath BuildRootDir => Root + FS.folder("build");

            // public FS.FolderPath TestSrcDir => SrcDir + FS.folder("test");

            // public SourcePaths Source => new SourcePaths(SrcDir);

            // public TestCasePaths Test => new TestCasePaths(TestSrcDir);

            // public BuildPaths Build => new BuildPaths(BuildRootDir);

            public FS.FolderPath ClangSrcDir => Root + FS.folder("clang");
        }
    }
}