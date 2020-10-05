//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct PartCaptureArchive : IPartCaptureArchive<PartCaptureArchive>
    {
        public FolderPath ArchiveRoot {get;}

        [MethodImpl(Inline)]
        internal PartCaptureArchive(FolderPath root, FolderName area, FolderName subject)
        {
            ArchiveRoot = root.Create();
        }

        [MethodImpl(Inline)]
        internal PartCaptureArchive(FS.FolderPath root)
        {
            ArchiveRoot = FolderPath.Define(root.Create().Name);
        }
    }
}