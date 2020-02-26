//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.Asm;

    using static zfunc;

    public class ParsedEncodingRecord : IRecord<ParsedEncodingRecord>
    {        
        public static Option<ParsedEncodingRecord> Parse(char delimiter, string text)
        {
            var fields = text.Split(delimiter);
            if(fields.Length == FieldCount)
            {   
                var dst = new ParsedEncodingRecord();
                
                if(int.TryParse(fields[0], out var seq))
                    dst.Sequence = seq;

                if(int.TryParse(fields[1], out var length))
                    dst.Length = length;

                if(Enum.TryParse(fields[2], true, out CaptureTermCode tc))
                    dst.TermCode = tc;

                dst.Data = Hex.parsebytes(fields[4], AsciSym.Space).ToArray();                
            }

            return none<ParsedEncodingRecord>();
        }

        enum Field
        {
            Sequence = 10,

            Address = 16,

            Length = 8,

            TermCode = 20,

            Uri = 90,

            Data = 1
        }    

        [ReportField(Field.Sequence)]
        public int Sequence {get;set;}

        [ReportField(Field.Address)]
        public MemoryAddress Address {get; set;}

        [ReportField(Field.Length)]
        public int Length {get; set;}

        [ReportField(Field.TermCode)]
        public CaptureTermCode TermCode {get; set;}

        [ReportField(Field.Uri)]
        public OpUri Uri {get;set;}

        [ReportField(Field.Data)]
        public EncodedData Data {get; set;}

        public string DelimitedText(char sep)
        {
            var dst = text.factory.Builder();
            dst.AppendField(Sequence, Field.Sequence);
            dst.DelimitField(Address, Field.Address, sep); 
            dst.DelimitField(Length, Field.Length,sep); 
            dst.DelimitField(TermCode, Field.TermCode, sep);
            dst.DelimitField(Uri, Field.Uri, sep);
            dst.DelimitField(Data, Field.Data, sep);
            return dst.ToString();
        }

        public IReadOnlyList<string> GetHeaders()
            => Record.ReportHeaders(GetType());

        static int FieldCount {get;}
            = Enums.literals<Field>().Length;

    }
}