//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IBitFormatter : IFormatter
    {

    }

    public interface IBitFormatter<T> : IBitFormatter, IDataFormatter<BitFormat,T>
        where T : struct
    {
    }
}