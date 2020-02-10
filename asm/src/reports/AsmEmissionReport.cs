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

    public enum AsmEmissionKind
    {
        None = 0,

        Primary = 1,

        Imm = 2
    }

    public readonly struct AsmEmissionReport : IAsmReport<AsmEmissionRecord>
    {             
        public const AsmReportKind Kind = AsmReportKind.Emissions;

        public AsmReportKind ReportKind 
            => Kind;

        public AssemblyId Id {get;}
        
        public AsmEmissionRecord[] Records {get;}

        public AsmEmissionKind EmissionKind {get;}

        public FilePath ReportPath 
            => AsmReports.EmissionsPath(Id, EmissionKind);
                
        public static AsmEmissionReport Create(AssemblyId id, CaptureTokenGroup[] emitted, AsmEmissionKind kind)
        {
            if(emitted.Length == 0)
                return default;
            
            var emissions = emitted.SelectMany(g => g.Tokens).ToArray();
            Array.Sort(emissions);
            var count = emissions.Length;
            var records = new AsmEmissionRecord[count];            
            for(var i =0; i<count; i++)
                records[i] = AsmEmissionRecord.Define(emissions[i]);            
            
            return new AsmEmissionReport(id, records, kind);
        }

        AsmEmissionReport(AssemblyId id, AsmEmissionRecord[] records, AsmEmissionKind kind)
        {
            this.Id = id;
            this.Records = records;            
            this.EmissionKind = kind;
        }

        public Option<FilePath> Save()
            => Records.Save(ReportPath); 
    }
}