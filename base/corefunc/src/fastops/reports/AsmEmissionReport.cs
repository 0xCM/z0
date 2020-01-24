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
    using System.Reflection;
    using System.IO;

    using static zfunc;

    public static class AsmEmissionReport
    {
        const string ReportExtension = "csv";

        static FolderPath OutputFolder => Paths.AsmDataDir(FolderName.Define("logs")).CreateIfMissing();

        static FilePath OutputPath(IOperationCatalog catalog)
            => OutputFolder + FileName.Define(catalog.CatalogName, ReportExtension);

        public static Option<FilePath> Create(IOperationCatalog catalog, AsmDescriptor[] emissions, bool immexclude = true)
        {
            
            if(immexclude)
                emissions = emissions.Where(e => !e.Uri.Id.HasImm).ToArray();

            var count = emissions.Length;
            if(count == 0)
                return default;

            Array.Sort(emissions);
            
            var records = new AsmEmissionRecord[count];
            MemoryAddress @base = emissions[0].Origin.Start;

            for(var i =0; i<count; i++)
                records[i] = AsmEmissionRecord.Define(@base, emissions[i], i != 0 ? emissions[i-1] : (AsmDescriptor?)null);
            return records.Save(OutputPath(catalog));
        }
    }
}