//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Types
{
   /// <summary>
    /// A register - considers as data and an absolute location
    /// </summary>
    public interface reg : absolute, data
    {

    }

    public interface reg<W> : reg, data<W>
        where W : unmanaged, IDataWidth
    {
        
    }

    public interface reg<F,W> : reg<W>, location<F>
        where F : struct, reg<F,W>
        where W : unmanaged, IDataWidth
    {

    }

}