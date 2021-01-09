//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;

    public readonly partial struct TextRules
    {
        partial struct Parse
        {
            /// <summary>
            /// Splits the source text into lines
            /// </summary>
            /// <param name="src">The source text</param>
            public static Index<TextLine> lines(string src)
            {
                var count = text.length(src);
                if(count == 0)
                    return Index<TextLine>.Empty;


                var dst = root.list<TextLine>();
                var input = span(src);
                var lastix = count - 1;
                var len = 0;
                var segStart = 0;
                var segEnd = -1;
                for(var i=0; i<count; i++)
                {
                    ref readonly var c = ref skip(input,i);
                    if(Test.cr(c))
                    {
                        if(i != lastix)
                        {
                            ref readonly var next = ref skip(input, i + 1);
                            if(Test.lf(next))
                                segEnd = i - 1;
                            else
                                segEnd = i;
                        }
                    }
                    else if(Test.lf(c))
                        segEnd = i;

                    if(segEnd > 0)
                    {
                        dst.Add((segStart, slice(src, segStart, segEnd)));
                        segStart = i + 1;
                        segEnd = -1;
                    }
                }

                return dst.ToArray();
            }
        }
    }
}