//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
   
    using static Seed;
    using static Memories;

    public readonly struct ExtractReportParser : IExtractReportParser
    {
        [MethodImpl(Inline)]
        public static IExtractReportParser Create(ILocatedCodeParser located)
            => new ExtractReportParser(located);

        readonly ILocatedCodeParser LocatedParser;
        
        [MethodImpl(Inline)]
        internal ExtractReportParser(ILocatedCodeParser located)
        {
            this.LocatedParser = located;
        }

        public MemberParseReport Parse(ApiHostUri host, ExtractReport report)
        {
            var parser = LocatedParser;
            var records = list<MemberParseRecord>(report.RecordCount);                
            var seq = 0;
            for(var i=0; i< report.RecordCount; i++)
            {
                ref readonly var extract = ref report.Records[i];  
                var result = parser.Parse(extract.Data);

                if(result)
                {
                    var uri = OpUri.hex(host, extract.Uri.GroupName, extract.Uri.OpId);
                    var data = LocatedCode.Define(extract.Address, result.Value.Encoded);
                    var record = MemberParseRecord.Define
                    (
                        Sequence: seq++,
                        SourceSequence: extract.Sequence,
                        Address: extract.Address,
                        Length: data.Bytes.Length,
                        TermCode: default,
                        Uri: uri,
                        OpSig: extract.OpSig,
                        Data: data
                    );
                    records.Add(record);               
                }
            }
            
            return MemberParseReport.Create(host, records.ToArray());
        }
    }
}