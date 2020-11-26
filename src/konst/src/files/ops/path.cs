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
            => new FilePath(normalize(name));

        [MethodImpl(Inline), Op]
        public static FilePath path(FolderPath folder, FileName file)
            => folder + file;

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static FilePath<K> kind<K>(FS.FilePath src, K kind)
            where K : struct
                => new FilePath<K>(src,kind);
    }
}