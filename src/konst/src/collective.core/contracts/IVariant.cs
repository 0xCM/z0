//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IVariant : ITextual
    {
        /// <summary>
        /// The number of bits that are used to store the enclosed data
        /// </summary>
        int DataWidth {get;}

        /// <summary>
        /// The numeric data type if unsegmented or, if segmented, the numeric cell kind
        /// </summary>
        NumericKind CellKind {get;}

    }

    [Free]
    public interface IVariant<V> : IVariant
        where V : unmanaged, IVariant<V>
    {

    }

    [Free]
    public interface ISegmentedVariant<V>  : IVariant, IEquatable<V>
        where V : unmanaged, ISegmentedVariant<V>
    {

        /// <summary>
        /// If covering scalar data, the cell count will always be 1; when blocked or vector data
        /// is enclosed the cell count will vary based on the specific type
        /// </summary>
        int CellCount
            => 1;

        /// <summary>
        /// If covering scalar data, will specify the width of the scalar type; otherwise,
        /// it will specify the width of a vector or block cell
        /// </summary>
        int CellWidth
            => DataWidth;

        /// <summary>
        /// For scalar data this bit will always be off; otherwise, it will be on
        /// </summary>
        bool Segmented
            => CellWidth < DataWidth;
    }
}