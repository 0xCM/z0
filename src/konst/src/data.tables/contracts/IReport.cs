//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;

    public interface IReport
    {
        string[] HeaderLabels {get;}

        string ReportName {get;}

        int RecordCount {get;}
    }
        
    public readonly struct EmptyReport : IReport
    {
        public string[] HeaderLabels 
            => sys.empty<string>();

        public string ReportName 
            => EmptyString;

        public int RecordCount 
            => 0;

        public ITabular[] Records 
            => sys.empty<ITabular>();
    }
}