//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface INumericWidth<W> : INumericWidth, TFixedWidth<W>, ITypedLiteral<W,NumericWidth,uint>
        where W : struct, INumericWidth<W>
    {
        
    }
}