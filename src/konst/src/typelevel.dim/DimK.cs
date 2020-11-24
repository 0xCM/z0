//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines a dimension with an arbitrary number of axes
    /// </summary>
    public readonly struct DimK : IDim
    {
        readonly ulong[] Axes;

        public DimK(params ulong[] src)
            => Axes = src;

        public ulong this[int index]
        {
            get => (index < Axes.Length && index >= 0) ? Axes[index] : 0;
        }

        public readonly ulong Volume
        {
            get
            {
                var v = 1ul;
                for(var i=0; i<Axes.Length; i++)
                    v *= Axes[i];
                return v;
            }
        }

        public int Order
            => Axes.Length;
    }
}