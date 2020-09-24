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
    using static z;

    [ApiHost]
    public readonly partial struct Archives
    {
        [MethodImpl(Inline), Op]
        public static FS.FolderPath TableRoot(FS.FolderPath root)
            => root + FS.folder("tables");

        [MethodImpl(Inline), Op]
        public static FS.FolderPath IndexRoot(FS.FolderPath root)
            => root + FS.folder("index");

        [MethodImpl(Inline)]
        static SearchOption option(bool recurse)
            => recurse ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

        [MethodImpl(Inline), Op]
        public static ISemanticArchive semantic()
            => new SemanticArchive();
    }
}