//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;

    using static zfunc;

    public static class AsmReports
    {
        public static Option<Assembly> ResolvedAssembly(this IAsmContext context, AssemblyId id)
            =>  (from r in  context.Compostion.Resolved
                where r.Id == id
                select r.Resolved).FirstOrDefault();

        public static Option<MemberLocationReport> MemberLocations(this IAsmContext context, AssemblyId src)
            => from a in context.ResolvedAssembly(src)
                let methods = a.GetTypes().DeclaredMethods().Static().NonGeneric().WithoutConversionOps()
                select MemberLocationReport.Create(src, methods);

        public static MemberLocationReport MemberLocations(AssemblyId id, Assembly src)
            => MemberLocationReport.Create(id, src.GetTypes().DeclaredMethods().Static().NonGeneric().WithoutConversionOps());

        public static AsmEmissionReport Emissions(AssemblyId id, CaptureTokenGroup[] emissions, AsmEmissionKind kind)
            => AsmEmissionReport.Create(id,emissions, kind);

        public static DataResourceReport Resources(AssemblyId id, DataResourceIndex resources)
            => DataResourceReport.Create(id, resources);


        public static ParsedEncodingReport Create(params ParsedEncodingRecord[] records)
            => PER.Create(records);


        readonly struct PER : ParsedEncodingReport
        {        
            public static ParsedEncodingReport Create(params ParsedEncodingRecord[] records)
                => new PER(records);

            PER(ParsedEncodingRecord[] records)
                => this.Records = records;
            
            public ParsedEncodingRecord[] Records {get;}
        }    
    }
}

