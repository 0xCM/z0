//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IVectorWidth : IFixedWidth, ITypedLiteral<VectorWidth,uint>
    {
        /// <summary>
        /// Defines a class specifier synonym to facilitate disambiguaton
        /// </summary>
        VectorWidth VectorWidth 
            => (VectorWidth)BitWidth;

        VectorWidth ITypedLiteral<VectorWidth>.Class 
            => VectorWidth;

        uint ITypedLiteral<VectorWidth,uint>.Value 
            => BitWidth;

        string ITypedLiteral<VectorWidth>.Name 
            => VectorWidth.FormatName();
    }
}