//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Images
{
    using System;
    using System.IO;
    using System.Reflection.Metadata;

    using static Part;
    using static z;

    [ApiHost]
    public readonly struct ImageArchives
    {
        public static void PipeImages(IWfShell wf)
        {
            var archive = csv(wf);
            wf.Status(archive.Root);
            corefunc.iter(archive.List().Storage, file => wf.Status(file));
        }

        public static void pipe(IWfShell wf, FS.FilePath src, RecordSink<ImageContentRecord> dst)
        {
            using var reader = ImageCsvReader.create(wf, src);
            var record = default(ImageContentRecord);
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
        public static void EmitBuildArchiveList(IWfShell wf, FS.FolderPath src, string label)
        {
            var builder = wf.CmdBuilder();
            var archive = BuildArchives.create(wf, src);
            var types = array(archive.Dll, archive.Exe, archive.Pdb, archive.Lib, archive.Xml, archive.Json);
            var cmd = builder.ListFiles(label + ".build-artifacts", archive.Root, types);
            wf.Router.Dispatch(cmd);
        }

        /// <summary>
        /// Creates an archive that contains csv-formatted image files
        /// </summary>
        /// <param name="wf">The workflow source</param>
        public static FileArchive csv(IWfShell wf)
            => new FileArchive(wf.Db().TableRoot<ImageContentRecord>());

        /// <summary>
        /// Creates an archive that contains build image artifacts
        /// </summary>
        /// <param name="wf">The workflow source</param>
        public static FileArchive build(IWfShell wf)
            => new FileArchive(wf.Db().BuildArchiveRoot());

        public unsafe static MetadataReaderProvider provider(byte* pStart, ByteSize size)
            => MetadataReaderProvider.FromMetadataImage(pStart, size);

        public static MetadataReaderProvider provider(Stream stream, MetadataStreamOptions options = MetadataStreamOptions.Default)
            => MetadataReaderProvider.FromMetadataStream(stream, options);
    }
}