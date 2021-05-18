//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct FileTypes
    {
        [MethodImpl(Inline), Op]
        public static FileType type(Type rtt, FileKind kind, params FS.FileExt[] extensions)
            => new FileType(rtt, kind, extensions);
    }
}