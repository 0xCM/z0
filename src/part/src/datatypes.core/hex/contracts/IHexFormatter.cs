//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IHexFormatter<T> : ISpanFormatter<T,HexSeqFormat,HexFormatOptions>
        where T : unmanaged
    {

    }
}