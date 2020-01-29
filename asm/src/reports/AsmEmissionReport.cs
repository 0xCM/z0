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

    public class AsmEmissionReport : IReport<AsmEmissionRecord>
    {
        public static AsmEmissionReport Create(AssemblyId id, AsmEmissionToken[] emissions)
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
            
            return new AsmEmissionReport(id, records);
        }

        AsmEmissionReport(AssemblyId id, AsmEmissionRecord[] records)
        {
            this.id = id;
            this.Records = records;
        }

        public readonly AssemblyId id;
        
        public AsmEmissionRecord[] Records {get;}

        static bool ExcludeImm => true;

        public string Subject
            => "emissions";

        public FileExtension Ext
            => FileExtensions.Csv;

        public Option<FilePath> Save()
            => Records.Save(Paths.AsmReportRoot + FolderName.Define(Subject) + FileName.Define(id.Format(), Ext));
    }
}