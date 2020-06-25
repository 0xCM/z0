//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    public interface ISized<W> : ISized
        where W : unmanaged, IDataWidth
    {        
        DataWidth ISized.Width 
            => Widths.data<W>();
    }
}