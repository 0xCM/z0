//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static Rules;

    partial struct TextRules
    {
        partial struct Transform
        {
            [Op]
            public static Index<string> apply(SeqSplit<char> rule, string src)
            {
                var output = root.list<string>();
                var len = src?.Length ?? 0;
                var buffer = span<char>(len);
                var input = span(src);
                var j = 0;
                for(var i=0; i<len; i++)
                {
                    ref readonly var c = ref skip(input,i);
                    if(c == rule.Delimiter)
                    {
                        if(j != 0)
                        {
                            output.Add(Format.format(slice(buffer, 0, j)));
                            buffer.Clear();
                            j=0;
                        }
                    }
                    else
                    {
                        buffer[j++] = c;
                    }
                }

                if(j != 0)
                    output.Add(Format.format(slice(buffer, 0, j)));

                return output.ToArray();
            }
        }
    }
}