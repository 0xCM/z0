//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    public readonly struct HexPack
    {
        readonly Index<MemoryBlock> _Blocks;

        public ByteSize MaxBlockSize
            => _Blocks.Select(x => x.Size).Max();

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