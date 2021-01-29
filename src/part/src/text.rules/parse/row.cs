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

    partial struct TextRules
    {
        partial struct Parse
        {
            /// <summary>
            /// Parses a row from a line of text
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="spec">The text format spec</param>
            public static bool row(TextLine src, in TextDocFormat spec, out TextRow dst)
            {
                if(src.IsEmpty || src.StartsWith(spec.CommentPrefix) || src.StartsWith(spec.RowBlockSep))
                {
                    dst = TextRow.Empty;
                    return false;
                }
                else
                {
                    if(spec.HasDataHeader)
                    {
                        var parts = src.Split(spec);
                        var count = parts.Length;
                        var buffer = memory.alloc<TextBlock>(count);
                        ref var target= ref first(buffer);
                        for(var i=0u; i<count; i++)
                            seek(target, i) = new TextBlock(parts[i].Trim());
                        dst= new TextRow(buffer);
                    }
                    else
                        dst = new TextRow(new TextBlock(src.Content));

                    return true;
                }
            }
        }
    }
}