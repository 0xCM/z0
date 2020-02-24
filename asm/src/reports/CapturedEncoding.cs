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

    using static zfunc;
    

    public class CapturedEncoding : IRecord<CapturedEncoding>
    {
        [ReportField(Field.Sequence)]
        public int Sequence {get;set;}

        [ReportField(Field.Length)]
        public int Length {get; set;}

        [ReportField(Field.Host)]
        public ApiHostPath Host {get; set;}

        [ReportField(Field.OpId)]
        public OpIdentity OpId {get; set;}

        [ReportField(Field.Address)]
        public MemoryAddress Address {get; set;}

        [ReportField(Field.OpName)]
        public string OpName {get; set;}
        
        [ReportField(Field.OpSig)]
        public string OpSig {get; set;}
        
        [ReportField(Field.Data)]
        public byte[] Data {get; set;}

        public string DelimitedText(char sep)
        {
            var dst = text();
            dst.AppendField(Sequence, Field.Sequence);
            dst.DelimitField(Length, Field.Length, sep);
            dst.DelimitField(Host, Field.Host, sep);
            dst.DelimitField(OpId, Field.OpId, sep);
            dst.DelimitField(Address, Field.Address, sep); 
            dst.DelimitField(OpName, Field.OpName, sep);
            dst.DelimitField(OpSig, Field.OpSig, sep);
            dst.DelimitField(Data.FormatHex(), Field.Data, sep);
            return dst.ToString();
        }

        public IReadOnlyList<string> GetHeaders()
            => Record.ReportHeaders(GetType());

        OpUri GetOpUri()
            => Z0.OpUri.Hex(Host, OpName, OpId);

        public OpDescriptor Operation        
            => OpDescriptor.Define(GetOpUri(), OpSig);

        enum Field
        {
            Sequence = 10,

            Length = 8,

            Host = 20,

            OpId = 60,

            Address = 16,

            OpName = 14,

            OpSig = 80,

            Data = 1
        }
    }
}