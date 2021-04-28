//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct HexPack
    {
        readonly Index<MemoryBlock> _Blocks;

        public ByteSize MaxBlockSize {get;}

        [MethodImpl(Inline)]
        internal HexPack(Index<MemoryBlock> src, ByteSize max)
        {
            _Blocks = src;
            MaxBlockSize = max;
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
            get => new HexPack(Index<MemoryBlock>.Empty, 0);
        }
    }
}