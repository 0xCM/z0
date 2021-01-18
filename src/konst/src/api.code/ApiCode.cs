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

    using static Part;
    using static memory;

    [ApiHost(ApiNames.ApiCode, true)]
    public readonly struct ApiCode
    {
        [MethodImpl(Inline), Op]
        public static ApiPartCode combine(PartId part, ApiHostCode[] src)
            => new ApiPartCode(part,src);

        /// <summary>
        /// Determines whether an operation accepts an argument of specified numeric kind
        /// </summary>
        /// <param name="src">The encoded operation</param>
        /// <param name="match">The kind to match</param>
        [Op]
        public static bool accepts(ApiCodeBlock src, NumericKind match)
            => ApiIdentify.numeric(src.Id.Components.Skip(1)).Contains(match);

        /// <summary>
        /// Determines the arity of the encoded operation
        /// </summary>
        /// <param name="src">The encoded operation</param>
        [MethodImpl(Inline), Op]
        public static int arity(ApiCodeBlock src)
            => src.OpUri.OpId.Components.Count() - 1;

        /// <summary>
        /// Excludes source operations that do not accept two parameters of specified numeric kind
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="k1">The first parameter kind</param>
        /// <param name="k2">The second parameter kind</param>
        public static IEnumerable<ApiCodeBlock> accepts(IEnumerable<ApiCodeBlock> src, NumericKind k1, NumericKind k2)
            => from code in src
                let kinds = ApiIdentify.numeric(code.OpUri.OpId.Components.Skip(1))
                where kinds.Contains(k1) && kinds.Contains(k2)
                select code;

        [Op]
        public static IEnumerable<ApiCodeBlock> withArity(IEnumerable<ApiCodeBlock> src, int count)
            => from code in src
                where ApiCode.arity(code) == count
                select code;

        public static Dictionary<PartId,PartFile[]> index(PartFileKind kind, PartFiles src, params PartId[] parts)
        {
            switch(kind)
            {
                case PartFileKind.Parsed:
                    return select(PartFileKind.Parsed, src.Parsed, parts);
                default:
                    return root.dict<PartId,PartFile[]>();
            }
        }

        static Dictionary<PartId,PartFile[]> select(PartFileKind kind, FS.Files src, PartId[] parts)
        {
            var partSet = parts.ToHashSet();
            var files = (from f in src
                        let part = f.Owner
                        where part != PartId.None && partSet.Contains(part)
                        let pf = new PartFile(part, f)
                        group pf by pf.Part).ToDictionary(x => x.Key, y => y.ToArray());
            return files;
        }

        public static WfExecToken emit(IWfShell wf, ReadOnlySpan<ApiCodeDescriptor> src)
        {
            var dst = wf.Db().IndexTable("apihex.index");
            var flow = wf.EmittingTable<ApiCodeDescriptor>(dst);
            var count = emit(src, dst);
            return wf.EmittedTable<ApiCodeDescriptor>(flow, count, dst);
        }

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

        public static Outcome<FS.FilePath> EmitHexIndex(IWfShell wf)
        {
            try
            {
                var dst = wf.Db().IndexFile(ApiHexIndexRow.TableId);
                var flow = wf.EmittingFile(dst);
                var svc = ApiIndex.service(wf);
                var api = svc.CreateIndex();
                emit(wf, api, dst);
                wf.EmittedFile(flow, dst);
                return dst;
            }
            catch(Exception e)
            {
                wf.Error(e);
                return e;
            }
        }

        public static Outcome emit(IWfShell wf, ApiCodeBlockIndex src, FS.FilePath dst)
        {
            var svc = ApiIndex.service(wf);
            Array.Sort(src.CodeBlocks.Storage);
            var blocks = src.CodeBlocks.View;
            var count = blocks.Length;
            var buffer = sys.alloc<ApiHexIndexRow>(count);
            var target = span(buffer);
            using var emitter = Records.emitter<ApiHexIndexRow>(sys.array<byte>(10, 16, 20, 20, 20, 120), dst);
            emitter.EmitHeader();
            for(var i=0u; i<count; i++)
            {
                ref readonly var block = ref skip(blocks,i);
                ref var record = ref seek(target, i);
                record.Seqence = i;
                record.Address = block.BaseAddress;
                record.Component = block.OpUri.Part.Format();
                record.HostName = block.OpUri.Host.Name;
                record.MethodName = block.OpId.Name;
                record.Uri = block.Uri;
                emitter.Emit(record);
            }
            return true;
        }

        [Op]
        public static Index<ApiCodeBlock> extracts(FS.FilePath src)
            => from line in src.ReadLines().Select(ApiHexParser.extracts)
                where line.Succeeded
                select line.Value;

        [Op]
        public static Index<ApiCodeDescriptor> descriptors(IWfShell wf)
        {
            var archive = Archives.hex(wf);
            var rootdir = archive.Root;
            var files = @readonly(archive.ArchiveFiles().Array());
            var empty = Index<ApiCodeDescriptor>.Empty;
            if(files.Length == 0)
            {
                wf.Warn($"No files found in {rootdir}");
                return empty;
            }
            var count = files.Length;

            wf.Status($"Processing {count} files in {rootdir}");

            var dst = root.list<ApiCodeDescriptor>();
            for(var i=0u; i<count; i++)
            {
                ref readonly var file = ref skip(files,i);
                wf.Processing(file, "apihex");

                var content = @readonly(archive.Read(file));
                var blocks = content.Length;
                if(blocks == 0)
                    wf.Warn($"No content found in {file.ToUri()}");
                else
                {
                    wf.Status($"Accumulating {blocks} descriptors from {file.ToUri()}");
                    var buffer = alloc<ApiCodeDescriptor>(blocks);
                    var target = span(buffer);
                    for(var j=0u; j<blocks; j++)
                        store(skip(content,j), ref seek(target,j));
                    dst.AddRange(buffer);
                }
            }

            wf.Status($"Accumulated {dst.Count} descriptors from files in {rootdir}");
            return dst.OrderBy(x => x.Base).ToArray();
        }

        public static Index<ApiCodeDescriptor> descriptors(ReadOnlySpan<FS.FilePath> files)
        {
            var dst = z.list<ApiCodeDescriptor>();
            var count = files.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var file = ref skip(files,i);
                var rows = ApiHexRows.load(file);
                if(rows)
                {
                    var content = @readonly(rows.Value);
                    var kBlock = content.Length;
                    var buffer = alloc<ApiCodeDescriptor>(kBlock);
                    var target = span(buffer);
                    for(var j=0u; j<kBlock; j++)
                    {
                        ref readonly var row = ref skip(content,j);
                        store(row, ref seek(target,j));
                    }
                    dst.AddRange(buffer);

                }

            }
            return dst.OrderBy(x => x.Base).ToArray();
        }

        [Op]
        public static Index<ApiCodeDescriptor> descriptors(FS.FolderPath src)
        {
            var archive = Archives.hex(src);
            var files = archive.List();
            var dst = z.list<ApiCodeDescriptor>();
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
            dst.Base = src.Code.BaseAddress;
            dst.Size = src.Code.Length;
            dst.Uri = src.Identifier;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ApiCodeDescriptor store(in ApiCodeBlock src, ref ApiCodeDescriptor dst)
        {
            dst.Part = src.Uri.Part;
            dst.Host = src.Uri.Host.Name;
            dst.Base = src.Code.BaseAddress;
            dst.Size = src.Code.Length;
            dst.Uri = src.Identifier;
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ApiCodeDescriptor store(in ApiHexRow src, ref ApiCodeDescriptor dst)
        {
            dst.Part = src.Uri.Part;
            dst.Host = src.Uri.Host.Name;
            dst.Base = src.Address;
            dst.Size = src.Data.Length;
            dst.Uri = src.Uri.OpId.Identifier;
            return ref dst;
        }
    }
}