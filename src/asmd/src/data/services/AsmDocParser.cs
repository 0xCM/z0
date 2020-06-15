//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Memories;
    using static AsmCommandParser;

    public readonly struct AsmDocParser : IParser<TextDoc,AsmStatementBlock[]>
    {
        public static AsmDocParser Service => default(AsmDocParser);

        public ParseResult<TextDoc,AsmStatementBlock[]> Parse(TextDoc src)
        {
            var hParser = AsmHeaderParser.Service;
            var sParser = AsmStatementParser.Default;
            var hexp = HexScalarParser.Service;

            var blocks = src.Partition(0, r => IsBlockSep(r.Text)).ToReadOnlySpan();   
            for(var i =0; i<blocks.Length; i++)
            {
                ref readonly var rows = ref skip(blocks,i);
                var k = 0;
                for(var j = 0; j < rows.Length; j++)
                {
                    var row = rows[j].Text;
                    if(IsCommentLine(row))
                    {
                        k++;
                    }
                    else
                    {
                        if(k != 0)
                        {
                            var offset = hexp.Parse(row.LeftOf(Chars.Space));

                        }
                    }
                }
            }

            return default;
        }        
    }
}