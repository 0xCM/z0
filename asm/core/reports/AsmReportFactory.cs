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

    public static class AsmReports
    {
        public static Option<Assembly> ResolvedAssembly(this IAsmContext context, AssemblyId id)
            =>  (from r in  context.Compostion.Resolved
                where r.Id == id
                select r.Resolved).FirstOrDefault();

        public static Option<MemberLocationReport> LocationReport(this IAsmContext context, AssemblyId src)
            => from a in context.ResolvedAssembly(src)
                let methods = a.GetTypes().DeclaredMethods().Static().NonGeneric().WithoutConversionOps()
                select MemberLocationReport.Create(src, methods);

        public static MemberLocationReport LocationReport(AssemblyId id, Assembly src)
            => MemberLocationReport.Create(id, src.GetTypes().DeclaredMethods().Static().NonGeneric().WithoutConversionOps());

        public static AsmEmissionReport Emissions(AssemblyId id, AsmEmissionTokens<OpUri>[] emissions, AsmEmissionKind kind)
            => AsmEmissionReport.Create(id,emissions, kind);

        public static DataResourceReport Resources(AssemblyId id, DataResourceIndex resources)
            => DataResourceReport.Create(id, resources);

        public static ParsedOpReport ParsedEncodings(ApiHostUri host, params ParsedOpRecord[] records)
            => ParsedOpReport.Create(records);
    }
}