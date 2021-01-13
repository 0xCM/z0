//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;
    using static memory;

    public class t_asm_parser : t_asm<t_asm_parser>
    {
        public void part_memory_copy()
        {
            var src = Db.CapturedAsmFile<memory>();
            var doc = asm.doc(src);
            var lines = doc.Lines;
            using var target = AsmCaseWriter();
            foreach(var line in lines)
                target.WriteLine(line.Content);
        }

    }
}
