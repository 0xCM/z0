//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    partial struct ApiCode
    {
        [Op]
        public static Index<ApiCodeDescriptor> descriptors(IWfShell wf)
        {
            var archive = WfArchives.hex(wf);
            var root = archive.Root;
            var files = @readonly(archive.ArchivedFiles().Array());
            var empty = Index<ApiCodeDescriptor>.Empty;
            if(files.Length == 0)
            {
                wf.Warn($"No files found in {root}");
                return empty;
            }
            var count = files.Length;

            wf.Status($"Processing {count} files in {root}");

            var dst = list<ApiCodeDescriptor>();
            for(var i=0u; i<count; i++)
            {
                ref readonly var file = ref skip(files,i);
                wf.Status($"Processing {file}");

                var content = @readonly(archive.Read(file));
                var blocks = content.Length;
                if(blocks == 0)
                    wf.Warn($"No content found in {file}");
                else
                {
                    wf.Status($"Accumulating {blocks} descriptors from {file}");
                    var buffer = alloc<ApiCodeDescriptor>(blocks);
                    var target = span(buffer);
                    for(var j=0u; j<blocks; j++)
                        store(skip(content,j), ref seek(target,j));
                    dst.AddRange(buffer);
                }
            }

            wf.Status($"Accumulated {dst.Count} descriptors from files in {root}");
            return dst.OrderBy(x => x.Base).ToArray();
        }

        public static Index<ApiCodeDescriptor> descriptors(ApiHexArchive archive, ReadOnlySpan<FS.FilePath> files)
        {
            var dst = list<ApiCodeDescriptor>();
            var count = files.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var file = ref skip(files,i);
                var content = @readonly(archive.Read(file));
                var kBlock = content.Length;
                var buffer = alloc<ApiCodeDescriptor>(kBlock);
                var target = span(buffer);
                for(var j=0u; j<kBlock; j++)
                    store(skip(content,j), ref seek(target,j));
                dst.AddRange(buffer);
            }
            return dst.OrderBy(x => x.Base).ToArray();
        }

        [Op]
        public static Index<ApiCodeDescriptor> descriptors(FS.FolderPath src)
        {
            var archive = WfArchives.hex(src);
            var files = archive.List();
            var dst = list<ApiCodeDescriptor>();
            foreach(var file in files.Storage)
                dst.AddRange(archive.Read(file.Path).Select(x => descriptor(x)));
            return dst.OrderBy(x => x.Base).ToArray();
        }

        [MethodImpl(Inline), Op]
        public static ApiCodeDescriptor descriptor(in ApiCodeBlock src)
        {
            var dst = new ApiCodeDescriptor();
            dst.Part = src.Uri.Part;
            dst.Host = src.Uri.Host.Name;
            dst.Base = src.Code.Base;
            dst.Size = src.Code.Length;
            dst.Uri = src.Identifier;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ApiCodeDescriptor store(in ApiCodeBlock src, ref ApiCodeDescriptor dst)
        {
            dst.Part = src.Uri.Part;
            dst.Host = src.Uri.Host.Name;
            dst.Base = src.Code.Base;
            dst.Size = src.Code.Length;
            dst.Uri = src.Identifier;
            return ref dst;
        }
    }
}