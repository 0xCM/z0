//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;
    using static Part;

    partial struct TextRules
    {
        partial struct Parse
        {
            const string CRLF = "\r\n";

            /// <summary>
            /// Splits the source text into lines
            /// </summary>
            /// <param name="src">The source text</param>
            [Op]
            public static Index<TextLine> lines(string src)
            {
                var parts = @readonly(split(src, CRLF));
                var count = parts.Length;
                var buffer = alloc<TextLine>(count);
                ref var dst = ref first(buffer);
                for(var i=0u; i<count; i++)
                    seek(dst,i) = new TextLine(i, skip(parts,i));
                return buffer;
            }
        }
    }
}