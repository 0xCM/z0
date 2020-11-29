//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IVectorWidth : ICellWidth, ITypedLiteral<VectorWidth,uint>
    {
        /// <summary>
        /// Defines a class specifier for use as a discriminator
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

    public interface IVectorWidth<W> : IVectorWidth, ICellWidth<W>
        where W : unmanaged, IVectorWidth<W>
    {

    }
}