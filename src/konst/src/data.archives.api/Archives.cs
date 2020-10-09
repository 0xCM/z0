//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct Archives
    {
        [Op]
        public static void save(ListedFiles src, FS.FilePath dst)
        {
            var records = src.View;
            var count = records.Length;
            var header = Table.header<ListedFileField>();
            using var writer = dst.Writer();
            writer.WriteLine(header.HeaderText);
            for(var i=0u; i<count; i++)
            {
                ref readonly var record = ref skip(records,i);
                writer.WriteLine(format(record));
            }
        }

        public static ApiCodeBlockInfo[] hexinfo(FS.FolderPath root)
        {
            var archive = hex(root);
            var files = archive.List();
            var dst = list<ApiCodeBlockInfo>();
            foreach(var file in files.Storage)
                dst.AddRange(archive.Read(file.Path).Select(x => x.Describe()));
            return dst.OrderBy(x => x.Base).ToArray();
        }

        public static ApiCodeBlock[] hexblocks(FS.FilePath src)
            => from line in src.ReadLines().Select(ApiCodeParser.parse)
                where line.Succeeded
                select line.Value;

        [MethodImpl(Inline), Op]
        public static ApiCodeBlock[] hexblocks(IWfShell wf, ApiHostUri host)
            => hex(wf).Read(host);

        [MethodImpl(Inline), Op]
        public static ApiCodeArchive hex(IWfShell wf)
            => new ApiCodeArchive(wf);

        [MethodImpl(Inline), Op]
        public static ApiCodeArchive hex(FS.FolderPath root)
            => new ApiCodeArchive(root);

        [MethodImpl(Inline), Op]
        public static FS.FolderPath dbRoot(FS.FolderPath root)
            => root + FS.folder("tables");

        [MethodImpl(Inline), Op]
        public static FS.FolderPath IndexRoot(FS.FolderPath root)
            => root + FS.folder("index");

        [MethodImpl(Inline)]
        static SearchOption option(bool recurse)
            => recurse ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

        [MethodImpl(Inline), Op]
        public static ISemanticArchive semantic()
            => new SemanticArchive();

        [MethodImpl(Inline), Op]
        public static ApiHostCodeBlocks index(ApiHostUri host, ApiCodeBlock[] code)
            => new ApiHostCodeBlocks(host,code);

        public static Dictionary<PartId,PartFile[]> index(PartFileClass kind, PartFiles src, params PartId[] parts)
        {
            switch(kind)
            {
                case PartFileClass.Parsed:
                    return select(PartFileClass.Parsed, src.Parsed, parts);
                default:
                    return dict<PartId,PartFile[]>();
            }
        }

        static Dictionary<PartId,PartFile[]> select(PartFileClass kind, FS.Files src, PartId[] parts)
        {
            var partSet = parts.ToHashSet();
            var files = (from f in src
                        let part = f.Owner
                        where part != PartId.None && partSet.Contains(part)
                        let pf = new PartFile(part, kind, f)
                        group pf by pf.Part).ToDictionary(x => x.Key, y => y.ToArray());
            return files;
        }

        [Op]
        public static PartFiles partfiles(FS.FolderPath root)
        {
            var src = Archives.capture(root);
            var parsed = src.ParsePaths.Select(x => FS.path(x.Name));
            var hex = src.HexPaths.Select(x => FS.path(x.Name));
            var asm = src.AsmPaths.Select(x => FS.path(x.Name));
            return new PartFiles(root, parsed, hex, asm);
        }

        /// <summary>
        /// Creates an archive over the output of a build
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static IBuildArchive build(ArchiveConfig root)
            => new BuildArchive(root);

        /// <summary>
        /// Creates an archive over both managed and unmanaged modules
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static IModuleArchive modules(ArchiveConfig config)
            => new ModuleArchive(config);

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