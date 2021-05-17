//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static core;

    using api = PageBlocks;

    public interface IPageBlock<T>
        where T : unmanaged, IPageBlock<T>
    {
        ByteSize Size
            => size<T>();

        uint PageCount
            => api.PageCount<T>();
    }
}