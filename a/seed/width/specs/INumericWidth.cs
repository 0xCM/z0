//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface INumericWidth : IFixedWidth, ITypedLiteral<NumericWidth,uint>
    {
        /// <summary>
        /// Defines a class specifier synonym to facilitate disambiguaton
        /// </summary>
        NumericWidth NumericWidth  => (NumericWidth)BitWidth;

        NumericWidth ITypedLiteral<NumericWidth>.Class => NumericWidth;

        uint ITypedLiteral<NumericWidth,uint>.Value => BitWidth;

        string ITypedLiteral<NumericWidth>.Name => NumericWidth.FormatName();
    }

    public interface INumericWidth<F> : INumericWidth, IFixedWidth<F>, ITypedLiteral<F,NumericWidth,uint>
        where F : struct, INumericWidth<F>
    {     
        NumericWidth INumericWidth.NumericWidth => Widths.numeric<F>();               
    }
}