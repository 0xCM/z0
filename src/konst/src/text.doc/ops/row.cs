//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct TextDocParser
    {
        /// <summary>
        /// Parses a row from a line of text
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="spec">The text format spec</param>
        public static Option<TextRow> row(TextLine src, in TextDocFormat spec)
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
                        data[i] = new TextCell(src.Index, i, parts[i].Trim(Chars.Space));
                    return new TextRow(data);
                }
                else
                    return new TextRow(new TextCell(src.Index, 0, src.Content));
            }
        }
    }
}