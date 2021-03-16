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

    [ApiHost]
    public readonly struct ImageArchives
    {
        [Op]
        public static IImageReader csvreader(IWfShell wf, FS.FilePath src)
        {
            if(!src.Exists)
                @throw(FS.missing(src));

            return new ImageCsvReader(wf, src);
        }

        [Op]
        public static void pipe(IWfShell wf, FS.FilePath src, RecordSink<ImageContent> dst)
        {
            using var reader = csvreader(wf, src);
            var record = default(ImageContent);
            var @continue = true;
            while(@continue)
            {
                if(reader.Read(ref record))
                    dst.Deposit(record);
                else
                    @continue = false;
            }
        }

        [Op]
        public static void EmitBuildArchiveList(IWfShell wf, string label)
        {
            var builder = wf.CmdBuilder();
            var archive = Archives.runtime(wf);
            var types = array(archive.Dll, archive.Exe, archive.Pdb, archive.Lib, archive.Xml, archive.Json);
            var cmd = builder.ListFiles(label + ".build-artifacts", archive.Root, types);
            wf.Router.Dispatch(cmd);
        }

        /// <summary>
        /// Creates an archive that contains csv-formatted image files
        /// </summary>
        /// <param name="wf">The workflow source</param>
        [Op]
        public static IFileArchive tables(IWfShell wf)
            => new FileArchive(wf.Db().TableDir<ImageContent>());

        /// <summary>
        /// Creates an archive over the runtime directory
        /// </summary>
        /// <param name="wf">The workflow source</param>
        [Op]
        public static IFileArchive runtime(IWfShell wf)
            => new FileArchive(wf.Controller.ImageDir);

        /// <summary>
        /// Creates an archive that contains build image artifacts
        /// </summary>
        /// <param name="wf">The workflow source</param>
        [Op]
        public static IFileArchive build(IWfShell wf)
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