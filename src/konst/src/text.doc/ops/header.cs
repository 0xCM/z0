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
        /// Parses a header row from a line of text
        /// </summary>
        /// <param name="src">The source line</param>
        /// <param name="spec">The text format</param>
        public static Option<TextDocHeader> header(TextLine src, in TextDocFormat spec)
        {
            try
            {
                var parts = src.Split(spec);
                var count = parts.Length;
                var dst = z.list<string>();

                if(parts.Length != 0)
                {
                    for(var i=0; i<count; i++)
                    {
                        var part = parts[i].Trim();
                        if(text.nonempty(part))
                            dst.Add(part);
                    }
                }

                if(dst.Count != 0)
                    return new TextDocHeader(dst.ToArray());
            }
            catch(Exception e)
            {
                term.error(e);
            }

            return z.none<TextDocHeader>();
        }
    }
}