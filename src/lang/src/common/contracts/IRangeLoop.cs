//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;

    public interface IRangeLoop : ILoop
    {
        Range Range {get;}

        RangeIterator Iterator {get;}
    }
}