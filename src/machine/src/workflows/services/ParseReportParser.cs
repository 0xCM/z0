//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using R = MemberParseRecord;

    public readonly struct ParsedRecordParser
    {
        public static MemberParseRecord[] parse(FilePath path)
        {
            var rows = path.ReadLines();
            var count = rows.Length;
            if(count == 0)
                return sys.empty<MemberParseRecord>();

            var buffer = alloc<MemberParseRecord>(count - 1);
            ref var dst =  ref first(span(buffer));
            ref readonly var src = ref first(span(rows));

            for(var i = 1u; i<count; i++)
            {
                var j=0u;
                ref readonly var row = ref skip(src,i);
                var fields = row.SplitClean(FieldDelimiter);
                var numericParser = NumericParser.infallible<int>();
                var addressParser = MemoryAddressParser.Service;
                var dataParser = Parsers.hex(true);

                var seq = numericParser.Parse(fields[j++]);
                var srcSeq = numericParser.Parse(fields[j++]);
                var address = addressParser.Parse(fields[j++], MemoryAddress.Empty);
                var len = numericParser.Parse(fields[j++]);
                var term = Enums.Parse(fields[j++], ExtractTermCode.None);
                var uri = ApiUriParser.Service.Parse(fields[j++]);
                var sig = fields[j++];
                var data = new X86Code(address, dataParser.ParseData(fields[j++], sys.empty<byte>()));
                seek(dst,i) = new R(
                    Seq: seq,
                    SourceSequence: srcSeq,
                    Address: address,
                    Length: len,
                    TermCode: default,
                    Uri:uri.Value,
                    OpSig:sig,
                    Data:data
                );
            }
            return buffer;
        }
    }
}