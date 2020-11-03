//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FS
    {
        [MethodImpl(Inline)]
        public static KindedFile<K> kinded<K>(FS.FilePath src)
            where K : unmanaged, IFileKind<K>
                => new KindedFile<K>(src);
    }
}