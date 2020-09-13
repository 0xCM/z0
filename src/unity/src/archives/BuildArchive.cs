//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    public interface IBuildArchive : IFileArchive<BuildArchive>
    {
        FS.FolderPath From(string path)
            => FS.dir(path);
        FS.FolderPath NetCoreApp(string version)
            => Root + FS.folder($"netcoreapp{version}");

        FS.FolderPath NetCoreWin64(string version)
            => NetCoreApp(version) + FS.folder("win-x64");
    }

    public readonly struct BuildArchive : IBuildArchive
    {
        [MethodImpl(Inline)]
        public static IBuildArchive create(FS.FolderPath root)
            => new BuildArchive(root);

        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public BuildArchive(FS.FolderPath root)
        {
            Root = root;
        }
    }
}