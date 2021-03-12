//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct TextRules
    {
        partial struct Parse
        {
            /// <summary>
            /// Parses a header row from a line of text
            /// </summary>
            /// <param name="src">The source line</param>
            /// <param name="spec">The text format</param>
            public static bool header(TextLine src, in TextDocFormat spec, out TextDocHeader dst)
            {
                var parts = src.Split(spec);
                var count = parts.Length;
                var buffer = root.list<string>();

                if(parts.Length != 0)
                {
                    for(var i=0; i<count; i++)
                    {
                        var part = parts[i].Trim();
                        if(text.nonempty(part))
                            buffer.Add(part);
                    }
                }

                if(buffer.Count != 0)
                {
                    dst = new TextDocHeader(buffer.ToArray());
                    return true;
                }

                dst = TextDocHeader.Empty;
                return false;
            }
        }
    }
}