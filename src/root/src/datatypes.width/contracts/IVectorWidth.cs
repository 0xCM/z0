//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IVectorWidth : ICellWidth
    {
        /// <summary>
        /// Defines a class specifier for use as a discriminator
        /// </summary>
        VectorWidth VectorWidth
            => (VectorWidth)BitWidth;
    }
}