//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    partial class Nasm
    {
        public ReadOnlySpan<NasmCodeBlock> ShowListedBlocks(Identifier name)
        {
            var blocks = LoadListedBlocks(name).View;
            var count = blocks.Length;
            using var log = ShowLog(name, FS.Log);
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(blocks,i);
                RenderCodeBlock(block, log.Buffer);
                log.ShowBuffer();
            }
            return blocks;
        }
    }
}