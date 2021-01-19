//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Describes a dimension of any order
    /// </summary>
    public readonly struct Dimensions
    {
        /// <summary>
        /// The number of dimension axes
        /// </summary>
        public int Order {get;}

        /// <summary>
        /// The axis index
        /// </summary>
        public ulong[] Axes {get;}

        /// <summary>
        /// Specifies the maximum number of cells that may inhabit the associated space
        /// </summary>
        public ulong Volume {get;}

        [MethodImpl(Inline)]
        public Dimensions(int order, ulong[] axes, ulong volume)
        {
            Order = order;
            Axes = axes;
            Volume = volume;
        }
    }
}