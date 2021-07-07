//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = HexPacks;

    public readonly struct HexPack
    {
        readonly Index<MemoryBlock> _Blocks;

        public ByteSize MaxBlockSize
            => api.max(_Blocks.View).Size;

        [MethodImpl(Inline)]
        public HexPack(Index<MemoryBlock> src)
        {
            _Blocks = src;
        }

        public ReadOnlySpan<MemoryBlock> Blocks
        {
            [MethodImpl(Inline)]
            get => _Blocks.View;
        }

        public uint BlockCount
        {
            [MethodImpl(Inline)]
            get => _Blocks.Count;
        }

        public static HexPack Empty
        {
            [MethodImpl(Inline)]
            get => new HexPack(Index<MemoryBlock>.Empty);
        }
    }
}