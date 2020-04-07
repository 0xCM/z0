//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISized
    {
        uint Size {get;}
    }

    public interface ISized<W> : ISized
        where W : unmanaged, IDataWidth
    {
        uint ISized.Size => (uint)Widths.data<W>();
    }
}