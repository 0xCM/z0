//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Konst;
    using static z;
    using static AsmCommandParser;

    [ApiHost]
    public readonly struct AsmFileParser
    {
        [Op]
        public static void ParseAsmFile(FilePath src, Action<int,AsmStatementEncoding[]> AsmParsed, Action<AsmRoutineHeader> HeaderParsed = null)
        {
            var commands = list<AsmStatementEncoding>(100);
            var comments = list<string>(8);

            var i = 0;
            var seq = 0u;

            using var reader = src.Reader();
            reader.ReadLine();

            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();

                if(IsBlockSep(line))
                {
                    AsmParsed(i++, commands.ToArray());
                    commands.Clear();
                    seq=0;
                    continue;
                }

                if(IsCommentLine(line))
                {
                    if(HeaderParsed != null)
                    {
                        comments.Clear();
                        comments.Add(line);
                        while(!reader.EndOfStream)
                        {
                            line = reader.ReadLine();
                            if(IsCommentLine(line))
                                comments.Add(line);
                            else
                            {
                                AsmHeaderParser.Service.Parse(comments.ToArray().Concat(Chars.NL)).OnSuccess(HeaderParsed);
                                break;
                            }
                        }
                    }
                    else
                        continue;
                }

                var parsed = AsmParsers.statement(line, ref seq);
                if(parsed.Failed)
                    continue;

                commands.Add(parsed.Value);
            }
        }
    }
}