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

        public static ApiMemberCode match(IGlobalApiCatalog src, ApiCodeBlock code)
        {
            if(src.FindMethod(code.OpUri, out var method))
            {
                var member = new ApiMember(code.OpUri, method, default, method.MethodHandle.GetFunctionPointer());
                return new ApiMemberCode(member, code);
            }
            else
                return ApiMemberCode.Empty;
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
                var svc = ApiIndex.service(wf);
                var api = svc.IndexApiBlocks();
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

        [MethodImpl(Inline), Op]
        public static void emit(ReadOnlySpan<ApiHexRow> src, FS.FilePath dst)
        {
            var count = src.Length;
            if(count != 0)
                Records.emit(src,dst);
        }

        public static Index<ApiHexRow> emit(IWfShell wf, ApiHostUri uri, ReadOnlySpan<ApiMemberCode> src)
        {
            var count = src.Length;
            if(count == 0)
                wf.Warn($"No {uri} records were provided");

            if(count != 0)
            {
                var rows = ApiCode.rows(uri, src);
                if(rows.Length != count)
                {
                    wf.Error($"The distilled row count of {rows.Length} does not match the input count of {count}");
                }
                else
                {
                    var f1 = wf.Db().ApiHexFile(uri);
                    wf.EmittingTable<ApiHexRow>(f1);
                    ApiCode.emit(rows, f1);

                    var f2 = wf.Db().ParsedExtractFile(uri);
                    wf.EmittingTable<ApiHexRow>(f2);
                    ApiCode.emit(rows, f2);
                }
                return rows;
            }
            else
                return Index<ApiHexRow>.Empty;
        }

        public static Outcome emit(IWfShell wf, ApiCodeBlocks src, FS.FilePath dst)
        {
            var svc = ApiIndex.service(wf);
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
            var archive = ApiArchives.capture(wf);
            var files = archive.ApiHexFiles().View;
            var empty = Index<ApiCodeDescriptor>.Empty;
            if(files.Length == 0)
            {
                wf.Warn($"No code found");
                return empty;
            }
            var count = files.Length;

            wf.Status($"Processing {count} api hex files");

            var dst = root.list<ApiCodeDescriptor>();
            for(var i=0u; i<count; i++)
            {
                ref readonly var file = ref skip(files,i);
                wf.Processing(file, "apihex");
                var content = ApiCode.hexrows(file).View;
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

            wf.Status($"Accumulated {dst.Count} descriptors");
            return dst.OrderBy(x => x.Base).ToArray();
        }

        public static Index<ApiCodeDescriptor> descriptors(ReadOnlySpan<FS.FilePath> files)
        {
            var dst = root.list<ApiCodeDescriptor>();
            var count = files.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var file = ref skip(files,i);
                var rows = hexrows(file);
                if(rows.Count != 0)
                {
                    var content = rows.View;
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
            dst.Base = src.Code.BaseAddress;
            dst.Size = src.Code.Length;
            dst.Uri = src.Identifier;
            dst.Encoded = src.Encoded;
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
            dst.Encoded = src.Encoded;
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
}