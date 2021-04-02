//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public class ApiHex : WfService<ApiHex>
    {
        [Op]
        public static IApiHexReader reader(IWfShell wf)
            => ApiHexReader.create(wf);

        public static Count emit(ReadOnlySpan<ApiHexRow> src, FS.FilePath dst)
            => src.Length != 0 ? Tables.emit(src,dst) : 0;

        [Op]
        public static Index<ApiHexRow> emit(IWfShell wf, ApiHostUri uri, ReadOnlySpan<ApiMemberCode> src)
        {
            var count = src.Length;
            if(count != 0)
            {
                var content = rows(uri, src);
                var hexpath = wf.Db().ApiHexFile(uri);
                if(content.Length != count)
                    wf.Error($"The distilled row count of {content.Length} does not match the input count of {count}");
                else
                {
                    var fa = wf.EmittingTable<ApiHexRow>(hexpath);
                    emit(content, hexpath);
                    wf.EmittedTable(fa,count);

                    var b = wf.Db().ParsedExtractFile(uri);
                    var fb = wf.EmittingTable<ApiHexRow>(b);
                    emit(content, b);
                    wf.EmittedTable(fb,count);
                }
                return content;
            }
            else
                return sys.empty<ApiHexRow>();
        }

        [MethodImpl(Inline), Op]
        public static ApiCodeBlock block(ApiHexRow src)
            => new ApiCodeBlock(src.Address, src.Uri, src.Data);

        public Index<ApiHexRow> Rows(FS.FilePath src)
        {
            var data = @readonly(src.ReadLines().Storage.Skip(1));
            var count = data.Length;
            var buffer = root.list<ApiHexRow>(count);
            for(var i=0; i<count; i++)
            {
                var input = skip(data,i);
                if(Parse(input, out var dst))
                    buffer.Add(dst);
                else
                    Wf.Error(string.Format("Parse failure for source text {0}", input));
            }
            return buffer.ToArray();
        }

        public bool Parse(string src, out ApiHexRow dst)
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
                if(fields.Length !=  (uint)ApiHexRowSpec.FieldCount)
                {
                    Wf.Error($"Found {fields.Length} but {ApiHexRowSpec.FieldCount} are required");
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

        public FS.FilePath EmitHexIndex(in ApiCodeBlocks src)
        {
            var dst = Db.IndexFile(ApiHexIndexRow.TableId);
            var flow = Wf.EmittingFile(dst);
            EmitHexIndex(src, dst);
            Wf.EmittedFile(flow,1);
            return dst;
        }

        [Op]
        Outcome EmitHexIndex(in ApiCodeBlocks src, FS.FilePath dst)
        {
            Array.Sort(src.Blocks.Storage);
            var blocks = src.Blocks.View;
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
                record.Uri = block.Uri;
                emitter.Emit(record);
            }
            return true;
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
    }
}