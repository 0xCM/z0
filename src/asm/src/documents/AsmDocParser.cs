//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static AsmDocParts;
    using static TextRules;
    using static z;

    public struct AsmDocParser
    {
        AsmDocLine parse(TextLine src)
        {
            return new AsmDocLine(src);
        }

        public static AsmDoc parse(string src)
        {
            var parser = new AsmDocParser();
            var lines = Parse.lines(src);
            var count = lines.Count;
            var dst = sys.alloc<AsmDocLine>(count);
            ref var target = ref first(dst);
            ref readonly var source = ref lines.First;
            for(var i=0; i<count; i++)
                seek(target,i) = parser.parse(skip(source,i));

            return new AsmDoc(dst);
        }
    }
}