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
            => Z0.CaptureArchive.Define(root, area, subject);

        /// <summary>
        /// Instantiates a contextual service allocation that streams lines of operation hex to a target file
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="dst">The target file</param>
        [MethodImpl(Inline)]
        public static IUriBitsWriter UriBitsWriter(this IContext context, FilePath dst)
            => Z0.UriBitsWriter.Create(context, dst);

        [MethodImpl(Inline)]
        public static IUriBitsReader UriBitsReader(this IContext context)
            => Z0.UriBitsReader.Create(context);

        [MethodImpl(Inline)]
        public static IHostBitsArchive HostBitsArchive(this IContext context, PartId id, FolderPath root = null)
            => Z0.HostBitsArchive.Create(context, id, root ?? Z0.CaptureArchive.Default.RootDir);

        /// <summary>
        /// Instantiates a contextual code reader service
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="idsep">The identifer/code delimiter</param>
        /// <param name="bytesep">The byte delimiter</param>
        [MethodImpl(Inline)]
        public static IBitArchiveReader BitArchiveReader(this IContext context)
            => Z0.BitArchiveReader.New(context);

        /// <summary>
        /// Instantiates a contextual code writer services that targets a specified file path
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="dst">The target path</param>
        /// <param name="append">Whether the writer should append to an existing file if it exist or obliterate it regardless</param>
        [MethodImpl(Inline)]
        public static IBitArchiveWriter BitArchiveWriter(this IContext context, FilePath dst)
            => Z0.BitArchiveWriter.Create(context, dst);

        /// <summary>
        /// Instantiates a contextual code archive service that is specialized for an assembly and api host
        /// <param name="context">The source context</param>
        /// <param name="catalog">The catalog name</param>
        /// <param name="host">The api host name</param>
        [MethodImpl(Inline)]
        public static IHostBitsArchive HostBitsArchive(this IContext context, PartId assembly, ApiHostUri host, FolderPath root = null)
            => Z0.HostBitsArchive.Create(context, assembly, host, root ?? Z0.CaptureArchive.Default.RootDir);

        [MethodImpl(Inline)]
        public static ICodeIndexBuilder ApiIndexBuilder(this IContext c, IApiSet api, IMemberLocator locator)
            => Z0.ApiIndexBuilder.Create(c, api, locator);


        /// <summary>
        /// Reads code from a hex file
        /// </summary>
        /// <param name="src">The source path</param>
        public static ReadOnlySpan<UriBits> ReadUriBits(this IContext context, FilePath src)
            => context.UriBitsReader().Read(src).ToArray();

        public static OpIndex<UriBits> IndexUriBits(this IContext context, in ApiHostUri host, FolderPath root)
        {
            var emissions = Z0.CaptureArchive.Define(root);            
            var paths = emissions.HostArchive(host);
            var code = context.ReadUriBits(paths.HexPath);
            var index = code.ToEnumerable().ToOpIndex();    
            return index;
        }
    }
}