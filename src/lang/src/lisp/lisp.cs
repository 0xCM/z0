//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    [ApiHost]
    public readonly struct lisp
    {
        [Op]
        public static LispDoc doc(FS.FilePath src)
            => LispDoc.load(src);

        [Op]
        public static LispDoc doc(TextBlock src)
            => LispDoc.load(src);
    }
}