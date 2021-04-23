//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    partial struct FS
    {
        [Op]
        public static FileType filetype(FileKind kind, params FS.FileExt[] extensions)
            => new FileType(kind,extensions);
    }
}