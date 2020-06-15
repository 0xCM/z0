//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface IReport
    {
        string[] HeaderLabels {get;}

        string ReportName {get;}

        int RecordCount {get;}

        ITabular[] Records {get;}
    }
        
    public readonly struct EmptyReport : IReport
    {
        public string[] HeaderLabels => new string[]{};

        public string ReportName => string.Empty;

        public int RecordCount => 0;

        public ITabular[] Records => new ITabular[]{};
    }
}