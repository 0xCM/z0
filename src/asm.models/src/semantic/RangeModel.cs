//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct RangeModel<T,W>
        where W : unmanaged
    {
        public readonly T Id;

        public readonly ClosedInterval<W> Width;

        [MethodImpl(Inline)]
        public RangeModel(T id, ClosedInterval<W> width)
        {
            Id = id;
            Width = width;
        }

        /// <summary>
        /// The minimum content width
        /// </summary>
        public W MinWidth
        {
            [MethodImpl(Inline)]
            get => Width.Min;
        }

        /// <summary>
        /// The maximum content width
        /// </summary>
        public W MaxWidth
        {
            [MethodImpl(Inline)]
            get => Width.Max;
        }
    }
}
