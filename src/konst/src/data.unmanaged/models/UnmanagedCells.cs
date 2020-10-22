//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct UnmanagedCells : IUnmanagedCells
    {
        public ByteSize CellSize {get;}

        public readonly byte[] Data;

        [MethodImpl(Inline)]
        public UnmanagedCells(ByteSize size, byte[] src)
        {
            CellSize = size;
            Data = src;
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length/CellSize;
        }

        byte[] IUnmanagedCells<byte>.Storage
            => Data;
    }
}