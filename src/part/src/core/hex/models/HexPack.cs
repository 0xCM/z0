//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;

    public readonly struct HexPack
    {
        readonly Index<MemoryBlock> _Blocks;

        public ByteSize MaxBlockSize {get;}

        public HexPack(Index<MemoryBlock> src)
        {
            _Blocks = src.Sort();
            MaxBlockSize = _Blocks.Select(x => (uint)x.Size).Max();
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

        [MethodImpl(Inline)]
        public static implicit operator HexPack(MemoryBlock[] src)
            => new HexPack(src);
    }
}