//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Reflection.Metadata;

    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static Images;

    [ApiHost]
    public readonly struct ImageArchives
    {
        [Op]
        public static void EmitBuildArchiveList(IWfRuntime wf, string label)
        {
            var builder = wf.CmdBuilder();
            var archive = WfRuntime.RuntimeArchive(wf);
            var types = array(FS.Extensions.Dll, FS.Extensions.Exe, FS.Extensions.Pdb, FS.Extensions.Lib, FS.Extensions.Xml, FS.Extensions.Json);
            var cmd = builder.ListFiles(label + ".build-artifacts", archive.Root, types);
            wf.Router.Dispatch(cmd);
        }

        /// <summary>
        /// Creates an archive that contains csv-formatted image files
        /// </summary>
        /// <param name="wf">The workflow source</param>
        [Op]
        public static IFileArchive tables(IWfRuntime wf)
            => new FileArchive(wf.Db().TableDir<ImageContent>());

        /// <summary>
        /// Creates an archive over the runtime directory
        /// </summary>
        /// <param name="wf">The workflow source</param>
        [Op]
        public static IFileArchive runtime(IWfRuntime wf)
            => new FileArchive(wf.Controller.ImageDir);

        /// <summary>
        /// Creates an archive that contains build image artifacts
        /// </summary>
        /// <param name="wf">The workflow source</param>
        [Op]
        public static IFileArchive build(IWfRuntime wf)
            => new FileArchive(wf.Db().BuildArchiveRoot());

        [MethodImpl(Inline), Op]
        public unsafe static MetadataReaderProvider provider(byte* pStart, ByteSize size)
            => MetadataReaderProvider.FromMetadataImage(pStart, size);

        [MethodImpl(Inline), Op]
        public static MetadataReaderProvider provider(Stream stream, MetadataStreamOptions options = MetadataStreamOptions.Default)
            => MetadataReaderProvider.FromMetadataStream(stream, options);

        [MethodImpl(Inline), Op]
        public unsafe static MetadataReaderProvider pdbprovider(byte* pSrc, ByteSize size)
            => MetadataReaderProvider.FromPortablePdbImage(pSrc, size);

        [MethodImpl(Inline), Op]
        public static MetadataReaderProvider pdbprovider(Stream src, MetadataStreamOptions options = MetadataStreamOptions.Default)
            => MetadataReaderProvider.FromPortablePdbStream(src, options);
    }
}