//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ITypeWidth : IDataWidth
    {
        TypeWidth TypeWidth {get;}

    }

    public interface ITypeWidth<W> : ITypeWidth, IDataWidth<W>
        where W : struct, ITypeWidth<W>
    {

    }
}