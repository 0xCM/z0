//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface ILlvmBuildPaths : IFileArchive
    {
        FS.FolderPath BuildIncludeDir
            => Root + FS.folder("llvm");

        FS.FolderPath BuildLibDir
            => Root + FS.folder("lib");

        FS.FolderPath BuildToolDir
            => Root + FS.folder("tools");

        FS.FolderName BuildConfigName
            => FS.folder("Release");

        FS.FolderPath BuildTargetDir
            => Root + BuildConfigName;

        FS.FolderPath BuildTargetExeDir
            => BuildTargetDir + FS.folder("bin");

        FS.FolderPath BuildTargetLibDir
            => BuildTargetDir + FS.folder("lib");
    }

    partial struct Llvm
    {
        internal readonly struct BuildPaths : ILlvmBuildPaths
        {
            public FS.FolderPath Root {get;}

            [MethodImpl(Inline)]
            internal BuildPaths(FS.FolderPath root)
                => Root = root;
        }
    }
}