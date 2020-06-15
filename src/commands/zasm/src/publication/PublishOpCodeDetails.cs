//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    partial class AsmEtl
    {                        
        void LoadDataBlocks()
        {
            var blocks = OpCodeDataBlocks.Load();
            var formatter = InstructionFormatService.Service;
            var dst = new List<(OpCodeId, string ocs, string inxs)>();
            for(var i=0; i<blocks.Length; i++)
            {
                var block = blocks[i];
                PrefixRecord(block);
                var ocs = OpCodeDataAdapter.GetOpCodeString(block);
                var inxs = formatter.Render(block);
                dst.Add(((OpCodeId)block.OpCode, ocs,inxs));
            }
        }

        void PrefixRecord(OpCodeDataAdapter src)
        {
            
        }
    }
}