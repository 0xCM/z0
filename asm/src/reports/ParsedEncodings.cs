//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
 
    public readonly struct ParsedEncodings : IReport<ParsedEncoding>
    {        
        public static ParsedEncodings Load(FilePath src)
            => default;

        public static ParsedEncodings Create(params ParsedEncoding[] records)
            => new ParsedEncodings(records);

        ParsedEncodings(ParsedEncoding[] records)
        {
            this.Records = records;
        }
        
        public ParsedEncoding[] Records {get;}

        public ParsedEncoding this[int index]
            => Records[index];                

        public int RecordCount
            => Records.Length;

        public Option<FilePath> Save(FilePath dst)
            => Records.Save(dst); 
    }
}