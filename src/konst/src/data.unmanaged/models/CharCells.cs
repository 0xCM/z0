//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CharCells : IUnmanagedCells<char>
    {
        public readonly char[] Data;

        [MethodImpl(Inline)]
        public CharCells(char[] src)
            => Data = src;

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public ByteSize CellSize
        {
            [MethodImpl(Inline)]
            get => 2;
        }

        char[] IUnmanagedCells<char>.Storage
            => Data;

        [MethodImpl(Inline)]
        public static implicit operator CharCells(char[] src)
            => new UnmanagedCells<char>(src);

        [MethodImpl(Inline)]
        public static implicit operator CharCells(UnmanagedCells<char> src)
            => new CharCells(src);
    }
}