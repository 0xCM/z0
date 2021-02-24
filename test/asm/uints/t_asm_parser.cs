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
        ITextBuffer Buffer;

        public void part_memory_copy()
        {
            Buffer = text.buffer();
            var src = Db.AsmFile<memory>();
            var doc = AsmDoc.load(src);
            var lines = doc.Content;
            using var target = AsmCaseWriter();
            foreach(var line in lines)
            {
                Parse(line);
                target.WriteLine(Buffer.Emit());
            }
        }

        void Parse(in AsmDocLine src)
        {
            Buffer.Append(src.Content);
        }
    }
}
