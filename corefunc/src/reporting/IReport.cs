//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static zfunc;

    public interface IReport
    {
        IReadOnlyList<string> HeaderFields {get;}

    }
    
    public interface IReport<T> : IReport
        where T : IRecord<T>
    {
        T[] Records {get;}

        IReadOnlyList<string> IReport.HeaderFields 
            =>  Reports.ReportHeaders<T>();

        T this[int index]
            => Records[index];
        
        int RecordCount
            => Records.Length;

        Option<FilePath> Save(FilePath dst)
            => Records.Save(dst);         
    }

    public interface IReport<F,T> : IReport<T>
        where T : IRecord<F,T>
        where F : unmanaged, Enum
    {

        int FieldCount 
            => Enums.literals<F>().Length;
                
        string[] FieldNames
            => Enums.names<F>();
        
        LiteralIndices<F> FieldIndices
            => Enums.indices<F>();

        EnumValues<F,int> FieldWidths
            => Enums.values<F,int>();
    }

}