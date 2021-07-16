//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Rules;

    public interface IRangeLoop : IScopedLoop
    {
        Rules.Range Range {get;}

        RangeIterator Iterator {get;}
    }
}