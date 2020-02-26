//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
 
    public readonly struct ParsedEncodingReport : IReport<ParsedEncodingRecord>
    {        
        public static ParsedEncodingReport Load(FilePath src)
            => default;

        public static ParsedEncodingReport Create(params ParsedEncodingRecord[] records)
            => new ParsedEncodingReport(records);

        ParsedEncodingReport(ParsedEncodingRecord[] records)
        {
            this.Records = records;
        }
        
        public ParsedEncodingRecord[] Records {get;}

        public ParsedEncodingRecord this[int index]
            => Records[index];                

        public int RecordCount
            => Records.Length;

        public Option<FilePath> Save(FilePath dst)
            => Records.Save(dst); 
    }
}