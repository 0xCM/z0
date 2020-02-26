//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using Z0.Asm;
    

    public class CapturedEncodingRecord : IRecord<CapturedEncodingRecord>
    {
        enum Field
        {
            Sequence = 10,

            Address = 16,

            Length = 8,

            Uri = 90,

            Data = 1
        }

        [ReportField(Field.Sequence)]
        public int Sequence {get;set;}

        [ReportField(Field.Address)]
        public MemoryAddress Address {get; set;}

        [ReportField(Field.Length)]
        public int Length {get; set;}

        [ReportField(Field.Uri)]
        public OpUri Uri {get; set;}
        
        [ReportField(Field.Data)]
        public EncodedData Data {get; set;}

        public string OpSig;

        public string DelimitedText(char sep)
        {
            var dst = text.factory.Builder();
            dst.AppendField(Sequence, Field.Sequence);
            dst.DelimitField(Address, Field.Address, sep); 
            dst.DelimitField(Length, Field.Length, sep);
            dst.DelimitField(Uri, Field.Uri, sep);
            dst.DelimitField(Data, Field.Data, sep);
            return dst.ToString();
        }

        public IReadOnlyList<string> GetHeaders()
            => Record.ReportHeaders(GetType());

    }
}