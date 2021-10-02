//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static RuleModels;

    public interface IRangeLoop : IScopedLoop
    {
        RuleModels.Range Range {get;}

        RangeIterator Iterator {get;}
    }
}