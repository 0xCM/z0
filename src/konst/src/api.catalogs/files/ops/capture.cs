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

    partial struct ApiFiles
    {
        /// <summary>
        /// Creates an archive over a set of capture artifacts
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static ICaptureArchive capture(FS.FolderPath root)
            => new CaptureArchive(root);

        /// <summary>
        /// Creates an archive over a set of capture artifacts
        /// </summary>
        /// <param name="root">The archive configuration</param>
        [MethodImpl(Inline), Op]
        public static ICaptureArchive capture(ArchiveConfig config)
            => capture(config.Root);

        [MethodImpl(Inline), Op]
        public static ICaptureArchive capture(FolderPath root)
            => new CaptureArchive(FS.dir(root.Name));

        [MethodImpl(Inline), Op]
        public static ICaptureArchive capture(FS.FolderPath root, PartId part)
            => new CaptureArchive(root + FS.folder(part.Format()));
    }
}