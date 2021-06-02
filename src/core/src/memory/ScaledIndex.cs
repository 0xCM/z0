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
        public uint Offset {get;}

        public sbyte Scale {get;}

        public byte Mod {get;}

        public byte StorageWidth {get;}

        public byte CellWidth {get;}

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