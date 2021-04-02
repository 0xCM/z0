//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using Z0.Tooling;

    using static Part;
    using static memory;


    public class NasmRunner : WfService<NasmRunner>
    {
        public void Run()
        {
            ShowListedBlocks("xor");
        }

        public void ShowListedBlocks(string name)
        {
            var tool = Wf.nasm();
            var blocks = ListedBlocks("xor").View;
            var count = blocks.Length;
            using var log = ShowLog(name, FS.Log);
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(blocks,i);
                tool.RenderBlock(block, log.Buffer);
                log.ShowBuffer();
            }
        }

        public Index<NasmCodeBlock> ListedBlocks(string listname)
        {
            var tool = Wf.nasm();
            return tool.ListedBlocks(listname);
        }
    }
}