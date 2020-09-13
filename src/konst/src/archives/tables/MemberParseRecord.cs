//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    using F = MemberParseField;
    using R = MemberParseRecord;

    public enum MemberParseField : uint
    {
        Seq = 0 | 12 << 16,

        SourceSeq = 1 | 12 << 16,

        Address = 2 | 16 << 16,

        Length = 3 | 8 << 16,

        TermCode = 4 | 20 << 16,

        Uri = 5 | 110 << 16,

        OpSig = 6 | 110 << 16,

        Data = 7 | 1 << 16
    }

    public struct MemberParseRecord : ITabular<F,R>
    {
        public const int FieldCount = 8;

        public int Seq;

        public int SourceSeq;

        public MemoryAddress Address;

        public int Length;

        public ExtractTermCode TermCode;

        public OpUri Uri;

        public string OpSig;

        public X86Code Data;

        public static R Empty
            => default;

        public static ParseResult<MemberParseRecord[]> load(FilePath src)
        {
            var attempts = src.ReadLines().Skip(1).Select(MemberParseRecord.Parse);
            var failed = attempts.Where(r => !r.Succeeded);
            var success = attempts.Where(r => r.Succeeded).Select(r => r.Value);
            if(failed.Length != 0 && success.Length == 0)
                return ParseResult.Fail<MemberParseRecord[]>(src.Name, failed[0].Reason);
            else
                return ParseResult.Success(src.Name, success);
        }

        static Dictionary<PartId,PartFile[]> SelectFiles(PartFileClass kind, FS.Files src, PartId[] parts)
        {
            var partSet = parts.ToHashSet();
            var files = (from f in src
                        let part = f.Owner
                        where part != PartId.None && partSet.Contains(part)
                        let pf = new PartFile(part, kind, f)
                        group pf by pf.Part).ToDictionary(x => x.Key, y => y.ToArray());
            return files;
        }

        static Dictionary<PartId,PartFile[]> ParseFileIndex(PartFiles src, params PartId[] parts)
            => SelectFiles(PartFileClass.Parsed, src.Parsed, parts);

        public static MemberParseRecord[] ParseRecords(PartFiles src, PartId part)
        {
            var files = ParseFileIndex(src, part);
            if(files.TryGetValue(part, out var partFiles))
            {
                var count = partFiles.Length;
                var view = @readonly(partFiles);
                for(var j=0; j<count; j++)
                {
                    ref readonly var file = ref skip(view, j);
                    var records = MemberParseRecord.load(file.Path);
                    if(records)
                        return records.Value;
                }
            }

            return sys.empty<MemberParseRecord>();
        }

        public static ParseResult<MemberParseRecord[]> load(FS.FilePath src)
            => load(FilePath.Define(src.Name));

        public static ParseResult<MemberParseRecord> Parse(string src)
        {
            try
            {
                var fields = src.SplitClean(FieldDelimiter);
                if(fields.Length !=  (uint)FieldCount)
                    return ParseResult.Fail<MemberParseRecord>(src,"No data");

                var dst = Empty;
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
                return ParseResult.Fail<MemberParseRecord>(src, e);
            }
        }

        public MemberParseRecord(int Seq, int SourceSequence, MemoryAddress Address, int Length,
            ExtractTermCode TermCode, OpUri Uri, string OpSig, X86Code Data)
        {
            this.Seq = Seq;
            this.SourceSeq = SourceSequence;
            this.Address = Address;
            this.Length = Length;
            this.TermCode = TermCode;
            this.Uri = Uri;
            this.OpSig = OpSig;
            this.Data = Data;
        }

        public string DelimitedText(char delimiter)
        {
            var dst = Table.formatter<F>(delimiter);
            dst.Delimit(F.Seq, Seq);
            dst.Delimit(F.SourceSeq, SourceSeq);
            dst.Delimit(F.Address, Address);
            dst.Delimit(F.Length, Length);
            dst.Delimit(F.TermCode, TermCode);
            dst.Delimit(F.Uri, Uri);
            dst.Delimit(F.OpSig, OpSig);
            dst.Delimit(F.Data, Data.Format());
            return dst.Format();
        }
    }
}