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
        [MethodImpl(Inline)]
        public static FilePath<K> path<K>(FS.FilePath src, K kind)
            where K : struct, IFileType<K>
                => new FilePath<K>(src,kind);
    }
}