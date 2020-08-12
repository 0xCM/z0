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
        public static FileName file(PathPart name)
            => new FileName(name);

        [MethodImpl(Inline), Op]
        public static FileName file(PathPart name, Extension ext)
            => new FileName(name, ext);
    }
}