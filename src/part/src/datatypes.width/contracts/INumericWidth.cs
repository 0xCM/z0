//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface INumericWidth : ICellWidth
    {
        /// <summary>
        /// Defines a class specifier synonym to facilitate disambiguation
        /// </summary>
        NumericWidth NumericWidth
             => (NumericWidth)BitWidth;

        // NumericWidth ITypedLiteral<NumericWidth>.Class
        //     => NumericWidth;

        // uint ITypedLiteral<NumericWidth,uint>.Value
        //     => BitWidth;

        // string ITypedLiteral<NumericWidth>.Name
        //     => NumericWidth.FormatName();
    }

    public interface INumericWidth<W> : INumericWidth, ITypeWidth<W>
        where W : struct, INumericWidth<W>
    {

    }
}