//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct KindedFiles
    {
        [MethodImpl(Inline)]
        public static KindedFile<K> from<K>(FS.FilePath src)
            where K : unmanaged, IFileKind<K>
                => new KindedFile<K>(src);
    }
}