//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using api = Records;

    public interface IRecordParser
    {
        Outcome Parse(string src, out IRecord dst);
    }

    public interface IRecordParser<T> : IRecordParser
        where T : struct, IRecord<T>
    {
        Outcome Parse(string src, out T dst);

        Outcome IRecordParser.Parse(string src, out IRecord dst)
        {
            var outcome = Parse(src, out T record);
            if(outcome)
                dst = record;
            else
                dst = api.empty();
            return outcome;
        }
    }
}