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
        string[] HeaderNames {get;}

        string ReportName {get;}

        int RecordCount {get;}

        IRecord[] Records {get;}
    }
        
    public readonly struct EmptyReport : IReport
    {
        public string[] HeaderNames => new string[]{};

        public string ReportName => string.Empty;

        public int RecordCount => 0;

        public IRecord[] Records => new IRecord[]{};

    }

    public interface IReport<R> : IReport
        where R : IRecord<R>
    {
        new R[] Records {get;}

        IRecord[] IReport.Records => Records.Map(r => (IRecord)r);

        string[] IReport.HeaderNames 
            =>  Reports.headers<R>();

        string IReport.ReportName 
            => GetType().Name;

        R this[int index]
            => Records[index];
        
        int IReport.RecordCount
            => Records.Length;

        Option<FilePath> Save(FilePath dst)
            => Records.Save(dst);         
    }

    public interface IReport<F,R> : IReport<R>
        where R : IRecord<F,R>
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