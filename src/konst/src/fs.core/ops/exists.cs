//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FS
    {
        [MethodImpl(Inline), Op]
        public static bool exists(FolderPath src)
            => Directory.Exists(src.Name);

        [MethodImpl(Inline), Op]
        public static bool missing(FolderPath src)
            => !Directory.Exists(src.Name);

        [MethodImpl(Inline), Op]
        public static bool exists(FilePath src)
            => File.Exists(src.Name);

        [MethodImpl(Inline), Op]
        public static bool missing(FilePath src)
            => !File.Exists(src.Name);

    }
}