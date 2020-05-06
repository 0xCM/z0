//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using E = MachineEvents.LoadedReport;

    public partial class MachineEvents
    {
        public readonly struct LoadedReport : IMachineEvent<E>
        {
            public static E Empty => new E(new EmptyReport(), FilePath.Empty);

            [MethodImpl(Inline)]
            public static LoadedReport Create(IReport report, FilePath src)
                => new LoadedReport(report, src);            

            [MethodImpl(Inline)]
            public LoadedReport(IReport report, FilePath src)
            {
                Report = report;
                ReportPath = src;
            }
            
            public IReport Report {get;}
            
            public FilePath ReportPath {get;}

            public int RecordCount 
                => Report.RecordCount;

            public E Zero => Empty; 
            
            public string Description
                => $"{RecordCount} {Report.ReportName} records loaded from {ReportPath}";
        }        
    }
}