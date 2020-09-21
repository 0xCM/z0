//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface TTypeWidth<W> : ITypeWidth<W>
        where W : struct, TTypeWidth<W>
    {
        TypeWidth ITypeWidth.TypeWidth
            => Widths.type<W>();
    }
}