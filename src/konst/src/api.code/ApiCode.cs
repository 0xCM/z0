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
        [MethodImpl(Inline)]
        public static ApiCodeset codeset(FS.FilePath location, Index<ApiCodeBlock> blocks)
            => new ApiCodeset(location, blocks);

        public static IApiHexWriter writer(IWfShell wf, FS.FilePath dst)
            => new ApiHexWriter(dst);

        public static IApiHexReader reader(IWfShell wf)
            => ApiHexReader.create(wf);

        public static Count emit(ReadOnlySpan<ApiHexRow> src, FS.FilePath dst)
            => src.Length != 0 ? Records.emit(src,dst) : 0;

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

        [Op]
        public static bool parse(string src, out ApiHexRow dst)
        {
            dst = new ApiHexRow();
            try
            {
                if(text.empty(src))
                {
                    term.error("No text!");
                    return false;
                }

                var fields = text.slice(src,1).SplitClean(FieldDelimiter);
                if(fields.Length !=  (uint)ApiHexRowSpec.FieldCount)
                {
                    term.error($"Found {fields.Length} but {ApiHexRowSpec.FieldCount} are required");
                    return false;
                }

                var index = 0;
                dst.Seq = Numeric.parse<int>(fields[index++]).ValueOrDefault();
                dst.SourceSeq = Numeric.parse<int>(fields[index++]).ValueOrDefault();
                dst.Address = MemoryAddressParser.succeed(fields[index++]);
                dst.Length = Numeric.parse<int>(fields[index++]).ValueOrDefault();
                dst.TermCode = Enums.parse(fields[index++], ExtractTermCode.None);
                dst.Uri = ApiUri.parse(fields[index++]).Require();
                dst.Data = new CodeBlock(dst.Address, HexParsers.bytes().ParseData(fields[index++], sys.empty<byte>()));
                return true;
            }
            catch(Exception e)
            {
                term.error(e);
                return false;
            }
        }

        [MethodImpl(Inline), Op]
        public static ApiCodeBlock block(ApiHexRow src)
            => new ApiCodeBlock(src.Address, src.Uri, src.Data);

        [Op]
        public static Index<ApiHexRow> hexrows(FS.FilePath src)
        {
            var data = @readonly(src.ReadLines().Storage.Skip(1));
            var count = data.Length;
            var buffer = root.list<ApiHexRow>(count);
            for(var i=0; i<count; i++)
            {
                if(parse(skip(data,i), out var dst))
                    buffer.Add(dst);
            }
            return buffer.ToArray();
        }

        [MethodImpl(Inline), Op]
        public static ApiPartCode combine(PartId part, ApiHostCode[] src)
            => new ApiPartCode(part,src);

        [MethodImpl(Inline), Op]
        public static Pair<ByteSize> sizes(ReadOnlySpan<ApiCaptureBlock> src)
        {
            var input = ByteSize.Zero;
            var output = ByteSize.Zero;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(src,i);
                input += block.InputSize;
                output += block.OutputSize;
            }
            return (input,output);
        }

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

        [Op]
        public static IEnumerable<ApiCodeBlock> withArity(IEnumerable<ApiCodeBlock> src, int count)
            => from code in src
                where ApiCode.arity(code) == count
                select code;

        public static Outcome<FS.FilePath> EmitHexIndex(IWfShell wf)
        {
            try
            {
                var dst = wf.Db().IndexFile(ApiHexIndexRow.TableId);
                var flow = wf.EmittingFile(dst);
                var svc = ApiHexIndex.create(wf);
                index(wf, svc.IndexApiBlocks(), dst);
                wf.EmittedFile(flow);
                return dst;
            }
            catch(Exception e)
            {
                wf.Error(e);
                return e;
            }
        }

        static Outcome index(IWfShell wf, ApiCodeBlocks src, FS.FilePath dst)
        {
            var svc = ApiHexIndex.create(wf);
            Array.Sort(src.Blocks.Storage);
            var blocks = src.Blocks.View;
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
        public static Index<ApiCodeDescriptor> descriptors(IWfShell wf)
        {
            var paths = ApiArchives.paths(wf);
            var files = paths.ApiHexFiles().View;
            var empty = Index<ApiCodeDescriptor>.Empty;
            if(files.Length == 0)
            {
                wf.Warn($"No code found in {paths.ApiHexRoot()}");
                return empty;
            }

            var count = files.Length;
            var flow = wf.Running(Msg.ProcessingApiHexFiles.Format(count));
            var dst = root.list<ApiCodeDescriptor>();
            for(var i=0u; i<count; i++)
            {
                ref readonly var file = ref skip(files,i);
                var inner = wf.Running(file, "apihex");
                var rows = hexrows(file).View;
                var blocks = rows.Length;
                if(blocks == 0)
                    wf.Warn($"No content found in {file.ToUri()}");
                else
                {
                    var buffer = alloc<ApiCodeDescriptor>(blocks);
                    var target = span(buffer);
                    for(var j=0u; j<blocks; j++)
                        store(skip(rows,j), ref seek(target,j));
                    dst.AddRange(buffer);
                    wf.Ran(inner, blocks);
                }
            }

            wf.Ran(flow, Msg.AccumulatedDescriptors.Format(dst.Count));
            return dst.OrderBy(x => x.Base).ToArray();
        }

        [MethodImpl(Inline), Op]
        public static ref ApiCodeDescriptor store(in ApiHexRow src, ref ApiCodeDescriptor dst)
        {
            dst.Part = src.Uri.Part;
            dst.Host = src.Uri.Host.Name;
            dst.Base = src.Address;
            dst.Size = src.Data.Length;
            dst.Uri = src.Uri.UriText;
            dst.Encoded = src.Data;
            return ref dst;
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

    partial struct Msg
    {
        public static MsgPattern<Count> ProcessingApiHexFiles => "Processing {0} api hex files";

        public static MsgPattern<Count> AccumulatedDescriptors => "Accumulated {0} descriptors";

    }
}