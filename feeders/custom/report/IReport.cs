//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Custom;

    public interface IReport
    {
        string[] HeaderNames {get;}

        string ReportName {get;}
    }
        
    public interface IReport<R> : IReport
        where R : IRecord<R>
    {
        R[] Records {get;}

        string[] IReport.HeaderNames 
            =>  Reports.headers<R>();

        string IReport.ReportName 
            => GetType().DisplayName();

        R this[int index]
            => Records[index];
        
        int RecordCount
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