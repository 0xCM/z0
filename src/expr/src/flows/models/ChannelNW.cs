//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Flows
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Channel<N,W> : IChannel<N,W>
        where W : unmanaged, ITypeWidth
        where N : unmanaged, ITypeNat
    {
        public uint Capacity {get;}

        public Mask Mask {get;}

        /// <summary>
        /// The number of cells carried by the channel
        /// </summary>
        public uint CellCount 
        {
            [MethodImpl(Inline)]
            get => core.nat32u<N>();
        }

        /// <summary>
        /// The width of each cell
        /// </summary>
        public uint CellWidth
        {
            [MethodImpl(Inline)]
            get => (uint)Widths.type<W>();
        }
        
        [MethodImpl(Inline)]
        internal Channel(Mask mask = default)
        {
            Capacity = core.nat32u<N>()*core.width<W>();
            Mask = mask;
        }

        public string Format()
            => flows.format(this);


        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Channel(Channel<N,W> src)
            => flows.channel(src.CellCount, src.CellWidth, src.Mask);

        [MethodImpl(Inline)]
        public static implicit operator Channel<W>(Channel<N,W> src)
            => flows.channel<W>(src.CellCount, src.Mask);
    }
}