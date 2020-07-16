//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface INumericWidth : IFixedWidth, ITypedLiteral<NumericWidth,uint>
    {
        /// <summary>
        /// Defines a class specifier synonym to facilitate disambiguaton
        /// </summary>
        NumericWidth NumericWidth
             => (NumericWidth)BitWidth;

        NumericWidth ITypedLiteral<NumericWidth>.Class 
            => NumericWidth;

        uint ITypedLiteral<NumericWidth,uint>.Value 
            => BitWidth;

        string ITypedLiteral<NumericWidth>.Name 
            => NumericWidth.FormatName();
    }
}