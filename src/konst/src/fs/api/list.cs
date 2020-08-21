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
        public static ListedFiles list(Files src)
            => new ListedFiles(src.Data.Mapi((i,x) => new ListedFile((uint)i,x)));
    }
}