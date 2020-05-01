//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
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

    public interface IReport<R> : IReport
        where R : ITabular<R>
    {
        new R[] Records {get;}

        ITabular[] IReport.Records => Records.Map(r => (ITabular)r);

        string[] IReport.HeaderLabels 
            =>  TabularFormats.headers<R>();

        string IReport.ReportName 
            => GetType().Name;

        R this[int index]
            => Records[index];
        
        int IReport.RecordCount
            => Records.Length;

        Option<FilePath> Save(FilePath dst)
            => TableLog.Service.Save(Records,dst);         
    }

    public interface IReport<F,R> : IReport<R>
        where R : ITabular<F,R>
        where F : unmanaged, Enum
    {

        int FieldCount 
            => Enums.valarray<F>().Length;
                
        string[] FieldNames
            => Enums.names<F>();
        
        EnumLiterals<F> FieldIndices
            => Enums.literals<F>();

        EnumValues<F,int> FieldWidths
            => Enums.values<F,int>();
    }
}