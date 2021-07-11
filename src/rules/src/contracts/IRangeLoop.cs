//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Lang;

    public interface IRangeLoop : ILoop
    {
        Rules.Range Range {get;}

        RangeIterator Iterator {get;}
    }
}