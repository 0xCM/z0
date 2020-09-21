//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines an aspect that specifies a bit width
    /// </summary>
    public interface IBitWidth
    {
        uint BitWidth {get;}
    }

    public interface IBitWidth<W> : IBitWidth
        where W : struct, IBitWidth<W>
    {

    }

    public interface IBitWidth<W,T> : IBitWidth<W>
        where W : struct, IBitWidth<W,T>
        where T : unmanaged
    {

    }

    public interface IBitWidth<W,K,T> : IBitWidth<W>
        where W : struct, IBitWidth<W,K,T>
        where K : unmanaged
        where T : unmanaged
    {

    }
}