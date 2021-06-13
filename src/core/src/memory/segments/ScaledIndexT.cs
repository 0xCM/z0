//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct ScaledIndex<T>
        where T : unmanaged
    {
        public uint Offset {get;}

        public sbyte Scale {get;}

        public byte Mod {get;}

        public byte CellWidth {get;}

        [MethodImpl(Inline)]
        public ScaledIndex(byte width, sbyte scale, uint index)
        {
            Offset = (uint)(index/scale);
            Scale = scale;
            Mod = (byte)(Offset%Scale);
            CellWidth = width;
        }

        /// <summary>
        /// The width of the storage cell to which the index is relative
        /// </summary>
        public uint StorageWidth
        {
            [MethodImpl(Inline)]
            get => core.size<T>();
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => Sign.IsRight() ? StorageWidth/CellWidth : CellWidth/StorageWidth;
        }

        public bool Even
        {
            [MethodImpl(Inline)]
            get => Mod == 0;
        }

        public bool Odd
        {
            [MethodImpl(Inline)]
            get => Mod != 0;
        }

        public Sign Sign
        {
            [MethodImpl(Inline)]
            get => Scale;
        }
    }
}