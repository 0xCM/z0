//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    partial struct TextDocParser
    {
        /// <summary>
        /// Parses a row from a line of text
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="spec">The text format spec</param>
        public static Option<TextRow> row(TextDocLine src, in TextDocFormat spec)
        {            
            if(src.IsEmpty ||  src[0] == spec.CommentPrefix)
                return default;
            else
            {            
                if(spec.HasDataHeader)
                {
                    var parts = src.Split(spec);
                    var data = new TextCell[parts.Length];
                    for(var i=0u; i<parts.Length; i++)
                        data[i] = new TextCell(src.LineNumber, i, parts[i].Trim(Chars.Space));
                    return new TextRow(data);
                }
                else
                    return new TextRow(new TextCell(src.LineNumber, 0, src.LineText));
            }
        }
    }
}