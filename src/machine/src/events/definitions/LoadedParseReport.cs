//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using E = MachineEvents.LoadedParseReport;

    partial class MachineEvents
    {
        public readonly struct LoadedParseReport : IMachineEvent<E>
        {
            public static E Empty => new E(MemberParseReport.Empty, FilePath.Empty);

            [MethodImpl(Inline)]
            public static LoadedParseReport Create(MemberParseReport report, FilePath src)
                => new LoadedParseReport(report,src);

            [MethodImpl(Inline)]
            public LoadedParseReport(MemberParseReport report, FilePath src)
            {
                Report = report;
                ReportPath = src;
            }
            
            public MemberParseReport Report {get;}
            
            public FilePath ReportPath {get;}

            public int RecordCount 
                => Report.RecordCount;

            public E Zero => Empty; 
            
            public string Description
                => LoadedReport.Create(Report, ReportPath).Description;
        }        
    }
}