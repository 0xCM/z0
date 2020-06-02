//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    using static AsmCommandParser;

    public readonly struct AsmFileParser
    {
        public static void ParseAsmFile(FilePath src, Action<int,AsmCommand[]> AsmParsed, Action<AsmHeader> HeaderParsed = null)
        {
            var commands = list<AsmCommand>(100);            
            var comments = list<string>(8);

            var i = 0;
            var seq = 0;

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

                var parsed = ParseAsmLine(line, ref seq);
                if(parsed.Failed)
                    continue;

                commands.Add(parsed.Value);
            }                                            
        }
    }
}