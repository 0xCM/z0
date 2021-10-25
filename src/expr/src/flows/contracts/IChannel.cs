//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Flows
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IChannel : ITextual
    {
        /// <summary>
        /// The number of cells carried by the channel
        /// </summary>
        uint CellCount {get;}

        /// <summary>
        /// The width of each cell
        /// </summary>
        uint CellWidth {get;}

        uint Capacity 
            => CellCount*CellWidth;

        Mask Mask 
            => Mask.Empty;
    }

    public interface IChannel<W> : IChannel
        where W : unmanaged, ITypeWidth
    {
        uint IChannel.CellWidth
            => (uint)Widths.type<W>();
    }

    public interface IChannel<N,W> : IChannel<W>
        where W : unmanaged, ITypeWidth
        where N : unmanaged, ITypeNat
    {
        uint IChannel.CellCount
            => core.nat32u<N>();
    }
}