//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IFixedWidth : ITypeWidth, ITypedLiteral<FixedWidth,uint>
    {
        /// <summary>
        /// Defines a class specifier synonym to facilitate disambiguaton
        /// </summary>
        FixedWidth FixedWidth => (FixedWidth)BitWidth;

        FixedWidth ITypedLiteral<FixedWidth>.Class => FixedWidth;

        uint ITypedLiteral<FixedWidth,uint>.Value => BitWidth;

        string ITypedLiteral<FixedWidth>.Name => FixedWidth.FormatName();
    }

    public interface IFixedWidth<F> : IFixedWidth, ITypeWidth<F>, ITypedLiteral<F,FixedWidth,uint>
        where F : struct, IFixedWidth<F>
    {     
        FixedWidth IFixedWidth.FixedWidth => Widths.fwidth<F>();               
    }

    public interface IFixedWidth<F,W> : IFixedWidth<F>
        where F : struct, IFixedWidth<F,W>
        where W : struct, IFixedWidth
    {

    }
}