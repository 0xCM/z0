//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    using static AsmCommandParser;

    public readonly struct AsmDocParser : IParser<TextDoc,AsmStatementBlock[]>
    {
        public static AsmDocParser Service => default(AsmDocParser);

        public ParseResult<TextDoc,AsmStatementBlock[]> Parse(TextDoc src)
        {
            var headerRows = list<TextRow>(4);
            var rc = src.RowCount;
            for(var i=0; i<rc; i++)
            {
                var row = src[i];
                if(IsBlockSep(row.Text))
                {
                    headerRows.Clear();
                    while(++i < rc)
                    {
                        row = src[i];
                        if(IsCommentLine(row.Text))
                            headerRows.Add(row);
                        else 
                            break;
                    }
                    var header = AsmHeaderParser.Service.Parse(headerRows.Map(x => x.Text));
                }
            }
            return default;
        }
        

    }

}