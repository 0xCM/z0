//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using W = DataWidth;

    public readonly struct Segmentation<W,S>
        where W : unmanaged, IDataWidth
        where S : unmanaged, IDataWidth
    {
        public DataWidth TotalWidth => default(W).DataWidth;

        public DataWidth SegWidth => default(S).DataWidth;
    }
}