//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    [ApiHost]
    public class ApiHex : WfService<ApiHex>
    {
        public FS.Files Files(FS.FolderPath src)
            => src.Files(FS.PCsv);

        public FS.Files Files()
            => Db.ApiHexRoot().Files(FS.PCsv);

        [MethodImpl(Inline), Op]
        public static ApiCodeBlock block(ApiHexRow src)
            => new ApiCodeBlock(src.Address, src.Uri, src.Data);

        public Index<ApiCodeBlock> ReadBlocks()
            => ReadBlocks(Db.ApiHexPaths());

        public Index<HexPacked> BuildHexPack(bool validate = false)
        {
            return BuildHexPack(ReadBlocks(), validate);
        }

        public Index<HexPacked> BuildHexPack(Index<ApiCodeBlock> src, bool validate = false)
        {
            var blocks = src.Sort().View;
            var count = blocks.Length;
            var packs = alloc<HexPacked>(count);
            ref var dst = ref first(packs);
            var size = Hex.hexpack(blocks, packs);
            if(validate)
            {
                var buffer = span<HexDigit>(48400);
                var flow = Wf.Running("Validating pack");
                for(var i=0; i<count; i++)
                {
                    buffer.Clear();
                    ref readonly var pack = ref skip(dst,i);
                    var outcome = Hex.digits(pack.Data,buffer);
                    if(!outcome)
                    {
                        Wf.Error("Reconstitution failed");
                        break;
                    }
                }
                Wf.Ran(flow,$"Validated {count} packs");
            }

            return packs;
        }

        public Index<HexPacked> EmitHexPack(FS.FilePath dst, bool validate = false)
        {
            var result = BuildHexPack(validate);
            var packed = result.View;
            var emitting = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            var count = packed.Length;
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(packed,i).Format());
            Wf.EmittedFile(emitting, count);
            return result;
        }

        public Index<HexPacked> EmitHexPack(Index<ApiCodeBlock> blocks, FS.FilePath? dst = null, bool validate = false)
        {
            var _dst = dst ?? Db.TableRoot() + FS.file("apihex", FS.ext("xpack"));
            var result = BuildHexPack(blocks,validate);
            var packed = result.View;
            var emitting = Wf.EmittingFile(_dst);
            using var writer = _dst.Writer();
            var count = packed.Length;
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(packed,i).Format());
            Wf.EmittedFile(emitting, count);
            return result;
        }

        public Index<HexPacked> EmitHexPack(bool validate = false)
        {
            var dst = Db.TableRoot() + FS.file("apihex", FS.ext("xpack"));
            return EmitHexPack(dst,validate);
        }

        public Index<ApiCodeBlock> ReadBlocks(FS.FilePath src)
        {
            var loaded = ReadRows(src);
            var rowcount = loaded.Length;
            var blocks = root.list<ApiCodeBlock>(128);
            if(rowcount != 0)
            {
                var rows = loaded.View;
                for(var j=0; j<rowcount; j++)
                    blocks.Add(block(skip(rows, j)));
            }
            return blocks.ToArray();
        }

        public Count ReadBlocks(FS.FilePath src, List<ApiCodeBlock> dst)
        {
            var rows = new RecordList<ApiHexRow>(1600);
            var count = ReadRows(src, rows);
            for(var i=0; i<count; i++)
            {
                dst.Add(block(rows[i]));
            }
            return count;
        }

        public Index<ApiCodeBlock> ReadBlocks(FS.Files src)
        {
            var count = src.Length;
            if(count == 0)
                return Index<ApiCodeBlock>.Empty;

            var flow = Wf.Running(string.Format("Loading api blocks from {0} files", count));
            var view = src.View;
            var blocks = root.list<ApiCodeBlock>(32000);
            var counter = 0;
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(view,i);
                var loaded = ReadRows(path);
                var rowcount = loaded.Length;
                if(rowcount != 0)
                {
                    var rows = loaded.View;
                    for(var j=0; j<rowcount; j++)
                        blocks.Add(block(skip(rows, j)));
                }

                counter += rowcount;
            }

            Wf.Ran(flow, string.Format("Loaded {0} api blocks", counter));

            return blocks.ToArray();
        }

        public Index<ApiHexRow> WriteBlocks(ApiHostUri uri, ReadOnlySpan<ApiMemberCode> src, FS.FolderPath dst)
        {
            var count = src.Length;
            if(count != 0)
            {
                var content = rows(uri, src);
                var path = Db.ApiHexPath(dst, uri);
                var emitting = Wf.EmittingTable<ApiHexRow>(path);
                emit(content, path);
                Wf.EmittedTable(emitting,count);
                return content;
            }
            else
                return sys.empty<ApiHexRow>();
        }

        [Op]
        public Index<ApiHexRow> WriteBlocks(ApiHostUri uri, ReadOnlySpan<ApiMemberCode> src, FS.FilePath dst)
        {
            var count = src.Length;
            if(count != 0)
            {
                var content = rows(uri, src);
                var emitting = Wf.EmittingTable<ApiHexRow>(dst);
                emit(content, dst);
                Wf.EmittedTable(emitting, count);
                return content;
            }
            else
                return sys.empty<ApiHexRow>();
        }

        public Index<ApiHexRow> ReadRows(FS.FilePath src)
        {
            var data = @readonly(src.ReadLines().Storage.Skip(1));
            var count = data.Length;
            var buffer = root.list<ApiHexRow>(count);
            for(var i=0; i<count; i++)
            {
                var input = skip(data,i);
                if(ParseRow(input, out var dst))
                    buffer.Add(dst);
                else
                    Wf.Error(string.Format("Parse failure for source text {0}", input));
            }
            return buffer.ToArray();
        }

        public Count ReadRows(FS.FilePath src, RecordList<ApiHexRow> dst)
        {
            var data = @readonly(src.ReadLines().Storage.Skip(1));
            var count = data.Length;
            var buffer = root.list<ApiHexRow>(count);
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

        public bool ParseRow(string src, out ApiHexRow dst)
        {
            dst = new ApiHexRow();
            try
            {
                if(text.empty(src))
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
        public Index<ApiHexIndexRow> EmitIndex(Index<ApiCodeBlock> src)
        {
            var dst = Db.IndexFile(ApiHexIndexRow.TableId);
            return EmitIndex(src, dst);
        }

        [Op]
        public Index<ApiHexIndexRow> EmitIndex(Index<ApiCodeBlock> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<ApiHexIndexRow>(dst);
            Array.Sort(src.Storage);
            var blocks = src.View;
            var count = blocks.Length;
            var buffer = sys.alloc<ApiHexIndexRow>(count);
            var target = span(buffer);
            using var emitter = Tables.emitter<ApiHexIndexRow>(sys.array<byte>(10, 16, 20, 20, 20, 120), dst);
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
                var dst = span(buffer);
                for(var i=0u; i<count; i++)
                    seek(dst, i) = row(skip(src, i), i);
            }
            return buffer;
        }

        [MethodImpl(Inline), Op]
        static ApiHexRow row(in ApiMemberCode src, uint seq)
        {
            var dst = new ApiHexRow();
            dst.Seq = (int)seq;
            dst.SourceSeq = (int)src.Sequence;
            dst.Address = src.Address;
            dst.Length = src.Encoded.Length;
            dst.TermCode = src.TermCode;
            dst.Uri = src.OpUri;
            dst.Data = src.Encoded;
            return dst;
        }

        static Count emit(ReadOnlySpan<ApiHexRow> src, FS.FilePath dst)
            => src.Length != 0 ? Tables.emit(src, dst) : 0;
    }
}