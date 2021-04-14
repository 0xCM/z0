//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;
    using static TextRules;

    partial class text
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
                    if(Query.blank(next))
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
        public static Count lines(string src, Action<TextLine> receiver, bool keepblank = false)
        {
            var lineNumber = 0u;
            using(var reader = new StringReader(src))
            {
                var next = reader.ReadLine();
                while(next != null)
                {
                    if(Query.blank(next))
                    {
                        if(keepblank)
                            receiver(new TextLine(++lineNumber, next));
                    }
                    else
                        receiver(new TextLine(++lineNumber, next));
                    next = reader.ReadLine();
                }
            }
            return lineNumber;
        }
    }
}