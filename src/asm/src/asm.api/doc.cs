//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmDocParts;
    using static TextRules;
    using static memory;

    partial struct asm
    {
        [Op]
        public static AsmDoc doc(string src)
        {
            var lines = Parse.lines(src);
            var count = lines.Count;
            var dst = alloc<DocLine>(count);
            ref var target = ref first(dst);
            ref readonly var source = ref lines.First;
            for(var i=0u; i<count; i++)
                seek(target,i) = new DocLine(i, skip(source, i).Content);

            return new AsmDoc(dst);
        }

        [Op]
        public static AsmDoc doc(FS.FilePath src)
            => doc(src.ReadText());
    }
}