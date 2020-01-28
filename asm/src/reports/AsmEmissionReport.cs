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

    public static class AsmEmissionReport
    {
        static bool ExcludeImm => true;

        public static Option<FilePath> Save(IOperationCatalog catalog, AsmEmissionToken[] emissions, FilePath dst)
        {
                    
            if(ExcludeImm)
                emissions = emissions.Where(e => !e.Uri.Id.HasImm).ToArray();

            var count = emissions.Length;
            if(count == 0)
                return default;

            Array.Sort(emissions);


            var records = new AsmEmissionRecord[count];
            MemoryAddress @base = emissions[0].Origin.Start;

            for(var i =0; i<count; i++)
                records[i] = AsmEmissionRecord.Define(@base, emissions[i], i != 0 ? emissions[i-1] : (AsmEmissionToken?)null);
            
            
            return records.Save(dst);
        }
    }
}