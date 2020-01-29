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
        public static MemberLocationReport CreateMemberLocationReport(AssemblyId id, Assembly src)
            => MemberLocationReport.Create(id, src.GetTypes().DeclaredMethods().Static().NonGeneric().WithoutConversionOps());

        public static AsmEmissionReport CreateEmissionReport(AssemblyId id, AsmEmissionToken[] emissions)
            => AsmEmissionReport.Create(id,emissions);

        public static DataResourceReport CreateResourceReport(DataResourceIndex resources)
            => DataResourceReport.Create(resources);

    }
}

