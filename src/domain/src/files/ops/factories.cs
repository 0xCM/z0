//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FileSystem
    {
        [MethodImpl(Inline), Op]
        public static PathPart name(params char[] name)
            => new PathPart(name);

        [MethodImpl(Inline), Op]
        public static Extension ext(PathPart name)
            => new Extension(name);

        [MethodImpl(Inline), Op]
        public static Drive drive(DriveLetter letter)
            => new Drive(letter);

        [MethodImpl(Inline), Op]
        public static FolderName folder(PathPart name)
            => new FolderName(name);

        [MethodImpl(Inline), Op]
        public static FileName file(PathPart name)
            => new FileName(name);

        [MethodImpl(Inline), Op]
        public static FileName file(PathPart name, Extension ext)
            => new FileName(name, ext);

        [MethodImpl(Inline), Op]
        public static FolderPath dir(PathPart name)
            => new FolderPath(name);

        [MethodImpl(Inline), Op]
        public static FilePath path(PathPart name)
            => new FilePath(name);
    }
}