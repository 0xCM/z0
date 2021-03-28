//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using static Llvm;

    public interface ILlvmPaths : IFileArchive
    {

        ILlvmSourcePaths Source => new SourcePaths(Root + FS.folder("llvm"));

        ILlvmTestCasePaths Test => new TestCasePaths(Root + FS.folder("llvm") + FS.folder("test"));

        ILlvmBuildPaths Build => new BuildPaths(Root + FS.folder("build"));

        ILlvmToolPaths Tools => new ToolPaths(Root + FS.folder("llvm"));
    }

    partial struct Llvm
    {
        public ILlvmPaths LPaths
            => new LlvmPaths(SrcRoot);

        internal struct LlvmPaths : ILlvmPaths
        {
            public FS.FolderPath Root {get;}

            internal LlvmPaths(FS.FolderPath root)
                => Root = root;
        }
    }
}