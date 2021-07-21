//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static Root;
    using static core;

    [ApiHost]
    public class ApiHex : AppService<ApiHex>
    {
        public FS.FolderPath HexRoot()
            => Db.ParsedExtractRoot();

        public FS.FolderPath HexRoot(FS.FolderPath root)
            => Db.ParsedExtractRoot(root);

        [Op]
        public FS.Files Files()
            => HexRoot().Files(FS.PCsv);

        [Op]
        public FS.Files Files(FS.FolderPath root)
            => HexRoot(root).Files(FS.PCsv);

        [Op]
        public ApiCodeBlocks ReadBlocks()
            => ReadBlocks(Db.ParsedExtractPaths());

        public ApiCodeBlocks ReadBlocks(FS.FolderPath src)
            => ReadBlocks(Db.ParsedExtractPaths(src));

        [Op]
        ApiCodeBlock LoadBlock(ApiHexRow src)
        {
            if(src.Uri.IsEmpty)
                Wf.Warn(string.Format("The operation uri for method based at {0} is empty", src.Address));
            return new ApiCodeBlock(src.Address, src.Uri, src.Data);
        }

        public ReadOnlySpan<ApiHostBlocks> ReadHostBlocks(ReadOnlySpan<ApiHostUri> src)
        {
            var count = src.Length;
            var dst = list<ApiHostBlocks>();
            for(var i=0; i<count; i++)
                dst.Add(ReadBlocks(skip(src,i)));
            return dst.ViewDeposited();
        }

        public Index<ApiHostBlocks> ReadHostBlocks(FS.FolderPath root, ReadOnlySpan<ApiHostUri> src)
        {
            var count = src.Length;
            var dst = list<ApiHostBlocks>();
            for(var i=0; i<count; i++)
                dst.Add(ReadBlocks(root, skip(src,i)));
            return dst.ToArray();
        }

        public ReadOnlySpan<ApiHostBlocks> ReadHostBlocks()
            => ReadHostBlocks(HexRoot());

        public ReadOnlySpan<ApiHostBlocks> ReadHostBlocks(FS.FolderPath root)
        {
            var flow = Wf.Running(string.Format("Loading host blocks from {0}", root));
            var files = Files(root).View;
            var count = files.Length;
            var dst = list<ApiHostBlocks>();
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var file = ref skip(files,i);
                if(InferHost(file.FileName, out var host))
                {
                    var blocks = ReadBlocks(root, host);
                    dst.Add(blocks);
                    counter += blocks.Count;
                }
                else
                    Wf.Warn(string.Format("Unable to infer host for {0}", file.ToUri()));
            }

            var deposited = dst.ViewDeposited();
            Wf.Ran(flow,string.Format("Loaded {0} blocks from {1} hosts", counter, deposited.Length));

            return deposited;
        }

        [Op]
        public ApiHostBlocks ReadBlocks(ApiHostUri host)
            => new ApiHostBlocks(host, ReadBlocks(Db.ParsedExtractPath(host)));

        [Op]
        public ApiHostBlocks ReadBlocks(FS.FolderPath root, ApiHostUri host)
            => new ApiHostBlocks(host, ReadBlocks(Db.ParsedExtractPath(root,host)));

        [Op]
        public Index<ApiCodeBlock> ReadBlocks(FS.FilePath src)
        {
            var flow = Wf.Flow(string.Format("Reading blocks from {0}", src.ToUri()));
            var loaded = ReadRows(src);
            var rowcount = loaded.Length;
            var blocks = list<ApiCodeBlock>(256);
            if(rowcount != 0)
            {
                var rows = loaded;
                for(var j=0; j<rowcount; j++)
                    blocks.Add(LoadBlock(skip(rows, j)));
            }
            Wf.Ran(flow, string.Format("Read {0} blocks from {1}", blocks.Count, src));
            return blocks.ToArray();
        }

        [Op]
        public Count ReadBlocks(FS.FilePath src, List<ApiCodeBlock> dst)
        {
            var rows = new DataList<ApiHexRow>(1600);
            var count = ReadRows(src, rows);
            for(var i=0; i<count; i++)
                dst.Add(LoadBlock(rows[i]));
            return count;
        }

        [Op]
        public ApiCodeBlocks ReadBlocks(FS.Files src)
        {
            var count = src.Length;
            if(count == 0)
                return ApiCodeBlocks.Empty;

            var flow = Wf.Running(Msg.LoadingHexFileBlocks.Format(count));
            var view = src.View;
            var blocks = list<ApiCodeBlock>(32000);
            var counter = 0;
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(view,i);
                var loaded = ReadRows(path);
                var rowcount = loaded.Length;
                if(rowcount != 0)
                {
                    var rows = loaded;
                    for(var j=0; j<rowcount; j++)
                        blocks.Add(LoadBlock(skip(rows, j)));
                }

                counter += rowcount;
            }

            Wf.Ran(flow, Msg.LoadedHexBlocks.Format(counter));

            return new ApiCodeBlocks(blocks.ToArray());
        }

        [Op]
        public Index<ApiHexRow> WriteBlocks(ApiHostUri uri, ReadOnlySpan<ApiMemberCode> src, FS.FolderPath dst)
        {
            var count = src.Length;
            if(count != 0)
            {
                var content = rows(uri, src);
                var path = Db.ParsedExtractPath(dst, uri);
                var emitting = Wf.EmittingTable<ApiHexRow>(path);
                emit(content, path);
                Wf.EmittedTable(emitting,count);
                return content;
            }
            else
                return array<ApiHexRow>();
        }

        [Op]
        public Index<ApiHexRow> WriteBlocks(ApiHostUri uri, ReadOnlySpan<ApiMemberCode> src, FS.FilePath dst)
        {
            var count = src.Length;
            if(count != 0)
            {
                var emitting = Wf.EmittingTable<ApiHexRow>(dst);
                var rows = alloc<ApiHexRow>(count);
                fill(uri, src, rows);
                emit(rows, dst);
                Wf.EmittedTable(emitting, count);
                return rows;
            }
            else
                return array<ApiHexRow>();
        }

        [Op]
        public ReadOnlySpan<ApiHexRow> ReadRows(FS.FilePath src)
        {
            var data = @readonly(src.ReadLines().Storage.Skip(1));
            var count = data.Length;
            var dst = list<ApiHexRow>(count);
            var flow = Wf.Running(string.Format("Reading hex rows from {0}", src.ToUri()));
            for(var i=0; i<count; i++)
            {
                var input = skip(data,i);
                if(ParseRow(input, out var row))
                    dst.Add(row);
                else
                    Wf.Error(string.Format("Unable to parse {0}", input));
            }
            var result = dst.ViewDeposited();
            Wf.Ran(flow,string.Format("Read {0} hex rows from {1}", result.Length, src.ToUri()));
            return result;
        }

        [Op]
        public Count ReadRows(FS.FilePath src, DataList<ApiHexRow> dst)
        {
            var data = @readonly(src.ReadLines().Storage.Skip(1));
            var count = data.Length;
            var buffer = list<ApiHexRow>(count);
            var j=0;
            for(var i=0; i<count; i++)
            {
                var input = skip(data,i);
                if(ParseRow(input, out var row))
                {
                    dst.Add(row);
                    j++;
                }
                else
                    Wf.Error(string.Format("Parse failure for source text {0}", input));
            }
            return count;
        }

        [Op]
        public bool ParseRow(string src, out ApiHexRow dst)
        {
            dst = new ApiHexRow();
            try
            {
                if(empty(src))
                {
                    Wf.Error("No text!");
                    return false;
                }

                var fields = text.slice(src,1).SplitClean(FieldDelimiter);
                if(fields.Length !=  (uint)ApiHexRow.FieldCount)
                {
                    Wf.Error($"Found {fields.Length} but {ApiHexRow.FieldCount} are required");
                    return false;
                }

                var index = 0;
                DataParser.parse(fields[index++], out dst.Seq);
                DataParser.parse(fields[index++], out dst.SourceSeq);
                DataParser.parse(fields[index++], out dst.Address);
                DataParser.parse(fields[index++], out dst.Length);
                DataParser.eparse(fields[index++], out dst.TermCode);
                DataParser.parse(fields[index++], out dst.Uri);
                DataParser.parse(fields[index++], out dst.Data);
                return true;
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return false;
            }
        }

        [Op]
        public ReadOnlySpan<ApiHexIndexRow> EmitIndex(Index<ApiCodeBlock> src)
        {
            var dst = Db.IndexFile(ApiHexIndexRow.TableId);
            return EmitIndex(src, dst);
        }

        [Op]
        public ReadOnlySpan<ApiHexIndexRow> EmitIndex(Index<ApiCodeBlock> src, FS.FilePath dst)
        {
            Array.Sort(src.Storage);
            return EmitIndex(Spans.sorted(src.View), dst);
        }

        [Op]
        public ReadOnlySpan<ApiHexIndexRow> EmitIndex(ApiCodeBlocks src, FS.FilePath dst)
        {
            return EmitIndex(Spans.sorted(src.View), dst);
        }

        [Op]
        ReadOnlySpan<ApiHexIndexRow> EmitIndex(SortedReadOnlySpan<ApiCodeBlock> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<ApiHexIndexRow>(dst);
            var blocks = src.View;
            var count = blocks.Length;
            var buffer = alloc<ApiHexIndexRow>(count);
            var target = span(buffer);
            var parts = PartNames.NameLookup();
            using var emitter = Tables.emitter<ApiHexIndexRow>(array<byte>(10, 16, 20, 20, 20, 120), dst);
            emitter.EmitHeader();
            for(var i=0u; i<count; i++)
            {
                ref readonly var block = ref skip(blocks,i);
                ref var record = ref seek(target, i);
                record.Seqence = i;
                record.Address = block.BaseAddress;
                parts.TryGetValue(block.OpUri.Part, out var name);
                record.Component = name.IsEmpty ? block.OpUri.Part.Format() : name.Format();
                record.HostName = block.OpUri.Host.HostName;
                record.MethodName = block.OpId.Name;
                record.Uri = block.OpUri;
                emitter.Emit(record);
            }

            Wf.EmittedTable(flow, count);
            return buffer;
        }

        [Op]
        static ApiHexRow[] rows(ApiHostUri host, ReadOnlySpan<ApiMemberCode> src)
        {
            var count = src.Length;
            var buffer = alloc<ApiHexRow>(count);
            if(count != 0)
            {
                ref var dst = ref first(buffer);
                for(var i=0u; i<count; i++)
                    fill(skip(src, i), i, out seek(dst, i));
            }
            return buffer;
        }

        [Op]
        static void fill(ApiHostUri host, ReadOnlySpan<ApiMemberCode> src, Span<ApiHexRow> dst)
        {
            var count = src.Length;
            if(count != 0)
            {
                for(var i=0u; i<count; i++)
                    fill(skip(src, i), i, out seek(dst, i));
            }
        }

        [Op]
        static void fill(in ApiMemberCode src, uint seq, out ApiHexRow dst)
        {
            dst.Seq = (int)seq;
            dst.SourceSeq = (int)src.Sequence;
            dst.Address = src.Address;
            dst.Length = src.Encoded.Length;
            dst.TermCode = src.TermCode;
            dst.Uri = src.OpUri;
            dst.Data = src.Encoded;
        }

        [Op]
        static Count emit(ReadOnlySpan<ApiHexRow> src, FS.FilePath dst)
            => src.Length != 0 ? Tables.emit(src, dst) : 0;

        static Outcome InferHost(FS.FileName src, out ApiHostUri host)
        {
            var components = @readonly(src.Name.Text.Remove(".p.csv").SplitClean(Chars.Dot));
            var count = components.Length;
            if(count >= 2)
            {
                if(ApiPartIdParser.parse(first(components), out var part))
                {
                    host =  new ApiHostUri(part, slice(components,1).Join(Chars.Dot));
                    return true;
                }
            }
            host = ApiHostUri.Empty;
            return false;
        }
    }
}