//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiPartBlocks : IIndex<ApiCodeBlock>
    {
        public PartId Part {get;}

        public Index<ApiCodeBlock> Blocks {get;}

        [MethodImpl(Inline)]
        public ApiPartBlocks(PartId part, Index<ApiCodeBlock> blocks)
        {
            Part = part;
            Blocks = blocks;
        }

        public ApiCodeBlock[] Storage
        {
            [MethodImpl(Inline)]
            get => Blocks.Storage;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Blocks.Count;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Blocks.Length;
        }

        public ReadOnlySpan<ApiCodeBlock> View
        {
            [MethodImpl(Inline)]
            get => Blocks.View;
        }
    }
}