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
        public static AsmEmissionReport Create(AssemblyId id, AsmEmissionToken[] emissions, string suffix = null)
        {
            var count = emissions.Length;
            if(count == 0)
                return default;

            Array.Sort(emissions);

            var records = new AsmEmissionRecord[count];
            MemoryAddress @base = emissions[0].Origin.Start;

            for(var i =0; i<count; i++)
                records[i] = AsmEmissionRecord.Define(@base, emissions[i], i != 0 ? emissions[i-1] : (AsmEmissionToken?)null);            
            
            return new AsmEmissionReport(id, records, suffix);
        }

        AsmEmissionReport(AssemblyId id, AsmEmissionRecord[] records, string suffix)
        {
            this.id = id;
            this.Records = records;
            this.Suffix = string.IsNullOrWhiteSpace(suffix) ? string.Empty :  $"-{suffix}";
        }

        public readonly AssemblyId id;
        
        public AsmEmissionRecord[] Records {get;}

        public string Subject
            => ".emissions";

        string Suffix {get;}

        public FileExtension Ext
            => FileExtensions.Csv;

        public Option<FilePath> Save()
            => Records.Save(Paths.AsmDataRoot + FolderName.Define(Subject) + FileName.Define($"{id.Format()}{Suffix}", Ext));
    }
}