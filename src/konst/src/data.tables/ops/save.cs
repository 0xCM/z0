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

    partial struct Table
    {
        public static Option<FilePath> save<F,R>(R[] src, FS.FilePath dst)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => store<F,R>().Save(src, dst);
    }
}