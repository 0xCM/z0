//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;

    partial struct FS
    {
        [Op]
        public static ListedFiles list(FS.FilePath[] src)
            => new ListedFiles(src.Mapi((i,x) => new ListedFile(i,x)));

        [Op]
        public static ListedFiles search(FileArchive src, string pattern, bool recurse)
            => list(Directory.EnumerateFiles(src.Root.Name, pattern, option(recurse)).Array().Select(x => FS.path(pattern)));

        [MethodImpl(Inline)]
        internal static SearchOption option(bool recurse)
            => recurse ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

        [MethodImpl(Inline), Op]
        public static IFileArchive archive(FS.FolderPath root)
            => new FileArchive(root);

        [MethodImpl(Inline), Op]
        public static IFileArchive archive(FS.FolderPath root, params FS.FileExt[] ext)
            => new FileKinds(root,ext);
    }
}