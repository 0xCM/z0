//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Defines a dimension with an arbitrary number of axes
    /// </summary>
    public readonly struct DimK : IDim
    {
        readonly ulong[] Axes;

        [MethodImpl(Inline)]
        public DimK(params ulong[] src)
            => Axes = src;

        public ulong this[int index]
        {
            [MethodImpl(Inline)]
            get => (index < Axes.Length && index >= 0) ? Axes[index] : 0;
        }

        public readonly ulong Volume
        {
            [MethodImpl(Inline)]
            get
            {
                var v = 1ul;
                for(var i=0; i<Axes.Length; i++)
                    v *= skip(Axes,i);
                return v;
            }
        }

        public int Order
            => Axes.Length;
    }
}