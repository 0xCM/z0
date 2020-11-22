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

    using static Konst;
    using static z;

    [ApiHost(ApiNames.ApiArchives, true)]
    public readonly struct ApiArchives
    {
        [MethodImpl(Inline)]
        public static IApiHexReader hexreader<H>(H rep = default)
            where H : struct, IArchiveReader
        {
            if(typeof(H) == typeof(ApiHexReader))
                return new ApiHexReader();
            else
                throw no<H>();
        }

        [MethodImpl(Inline)]
        public static ApiHexWriter hexwriter<H>(FS.FilePath dst, H rep = default)
            where H : struct, IArchiveWriter<H>
        {
            if(typeof(H) == typeof(ApiHexWriter))
                return new ApiHexWriter(dst);
            else
                throw no<H>();
        }

        [MethodImpl(Inline), Op]
        public static ApiHexArchive hex(IWfShell wf)
            => new ApiHexArchive(wf);

        [MethodImpl(Inline), Op]
        public static ApiHexArchive hex(FS.FolderPath root)
            => new ApiHexArchive(root);

        [MethodImpl(Inline), Op]
        public static ApiCodeBlock[] hexblocks(IWfShell wf, ApiHostUri host)
            => hex(wf).Read(host);

        [Op]
        public static ApiCodeBlock[] hexblocks(FS.FilePath src)
            => from line in src.ReadLines().Select(ApiHexParser.parse)
                where line.Succeeded
                select line.Value;

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

        [MethodImpl(Inline), Op]
        public static IHostCaptureArchive capture(FS.FolderPath root, ApiHostUri host)
            => new HostCaptureArchive(root, host);

        [Op]
        public static uint emit(ReadOnlySpan<ApiCodeDescriptor> src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            var count = (uint)src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(src,i);
                writer.WriteLine(string.Format(ApiCodeDescriptor.FormatPattern, block.Part, block.Host, block.Base, block.Size, block.Uri));
            }
            return count;
        }

        [Op]
        public static ApiCodeDescriptor[] BlockDescriptors(IWfShell wf)
        {
            var archive = ApiArchives.hex(wf);
            var files = @readonly(archive.List().Storage);
            var dst = list<ApiCodeDescriptor>();
            var count = files.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var file = ref skip(files,i);
                var content = @readonly(archive.Read(file.Path));
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
        public static ApiCodeDescriptor[] BlockDescriptors(IWfShell wf, params PartId[] parts)
        {
            var archive = ApiArchives.hex(wf);
            wf.Status(parts.Length);
            var dst  = list<ApiCodeDescriptor>();
            foreach(var part in parts)
            {

                var files = @readonly(archive.Files(part));
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
            }

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

        [Op]
        public static ApiCodeDescriptor[] BlockDescriptors(FS.FolderPath src)
        {
            var archive = ApiArchives.hex(src);
            var files = archive.List();
            var dst = list<ApiCodeDescriptor>();
            foreach(var file in files.Storage)
                dst.AddRange(archive.Read(file.Path).Select(x => descriptor(x)));
            return dst.OrderBy(x => x.Base).ToArray();
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

        [MethodImpl(Inline), Op]
        public static ref ApiCodeRow row(ApiCodeBlock src, ref ApiCodeRow dst)
        {
            dst.Base = src.Code.Base;
            dst.Encoded = src.Data;
            dst.Uri =src.Uri.Format();
            return ref dst;
        }

        public static ApiCodeRow[] save(ReadOnlySpan<ApiCodeBlock> src, FS.FilePath dst, bool append = false)
        {
            var formatter = TableFormatter.row<ApiCodeRow>(X86TableWidths);
            var count = src.Length;
            var header = (dst.Exists && append) ? false : true;
            using var writer = dst.Writer(append);
            if(header)
                writer.WriteLine(formatter.FormatHeader());

            var buffer = alloc<ApiCodeRow>(count);
            var records = span(buffer);
            for(var i=0u; i<src.Length; i++)
            {
                ref readonly var code = ref z.skip(src, i);
                if(code.IsNonEmpty)
                {
                    var t = row(code, ref seek(records,i));
                    {
                        formatter.Delimit(16, t.Base);
                        formatter.Delimit(80, t.Uri);
                        formatter.Delimit(t.Encoded);
                        writer.WriteLine(formatter.Render());
                    }
                }
            }
            return buffer;
        }

        public static Dictionary<PartId,PartFile[]> index(PartFileKind kind, PartFiles src, params PartId[] parts)
        {
            switch(kind)
            {
                case PartFileKind.Parsed:
                    return select(PartFileKind.Parsed, src.Parsed, parts);
                default:
                    return dict<PartId,PartFile[]>();
            }
        }

        static Dictionary<PartId,PartFile[]> select(PartFileKind kind, FS.Files src, PartId[] parts)
        {
            var partSet = parts.ToHashSet();
            var files = (from f in src
                        let part = f.Owner
                        where part != PartId.None && partSet.Contains(part)
                        let pf = new PartFile(part, kind, f)
                        group pf by pf.Part).ToDictionary(x => x.Key, y => y.ToArray());
            return files;
        }

        static ReadOnlySpan<byte> X86TableWidths => new byte[3]{16,80,80};
    }
}