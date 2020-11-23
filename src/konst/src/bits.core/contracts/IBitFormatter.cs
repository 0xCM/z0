//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IBitFormatter<H>
    {

    }

    public interface IBitFormatter<H,T> : IBitFormatter<H>, IDataFormatter<BitFormat,T>
        where T : struct
        where H : IBitFormatter<H,T>
    {
    }
}