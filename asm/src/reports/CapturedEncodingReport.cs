//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
 
    public readonly struct CapturedEncodingReport : IReport<CapturedEncodingRecord>
    {
        public static CapturedEncodingReport Create(ApiHost src, CapturedEncodingRecord[] records)
            => new CapturedEncodingReport(src,records);

        CapturedEncodingReport(ApiHost src, CapturedEncodingRecord[] records)
        {
            this.Source = src;
            this.Records = records;
        }
        
        public ApiHost Source {get;}

        public CapturedEncodingRecord[] Records {get;}

        public Option<FilePath> Save(FilePath dst)
            => Records.Save(dst); 

        public CapturedEncodingRecord this[int index]
            => Records[index];                

        public int RecordCount
            => Records.Length;
    }
}