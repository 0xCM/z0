//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct FS
    {
        [MethodImpl(Inline), Op]
        public static FileExt ext(PathPart name)
            => new FileExt(name);

        [MethodImpl(Inline), Op]
        public static FileExt ext(PathPart a, PathPart b)
            => new FileExt(a,b);
    }
}