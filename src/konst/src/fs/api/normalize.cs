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
        [MethodImpl(Inline), Op]
        public static PathPart normalize(PathPart src)
            => src.Name.Replace('\\', '/');

        [MethodImpl(Inline), Op]
        public static FilePath normalize(FilePath src)
            => path(normalize(src.Name));

        [MethodImpl(Inline), Op]
        public static FilePath normalize(FolderPath src)
            => path(normalize(src.Name));
    }
}