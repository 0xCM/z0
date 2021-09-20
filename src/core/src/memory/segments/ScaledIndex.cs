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
    public readonly struct ScaledIndex
    {
        [MethodImpl(Inline), Op]
        public static ScaledIndex define(W8 w, N4 n, sbyte dx, uint i)
            => new ScaledIndex(8, 4, dx, i);

        public readonly uint Offset;

        public readonly sbyte Scale;

        public readonly byte Mod;

        public readonly byte CellWidth;

        public readonly byte StorageWidth;

        [MethodImpl(Inline)]
        public ScaledIndex(byte wStorage, byte wCell, sbyte scale, uint index)
        {
            StorageWidth = wStorage;
            CellWidth = wCell;
            Offset = (uint)(index/scale);
            Scale = scale;
            Mod = (byte)(Offset%Scale);
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => Sign.IsRight() ? (uint)(StorageWidth/CellWidth) : (uint)(CellWidth/StorageWidth);
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