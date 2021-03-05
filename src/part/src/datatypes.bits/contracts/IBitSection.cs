//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IBitSection
    {
        Identifier Name {get;}
    }

    public interface IBitSection<T> : IBitSection
        where T : unmanaged
    {
        T StartPos {get;}

        T EndPos {get;}
    }
}