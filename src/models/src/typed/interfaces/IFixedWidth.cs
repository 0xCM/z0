//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IFixedWidth : ITypeWidth, ITypedLiteral<FixedWidth,uint>
    {
        /// <summary>
        /// Defines a class specifier synonym to facilitate disambiguaton
        /// </summary>
        FixedWidth FixedWidth 
            => (FixedWidth)BitWidth;

        FixedWidth ITypedLiteral<FixedWidth>.Class 
            => FixedWidth;

        uint ITypedLiteral<FixedWidth,uint>.Value 
            => BitWidth;

        string ITypedLiteral<FixedWidth>.Name 
            => FixedWidth.FormatName();
    }
}