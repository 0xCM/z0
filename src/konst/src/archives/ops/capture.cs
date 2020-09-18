//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Archives
    {
        [MethodImpl(Inline), Op]
        public static IPartCaptureArchive capture(FolderPath root)
            => new PartCaptureArchive(root ?? EnvVars.Common.LogRoot, FolderName.Empty, FolderName.Empty);

        [MethodImpl(Inline), Op]
        public static IPartCaptureArchive capture(FS.FolderPath root)
            => new PartCaptureArchive(root);

        [MethodImpl(Inline), Op]
        public static IPartCaptureArchive capture(PartId part)
            => new PartCaptureArchive(EnvVars.Common.LogRoot, FolderName.Define("capture"), FolderName.Define(part.Format()));

        [MethodImpl(Inline), Op]
        public static IPartCaptureArchive capture(ArchiveSettings config)
            => capture(FS.dir(config.Root.Name));
    }
}