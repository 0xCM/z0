//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CharCells : IStorageCells<char>
    {
        public Index<char> Cells {get;}

        [MethodImpl(Inline)]
        public CharCells(char[] src)
            => Cells = src;

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => (uint)Cells.Length;
        }

        public ByteSize CellSize
        {
            [MethodImpl(Inline)]
            get => 2;
        }

        [MethodImpl(Inline)]
        public static implicit operator CharCells(char[] src)
            => new StorageCells<char>(src);

        [MethodImpl(Inline)]
        public static implicit operator CharCells(StorageCells<char> src)
            => new CharCells(src);
    }
}