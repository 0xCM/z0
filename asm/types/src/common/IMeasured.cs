//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    public interface IMeasured<W>
        where W : unmanaged, IDataWidth
    {
        uint Size => (uint)Widths.data<W>();
    }

}