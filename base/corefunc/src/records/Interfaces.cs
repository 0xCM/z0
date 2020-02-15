//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static zfunc;

    public interface IRecord
    {
        /// <summary>
        /// Returns a line of text represents the record value
        /// </summary>
        string DelimitedText(char delimiter);

        IReadOnlyList<string> GetHeaders();    

        IReadOnlyList<string> HeaderFields {get;}        
    }

    public interface IRecord<T> : IRecord
        where T : IRecord
    {
        IReadOnlyList<string> IRecord.HeaderFields
            =>  Record.ReportHeaders<T>();
    }

    public interface IReport
    {
        IReadOnlyList<string> HeaderFields {get;}
    }

    public interface IReport<T> : IReport
        where T : IRecord<T>
    {
        T[] Records {get;}

        IReadOnlyList<string> IReport.HeaderFields 
            =>  Record.ReportHeaders<T>();

        T this[int index]
            => Records[index];
        
        int RecordCount
            => Records.Length;
    }
}