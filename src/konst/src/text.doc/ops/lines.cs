//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    partial struct TextDocs
    {
        public static Index<TextLine> lines(string src)
        {
            var lines = root.list<TextLine>();
            var lineNumber = 0u;
            using (var reader = new StringReader(src))
            {
                var next = reader.ReadLine();
                while (next != null)
                {
                    lines.Add(new TextLine(++lineNumber, next));
                }
            }
            return lines.ToArray();
        }
    }
}