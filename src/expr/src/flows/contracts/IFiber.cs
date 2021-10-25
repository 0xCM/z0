//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Flows
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IFiber
    {
        /// <summary>
        /// The channel over which the fiber is defined
        /// </summary>
        IChannel Source {get;}

        /// <summary>
        /// The selected cell
        /// </summary>
        uint Cell {get;}

        /// <summary>
        /// The offset of the fiber within the cell
        /// </summary>
        ushort Offset {get;}
        
        /// <summary>
        /// The fiber width
        /// </summary>
        byte Width {get;}
    }

    [Free]
    public interface IFiber<T> : IFiber
        where T : unmanaged, IChannel
    {
        /// <summary>
        /// The channel over which the fiber is defined
        /// </summary>
        new T Source {get;}

        IChannel IFiber.Source
            => flows.channel(Source.CellCount, Source.CellWidth, Source.Mask);
    }
}