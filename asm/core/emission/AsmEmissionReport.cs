//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    using F = AsmEmissionField;
    using R = AsmEmissionRecord;

    public enum AsmEmissionField : ulong
    {
        TermCode = 0 | (20ul << 32),

        Size = 1 | (8ul << 32),

        Uri = 2 | (1ul << 32)
    }

    /// <summary>
    /// Describes an assembly code emission
    /// </summary>
    public class AsmEmissionRecord : IRecord<F,R>
    {    
        public static AsmEmissionRecord Define(AsmEmissionToken src)
            => new AsmEmissionRecord(src);

        AsmEmissionRecord(AsmEmissionToken src)
        {
            this.TermCode = src.TermCode;
            this.Size = (int)src.AddressRange.Length;
            this.Uri = src.Uri;
        }
        
        [ReportField(F.TermCode)]
        public CaptureTermCode TermCode {get;}

        [ReportField(F.Size)]
        public int Size {get;}

        [ReportField(F.Uri)]
        public OpUri Uri {get;}

        public string DelimitedText(char delimiter)
        {
            var dst = text.factory.Builder();
            dst.AppendField(TermCode.ToString(), (int)((ulong)F.TermCode >> 32));
            dst.DelimitField(Size.ToString(), (int)((ulong)F.Size >> 32), delimiter);
            dst.DelimitField(Uri.Format(),delimiter);
            return dst.ToString();
        }
    }

    public class AsmEmissionReport :   Report<F,R>
    {             
        public AssemblyId Id {get;}
        
        public AsmEmissionKind EmissionKind {get;}

        public static AsmEmissionReport Create(AssemblyId id, AsmEmissionTokens<OpUri>[] emitted, AsmEmissionKind kind)
        {
            if(emitted.Length == 0)
                return default;
            
            var emissions = emitted.SelectMany(g => g.Content).ToArray();
            Array.Sort(emissions);
            var count = emissions.Length;
            var records = new AsmEmissionRecord[count];            
            for(var i =0; i<count; i++)
                records[i] = AsmEmissionRecord.Define(emissions[i]);            
            
            return new AsmEmissionReport(id, records, kind);
        }

        AsmEmissionReport(AssemblyId id, AsmEmissionRecord[] records, AsmEmissionKind kind)
            : base(records)
        {
            this.Id = id;
            this.EmissionKind = kind;
        }
   }    
}