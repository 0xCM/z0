//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Types
{
    public interface data : sized
    {
        
    }

    public interface data<W> : data, sized<W>
        where W : unmanaged, IDataWidth
    {        
        
    }
}