//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CaptureArchive : ICaptureArchive<CaptureArchive>
    {
        public FS.FolderPath ArchiveRoot {get;}

        [MethodImpl(Inline)]
        internal CaptureArchive(FS.FolderPath root)
            => ArchiveRoot = root;
    }
}