//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CharCells : IStorageCells<char>
    {
        public char[] Storage {get;}

        [MethodImpl(Inline)]
        public CharCells(char[] src)
            => Storage = src;

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => (uint)Storage.Length;
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