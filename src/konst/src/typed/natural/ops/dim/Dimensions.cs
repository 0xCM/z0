//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Describes a dimension of any order
    /// </summary>
    public readonly struct Dimensions
    {
        public Dimensions(int order, ulong[] axes, ulong volume)
        {
            Order = order;
            Axes = axes;
            Volume = volume;
        }

        /// <summary>
        /// The number of dimension axes
        /// </summary>
        public readonly int Order;

        /// <summary>
        /// The axis index
        /// </summary>
        public readonly ulong[] Axes;

        /// <summary>
        /// Specifies the maximum number of cells that may inhabit the associated space
        /// </summary>
        public readonly ulong Volume;
    }
}