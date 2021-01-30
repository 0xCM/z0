//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IBitSection<T>
        where T : unmanaged
    {
        T StartPos {get;}

        T EndPos {get;}
    }
}