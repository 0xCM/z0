//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Flows
{
    using System.Runtime.CompilerServices;

    using static Root;

    public struct Fiber : IFiber
    {
        /// <summary>
        /// The channel over which the fiber is defined
        /// </summary>
        public Channel Channel;

        /// <summary>
        /// The selected cell
        /// </summary>
        public uint Cell;

        /// <summary>
        /// The offset of the fiber within the cell
        /// </summary>
        public ushort Offset;
        
        /// <summary>
        /// The fiber width
        /// </summary>
        public byte Width;

        [MethodImpl(Inline)]
        public Fiber(Channel src, uint cell = 0, ushort offset = 0, byte width = 0)
        {
            Cell = cell;
            Channel = src;
            Offset = offset;
            Width = width;
        }

        IChannel IFiber.Source
            => Channel;

        uint IFiber.Cell 
            => Cell;

        ushort IFiber.Offset 
            => Offset;

        byte IFiber.Width 
            => Width;
    }
}