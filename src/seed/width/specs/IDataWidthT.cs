//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IDataWidth<F> : IDataWidth, ITypedLiteral<F,DataWidth,uint>, IEquatable<F>
        where F : struct, IDataWidth<F>
    {        
        DataWidth IDataWidth.DataWidth 
            => (DataWidth)Widths.data<F>();        

        bool IEquatable<F>.Equals(F src) 
            => src.BitWidth == BitWidth;        
    }
}