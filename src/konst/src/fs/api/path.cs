//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FS
    {
        [MethodImpl(Inline), Op]
        public static FilePath path(PathPart name)
            => new FilePath(name);

        [MethodImpl(Inline), Op]
        public static FilePath path(string name)
            => new FilePath(name);

        [MethodImpl(Inline), Op]
        public static FilePath path(FolderPath folder, FileName file)
            => folder + file;
    }
}