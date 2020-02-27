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

        IReadOnlyList<string> HeaderFields {get;}        
    }

    public interface IRecord<T> : IRecord
        where T : IRecord
    {
        IReadOnlyList<string> IRecord.HeaderFields
            =>  Reports.ReportHeaders<T>();
    }

    public interface IRecord<F,T> : IRecord<T>
        where T : IRecord
        where F : unmanaged, Enum
    {

    }   


}