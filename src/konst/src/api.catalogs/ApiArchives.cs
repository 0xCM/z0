//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.ApiArchives, true)]
    public readonly struct ApiArchives
    {
        [MethodImpl(Inline), Op]
        public static ApiCodeArchive hex(IWfShell wf)
            => new ApiCodeArchive(wf);

        [MethodImpl(Inline), Op]
        public static ApiCodeArchive hex(FS.FolderPath root)
            => new ApiCodeArchive(root);

        [MethodImpl(Inline), Op]
        public static ApiCodeBlock[] hexblocks(IWfShell wf, ApiHostUri host)
            => hex(wf).Read(host);

        [Op]
        public static ApiCodeBlock[] hexblocks(FS.FilePath src)
            => from line in src.ReadLines().Select(ApiHexParser.parse)
                where line.Succeeded
                select line.Value;

        [Op]
        public static ApiHostCodeBlocks index(ApiCodeArchive src, FS.FilePath path)
        {
            var uri = ApiUri.host(path.FileName);
            if(uri.Failed || uri.Value.IsEmpty)
                return default;

            var dst = z.list<ApiCodeBlock>();
            foreach(var item in ApiFiles.read(src))
                if(item.IsNonEmpty)
                    dst.Add(item);

            return ApiFiles.index(uri.Value, dst.Array());
        }

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

        /// <summary>
        /// Creates a <see cref='ICaptureArchive'/> rooted at a specified path
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static ICaptureArchive capture(FolderPath root)
            => new CaptureArchive(FS.dir(root.Name));

        /// <summary>
        /// Creates a <see cref='ICaptureArchive'/> rooted at a specified path and specialized for an identified <see cref='PartId'/>
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static ICaptureArchive capture(FS.FolderPath root, PartId part)
            => new CaptureArchive(root + FS.folder(part.Format()));


        /// <summary>
        /// Enumerates the content of all archived files
        /// </summary>
        public static IEnumerable<ApiCodeBlock> read(ApiCodeArchive src)
        {
            var list = src.List();
            var iCount = list.Count;
            for(var i=0; i<iCount; i++)
            {
                var path = list[i].Path;
                var items = ApiArchives.hexblocks(path);
                var jCount = items.Length;
                for(var j=0; j<jCount; j++)
                    yield return items[j];            }
        }

        /// <summary>
        /// Enumerates the content of archived files owned by a specified part
        /// </summary>
        public static IEnumerable<ApiCodeBlock> read(ApiCodeArchive src, PartId owner)
        {
            foreach(var file in src.Files(owner))
            foreach(var item in src.Read(file))
                if(item.IsNonEmpty)
                    yield return item;
        }

    }
}