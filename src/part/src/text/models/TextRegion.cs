//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Part;

    public readonly struct TextRegion
    {
        public Index<TextBlock> Blocks {get;}

        public TextRegion(Index<TextBlock> blocks)
        {
            Blocks = blocks;
        }
    }
}