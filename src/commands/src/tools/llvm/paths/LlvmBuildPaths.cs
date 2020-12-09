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
        public readonly struct BuildPaths
        {
            public FS.FolderPath Root {get;}

            [MethodImpl(Inline)]
            internal BuildPaths(FS.FolderPath root)
                => Root = root;

            [MethodImpl(Inline)]
            public BuildPaths Update(FS.FolderPath root)
                => new BuildPaths(root);

            public FS.FolderPath BuildIncludeDir
                => Root + FS.folder("llvm");

            public FS.FolderPath BuildLibDir
                => Root + FS.folder("lib");

            public FS.FolderPath BuildToolDir
                => Root + FS.folder("tools");

            public FS.FolderName BuildConfigName
                => FS.folder("Release");

            public FS.FolderPath BuildTargetDir
                => Root + BuildConfigName;

            public FS.FolderPath BuildTargetExeDir
                => BuildTargetDir + FS.folder("bin");

            public FS.FolderPath BuildTargetLibDir
                => BuildTargetDir + FS.folder("lib");
        }
    }
}