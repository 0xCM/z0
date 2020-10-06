//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Archives
    {
        [MethodImpl(Inline), Op]
        public static FS.FilePath table(FS.FolderPath root, string id, string name, string type = null)
            => TableRoot(root) + FS.file(text.format("{0}.{1}", id,name), type ?? ArchiveExt.Csv.Name);

        [MethodImpl(Inline), Op]
        public static FS.FilePath table(FS.FolderPath root, FS.FileName file)
            => TableRoot(root) + file;
    }
}