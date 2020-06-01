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

    using static Seed;

    public readonly struct TextLineParser : IParser<TextLine[]>
    {
        public static TextLineParser Service => default;

        public ParseResult<TextLine[]> Parse(string src)
        {
            var lines = new List<TextLine>();
            var lineNumber = 0u;
            using (var reader = new StringReader(src))
            {
                var next = reader.ReadLine();
                while (next != null)
                {
                    lines.Add(new TextLine(++lineNumber, next));
                }
            }
            return ParseResult.Success(src, lines.ToArray());
        }
    }
}