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
        public FolderPath ArchiveRoot {get;}

        [MethodImpl(Inline)]
        internal CaptureArchive(FS.FolderPath root)
            => ArchiveRoot = FolderPath.Define(root.Create().Name);
    }
}