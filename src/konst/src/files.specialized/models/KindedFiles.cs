//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public readonly struct KindedFiles<K> : IKindedFiles<K>
        where K : unmanaged, IFileKind<K>
    {
        public IFileArchive Archive {get;}

        public K FileKind {get;}

        public IEnumerable<KindedFile<K>> Dir()
            => Archive.Files(true, FileKind.Ext).Map(KindedFiles.from<K>);
    }
}