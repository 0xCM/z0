//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct KindedFile<K>
        where K : unmanaged, IFileKind<K>
    {
        public FS.FilePath Path {get;}

        [MethodImpl(Inline), Op]
        public KindedFile(FS.FilePath path)
            => Path = path;
    }
}