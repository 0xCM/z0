//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using AsmSpecs;

    using static zfunc;

    public static class AsmServices
    {                                
        public static Option<MemberLocationReport> EmitMemberLocations(AssemblyId id, Assembly src)
        {
            var subject = $"{id.ToString().ToLower()}-locations";
            var outpath = Paths.AsmReportRoot +  FileName.Define(subject, FileExtensions.Csv);
            var report = MemberLocationReport.Create(src.GetTypes().DeclaredMethods().Static().NonGeneric().WithoutConversionOps());
            return report.Save(outpath).TryMap(_ => report);
        }

    }
}