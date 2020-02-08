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

    public enum AsmReportKind
    {
        None = 0,

        Emissions = 1,

        DataResource = 2,

        Locations = 3
    }
    
    public interface IAsmReport : IReport
    {
        AsmReportKind ReportKind {get;}
    }

    public interface IAsmReport<R> : IAsmReport,  IReport<R>
        where R : IRecord<R>
    {
        
    }

}