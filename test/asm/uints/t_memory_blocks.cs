//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public sealed class t_memory_blocks : t_asm<t_memory_blocks>
    {

        public void check_blocks_8u()
        {
            var buffer = new byte[256];
            var cellBlock = CellBlocks.cover(buffer);
            //var spanBlock = SpanBlocks
        }
    }
}