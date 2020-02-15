//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;
 
    public readonly struct CapturedEncodings : IReport<CapturedEncoding>
    {
        public static CapturedEncodings Create(ApiHost src, CapturedEncoding[] records)
            => new CapturedEncodings(src,records);

        CapturedEncodings(ApiHost src, CapturedEncoding[] records)
        {
            this.Source = src;
            this.Records = records;
        }
        
        public ApiHost Source {get;}

        public CapturedEncoding[] Records {get;}

        public Option<FilePath> Save(FilePath dst)
            => Records.Save(dst); 

        public CapturedEncoding this[int index]
            => Records[index];                

        public int RecordCount
            => Records.Length;
    }
}