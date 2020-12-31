//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IRecordParser<T>
        where T : struct
    {
        Outcome Parse(string src, out T dst);
    }
}