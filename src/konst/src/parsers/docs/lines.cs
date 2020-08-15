//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Collections.Generic;

    using static Konst;

    partial struct TextDocParser    
    {
        public static ParseResult<TextDocLine[]> lines(string src)
        {
            var lines = new List<TextDocLine>();
            var lineNumber = 0u;
            using (var reader = new StringReader(src))
            {
                var next = reader.ReadLine();
                while (next != null)
                {
                    lines.Add(new TextDocLine(++lineNumber, next));
                }
            }
            return ParseResult.Success(src, lines.ToArray());
        }
    }
}