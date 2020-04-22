//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static Seed;

    public static class ApiArchiveServices
    {
        [MethodImpl(Inline)]
        public static ICaptureArchive CaptureArchive(this IContext context, FolderPath root = null, FolderName area = null, FolderName subject = null)    
            => Z0.CaptureArchive.Create(root, area, subject);

        /// <summary>
        /// Instantiates a contextual service allocation that streams lines of operation hex to a target file
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="dst">The target file</param>
        [MethodImpl(Inline)]
        public static IUriBitsWriter UriBitsWriter(this IContext context, FilePath dst)
            => Z0.UriBitsWriter.Create(context, dst);

        [MethodImpl(Inline)]
        public static UriBitsWriterFactory UriBitsWriter(this IContext context)
            => dst => context.UriBitsWriter(dst);

        [MethodImpl(Inline)]
        public static IUriBitsReader UriBitsReader(this IContext context)
            => Z0.UriBitsReader.Service;

        [MethodImpl(Inline)]
        public static IHostBitsArchive HostBits(this IContext context, PartId id, FolderPath root = null)
            => Z0.HostBitsArchive.Create(context, id, root ?? Z0.CaptureArchive.Default.RootDir);

        [MethodImpl(Inline)]
        public static IHostBitsArchive HostBits(this IContext context, PartId assembly, ApiHostUri host, FolderPath root = null)
            => HostBitsArchive.Create(context, assembly, host, root ?? Z0.CaptureArchive.Default.RootDir);

        [MethodImpl(Inline)]
        public static IHostBitsArchive HostBits(this IContext context, ApiHostUri host, FolderPath root = null)
            => HostBitsArchive.Create(context, host.Owner, host, root ?? Z0.CaptureArchive.Default.RootDir);

        /// <summary>
        /// Instantiates a contextual code reader service
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="idsep">The identifer/code delimiter</param>
        /// <param name="bytesep">The byte delimiter</param>
        [MethodImpl(Inline)]
        public static IBitArchiveReader BitArchiveReader(this IContext context)
            => Z0.BitArchiveReader.Service;

        /// <summary>
        /// Instantiates a contextual code writer services that targets a specified file path
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="dst">The target path</param>
        /// <param name="append">Whether the writer should append to an existing file if it exist or obliterate it regardless</param>
        [MethodImpl(Inline)]
        public static IBitArchiveWriter BitArchiveWriter(this IContext context, FilePath dst)
            => Z0.BitArchiveWriter.Create(context, dst);        
    }
}