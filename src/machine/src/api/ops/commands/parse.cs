//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;

    using static Seed;
    using static Memories;
    
    partial class Commands
    {        
        public static ParseResult<AsmCommand> ParseAsmLine(string line, ref int seq)
        {
            var fail = ParseResult<AsmCommand>.Fail(line);

            if(IsBlankLine(line))
                return fail;
            
            if(IsCommentLine(line))
                return fail;

            var parts = line.SplitClean(BodySep);
            if(parts.Length != 2)
                return fail;

            var body = parts[0];
            var info = parts[1];
            var descriptors = info.SplitClean(DescriptorSep);                
            if(descriptors.Length !=3)
                return fail;

            var instruction = descriptors[0];
            var opcode = descriptors[1];
            var encoded = ParseEncoded(descriptors[2]);
            if(encoded.Failed)
                return fail;

            return ParseResult.Success(line, new AsmCommand(seq++, body, opcode, instruction, encoded.Value));
        }
        
        public static void ParseAsmFile(FilePath src, Action<int,AsmCommand[]> OnParsed)
        {
            var commands = list<AsmCommand>(100);            
            var i = 0;
            var seq = 0;

            using var reader = src.Reader();
            reader.ReadLine();
            
            while(!reader.EndOfStream)
            {                
                var line = reader.ReadLine();
                                
                if(IsSegSepLine(line))
                {
                    OnParsed(i++, commands.ToArray());
                    commands.Clear();
                    seq=0;
                    continue;
                }
                
                var parsed = ParseAsmLine(line, ref seq);
                if(parsed.Failed)
                    continue;

                commands.Add(parsed.Value);
            }                                            
        }

        // Parses text of the form encoded[4]{48 83 ec 40}
        static ParseResult<EncodedCommand> ParseEncoded(string src)
        {       
            var fail = ParseResult.Fail<EncodedCommand>(src);
            var np = NumericParser.create<int>();

            (var iS0, var iS1) = text.indices(src,Chars.LBracket, Chars.RBracket);
            
            if(iS0 == -1 || iS1 == -1)
                return fail;
                                
            var size =  np.Parse(text.segment(src, iS0 + 1, iS1 - 1));
            if(size.Failed)
                return fail;
            
            var count = size.Value;
            
            (var iB0, var iB1) = text.indices(src, Chars.LBrace, Chars.RBrace); 
            
            if(iB0 == -1 || iB1 == -1)
                return fail;

            var hexdata = text.segment(src, iB0 + 1, iB1 - 1);
            if(hexdata.Length != count)
                return fail;

            var hexparser = HexParsers.Bytes;
            var bytesMaybe = hexparser.ParseData(hexdata);
            if(bytesMaybe.Failed)
                return fail;
            
            var bytes = bytesMaybe.Value;
            if(bytes.Length != count)
                return fail;
            
            return ParseResult.Success(src, Commands.encode(bytes));
        }

        const string SegSepMarker = "-----";

        const string DescriptorSep = "||";       

        const char BodySep = Chars.Semicolon;

        const char CommentMarker = Chars.Semicolon;

        [MethodImpl(Inline)]
        static bool IsCommentLine(string src)
            => src.Trim().StartsWith(CommentMarker);

        [MethodImpl(Inline)]
        static bool IsSegSepLine(string src)
            => src.Trim().StartsWith(SegSepMarker);

        [MethodImpl(Inline)]
        static bool IsBlankLine(string src)
            => string.IsNullOrWhiteSpace(src);

    }
}