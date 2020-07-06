//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface TDataWidth<W> : IDataWidth<W>
        where W : struct, TDataWidth<W>
    {        
        DataWidth IDataWidth.DataWidth 
            => (DataWidth)Widths.data<W>();        

        bool IEquatable<W>.Equals(W src) 
            => src.BitWidth == BitWidth;        
    }    
}