//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using Windows;

    using static Root;

    partial struct FS
    {
        [Op]
        public static Outcome symlink(string name, FS.FolderPath target)
            => Kernel32.CreateSymLink(name, target.Name, SymLinkKind.Directory);

        [Op]
        public static Outcome symlink(string name, FS.FilePath target)
            => Kernel32.CreateSymLink(name, target.Name, SymLinkKind.File);
    }
}