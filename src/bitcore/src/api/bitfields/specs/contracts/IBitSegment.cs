//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IBitSegment
    {
        Identifier Name {get;}
    }

    public interface IBitSegment<T> : IBitSegment
        where T : unmanaged
    {
        T StartPos {get;}

        T EndPos {get;}
    }
}