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


    public static partial class AsmReports
    {
        public static MemberLocationReport MemberLocations(AssemblyId id, Assembly src)
            => MemberLocationReport.Create(id, src.GetTypes().DeclaredMethods().Static().NonGeneric().WithoutConversionOps());

        public static AsmEmissionReport Emissions(AssemblyId id, CaptureTokenGroup[] emissions, AsmEmissionKind kind)
            => AsmEmissionReport.Create(id,emissions, kind);

        public static DataResourceReport Resources(AssemblyId id, DataResourceIndex resources)
            => DataResourceReport.Create(id, resources);

    }
}

