//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    partial struct TextRules
    {
        partial struct Parse
        {
            [Op]
            public static TextLines lines(string src, bool keepblank = false)
            {
                var lines = root.list<TextLine>();
                var lineNumber = 0u;
                using (var reader = new StringReader(src))
                {
                    var next = reader.ReadLine();
                    while (next != null)
                    {
                        var blank = Query.blank(next);
                        if(blank)
                        {
                            if(keepblank)
                                lines.Add(new TextLine(++lineNumber, next));
                        }
                        else
                            lines.Add(new TextLine(++lineNumber, next));

                        next = reader.ReadLine();
                    }
                }
                return lines.ToArray();
            }

            [Op]
            public static Count lines(string src, Action<TextLine> receiver)
            {
                var lineNumber = 0u;
                using(var reader = new StringReader(src))
                {
                    var next = reader.ReadLine();
                    while(next != null)
                    {
                        receiver(new TextLine(++lineNumber, next));
                        next = reader.ReadLine();
                    }
                }
                return lineNumber;
            }
        }
    }
}