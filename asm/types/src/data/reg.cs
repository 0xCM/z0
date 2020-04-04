//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Types
{

    public interface reg : data
    {

    }

    public interface reg<W> : reg, data<W>
        where W : unmanaged, IDataWidth
    {
        
    }

    public interface reg<F,W> : reg<W>
        where F : struct, reg<F,W>
        where W : unmanaged, IDataWidth
    {

    }


    
}