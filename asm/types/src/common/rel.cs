//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Types
{
    /// <summary>
    /// A relative location
    /// </summary>
    public interface rel : location
    {
        
    }

    /// <summary>
    /// A relative location specified using an W-bit displacement
    /// </summary>
    public interface rel<W,T> : rel
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        T Offset {get;}
    }

    /// <summary>
    /// A relative location specified using an 8-bit displacement
    /// </summary>
    public readonly struct rel8 : rel<W8,byte>
    {
        public byte Offset {get;}
    }

    /// <summary>
    /// A relative location specified using a 16-bit displacement
    /// </summary>
    public readonly struct rel16 : rel<W16,ushort>
    {
        public ushort Offset {get;}
    }

    /// <summary>
    /// A relative location specified using a 32-bit displacement
    /// </summary>
    public readonly struct rel32 : rel<W32,uint>
    {
        public uint Offset {get;}
    }

    /// <summary>
    /// A relative location specified using a 64-bit displacement
    /// </summary>
    public readonly struct rel64 : rel<W64,ulong>
    {
        public ulong Offset {get;}
    }

}