//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    public class ParsedEncoding : IRecord<ParsedEncoding>
    {        
        public static Option<ParsedEncoding> Parse(char delimiter, string text)
        {
            var fields = text.Split(delimiter);
            if(fields.Length == FieldCount)
            {   
                var dst = new ParsedEncoding();
                
                if(int.TryParse(fields[0], out var seq))
                    dst.Sequence = seq;

                if(int.TryParse(fields[1], out var length))
                    dst.Length = length;

                if(Enum.TryParse(fields[2], true, out CaptureTermCode tc))
                    dst.TermCode = tc;

                //dst.Uri = OpUri.Hex()

                dst.Data = Hex.parsebytes(fields[4], AsciSym.Space).ToArray();
                
            }

            return none<ParsedEncoding>();
        }

        [ReportField(Field.Sequence)]
        public int Sequence {get;set;}

        [ReportField(Field.Length)]
        public int Length {get; set;}

        [ReportField(Field.TermCode)]
        public CaptureTermCode TermCode {get; set;}

        [ReportField(Field.Uri)]
        public OpUri Uri {get;set;}

        [ReportField(Field.Data)]
        public byte[] Data {get; set;}

        public string DelimitedText(char delimiter)
        {
            var dst = text();
            dst.AppendField(Sequence, Field.Sequence);
            dst.DelimitField(Length, Field.Length,delimiter); 
            dst.DelimitField(TermCode, Field.TermCode, delimiter);
            dst.DelimitField(Uri, Field.Uri, delimiter);
            dst.DelimitField(Data.FormatHex(), Field.Data, delimiter);
            return dst.ToString();
        }

        public IReadOnlyList<string> GetHeaders()
            => Record.ReportHeaders(GetType());

        static int FieldCount {get;}
            = Enums.members<Field>().Length;

        enum Field
        {
            Sequence = 10,
            
            Length = 8,

            TermCode = 20,

            Uri = 70,

            Data = 1
        }    
    }

    partial class AsmExtend
    {
        public static AsmCode GetAsmCode(this ParsedEncoding encoding, MemoryAddress @base)
            => AsmCode.Define(encoding.Uri.OpId, MemoryRange.Define(@base, @base + (ulong)encoding.Data.Length), encoding.Data);

    }

}
