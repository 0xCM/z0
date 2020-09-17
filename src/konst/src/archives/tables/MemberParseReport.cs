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

    using F = MemberParseField;
    using R = MemberParseRow;

    public class MemberParseReport : Report<MemberParseReport,F,R>
    {
        // [MethodImpl(Inline)]
        // public static MemberParseReport create(ApiHostUri host, params MemberParseRow[] src)
        //     => new MemberParseReport(host, src);

        // public static MemberParseRow[] load(PartFiles src, PartId part)
        // {
        //     var files = index(src, part);
        //     if(files.TryGetValue(part, out var partFiles))
        //     {
        //         var count = partFiles.Length;
        //         var view = @readonly(partFiles);
        //         for(var j=0; j<count; j++)
        //         {
        //             ref readonly var file = ref skip(view, j);
        //             var records = load(file.Path);
        //             if(records)
        //                 return records.Value;
        //         }
        //     }

        //     return sys.empty<MemberParseRow>();
        // }


        // static MemberParseRow[] parse(FS.FilePath path)
        // {
        //     var rows = path.ReadLines();
        //     var count = rows.Length;
        //     if(count == 0)
        //         return sys.empty<MemberParseRow>();

        //     var buffer = alloc<MemberParseRow>(count - 1);
        //     ref var dst =  ref first(span(buffer));
        //     ref readonly var src = ref first(span(rows));

        //     for(var i = 1u; i<count; i++)
        //     {
        //         var j=0u;
        //         ref readonly var row = ref skip(src,i);
        //         var fields = row.SplitClean(FieldDelimiter);
        //         var numericParser = NumericParser.infallible<int>();
        //         var addressParser = MemoryAddressParser.Service;
        //         var dataParser = Parsers.hex(true);

        //         var seq = numericParser.Parse(fields[j++]);
        //         var srcSeq = numericParser.Parse(fields[j++]);
        //         var address = addressParser.Parse(fields[j++], MemoryAddress.Empty);
        //         var len = numericParser.Parse(fields[j++]);
        //         var term = Enums.Parse(fields[j++], ExtractTermCode.None);
        //         var uri = ApiUriParser.Service.Parse(fields[j++]);
        //         var sig = fields[j++];
        //         var data = new X86Code(address, dataParser.ParseData(fields[j++], sys.empty<byte>()));
        //         seek(dst,i) = new R(
        //             Seq: seq,
        //             SourceSequence: srcSeq,
        //             Address: address,
        //             Length: len,
        //             TermCode: default,
        //             Uri:uri.Value,
        //             OpSig:sig,
        //             Data:data
        //         );
        //     }
        //     return buffer;
        // }

        public ApiHostUri ApiHost {get;}

        public static ParseResult<MemberParseRow[]> load(FS.FilePath src)
            => load(FilePath.Define(src.Name));

        static ParseResult<MemberParseRow[]> load(FilePath src)
        {
            var attempts = src.ReadLines().Skip(1).Select(MemberParseReport.row);
            var failed = attempts.Where(r => !r.Succeeded);
            var success = attempts.Where(r => r.Succeeded).Select(r => r.Value);
            if(failed.Length != 0 && success.Length == 0)
                return ParseResult.Fail<MemberParseRow[]>(src.Name, failed[0].Reason);
            else
                return ParseResult.Success(src.Name, success);
        }

        static MemberParseRow record(in X86ApiMember extract, uint seq)
            => new MemberParseRow
                (
                    Seq : (int)seq,
                    SourceSequence: (int)extract.Sequence,
                    Address : extract.Address,
                    Length : extract.Encoded.Length,
                    TermCode: extract.TermCode,
                    Uri : extract.OpUri,
                    OpSig : extract.Method.Signature().Format(),
                    Data : extract.Encoded
                );

        public static MemberParseRow[] create(ApiHostUri host, X86ApiMembers members)
        {
            var count = members.Count;
            var buffer = alloc<R>(count);
            var dst = span(buffer);
            var src = members.View;
            for(var i=0u; i<count; i++)
                seek(dst,i) = record(skip(src,i), i);
            return buffer;
            //return new MemberParseReport(host, buffer);
        }

        [MethodImpl(Inline)]
        public static Option<FilePath> save(MemberParseRow[] src, FS.FilePath dst)
            => Log.Save(src, dst);

        static ParseResult<MemberParseRow> row(string src)
        {
            try
            {
                var fields = src.SplitClean(FieldDelimiter);
                if(fields.Length !=  (uint)R.FieldCount)
                    return ParseResult.Fail<MemberParseRow>(src,"No data");

                var dst = new R();
                var index = 0;
                dst.Seq = NumericParser.succeed<int>(fields[index++]);
                dst.SourceSeq = NumericParser.succeed<int>(fields[index++]);
                dst.Address = MemoryAddressParser.succeed(fields[index++]);
                dst.Length = NumericParser.succeed<int>(fields[index++]);
                dst.TermCode = Enums.Parse(fields[index++], ExtractTermCode.None);
                dst.Uri = ApiUriParser.Service.Parse(fields[index++]).Require();
                dst.OpSig = fields[index++];
                dst.Data = new X86Code(dst.Address, Parsers.hex(true).ParseData(fields[index++], sys.empty<byte>()));
                return ParseResult.Success(src, dst);
            }
            catch(Exception e)
            {
                return ParseResult.Fail<MemberParseRow>(src, e);
            }
        }

        public MemberParseReport(){}

        [MethodImpl(Inline)]
        internal MemberParseReport(ApiHostUri host, params MemberParseRow[] src)
            : base(src)
        {
            ApiHost = host;
        }


        // static Dictionary<PartId,PartFile[]> select(PartFileClass kind, FS.Files src, PartId[] parts)
        // {
        //     var partSet = parts.ToHashSet();
        //     var files = (from f in src
        //                 let part = f.Owner
        //                 where part != PartId.None && partSet.Contains(part)
        //                 let pf = new PartFile(part, kind, f)
        //                 group pf by pf.Part).ToDictionary(x => x.Key, y => y.ToArray());
        //     return files;
        // }

        // static Dictionary<PartId,PartFile[]> index(PartFiles src, params PartId[] parts)
        //     => select(PartFileClass.Parsed, src.Parsed, parts);
    }
}