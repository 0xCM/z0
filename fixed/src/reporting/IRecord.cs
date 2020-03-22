//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IRecord
    {
        /// <summary>
        /// Returns a line of text represents the record value
        /// </summary>
        string DelimitedText(char delimiter);

        string[] HeaderNames {get;}        
    }

    public interface IRecord<R> : IRecord
        where R : IRecord
    {
        string[] IRecord.HeaderNames
            =>  Reports.headers<R>();
    }

    public interface IRecord<F,R> : IRecord<R>
        where F : unmanaged, Enum
        where R : IRecord
    {

    }   
}