//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static AsmCommandParser;
    using Data;

    [ApiHost]
    public readonly struct AsmParsers
    {
        [MethodImpl(Inline), Op]
        public static AsmStatementParser statement()
            => new AsmStatementParser(ParseMnemonic);
        
        [MethodImpl(Inline), Op]
        public static AsmFieldParser fields()
            => default;            

        [MethodImpl(Inline), Op]
        public static Mnemonic ParseMnemonic(string src)
            => Enums.Parse(src, Mnemonic.INVALID);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T apply<T>(IParser<string,T> parser, string src) 
            where T : struct
                => parser.Parse(src).ValueOrDefault(default(T));

        [MethodImpl(Inline), Op]
        public static ParseResult<AsmCommand> ParseLine(string line, ref int seq)
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
            var sParser = AsmParsers.statement();
            var statement = sParser.Parse(body);
            if(statement.Failed)
                return fail;

            var info = parts[1];
            var descriptors = info.SplitClean(DescriptorSep);                
            if(descriptors.Length !=3)
                return fail;

            var instruction = descriptors[0];
            var opcode = descriptors[1];
            var encoded = ParseEncoded(descriptors[2]);
            if(encoded.Failed)
                return fail;

            return ParseResult.Success(line, new AsmCommand(seq++, statement.Value, opcode, instruction, encoded.Value));
        }

        // Parses text of the form encoded[4]{48 83 ec 40}
        [MethodImpl(Inline), Op]
        public static ParseResult<EncodedCommand> ParseEncoded(string src)
        {       
            var fail = ParseResult.Fail<EncodedCommand>(src);
            var np = NumericParser.create<int>();

            (var iS0, var iS1) = text.indices(src,Chars.LBracket, Chars.RBracket);            
            if(iS0 == -1 || iS1 == -1)
                return fail;
                                
            var size =  np.Parse(text.segment(src, iS0 + 1, iS1 - 1));
            if(size.Failed)
                return fail;
            
            (var iB0, var iB1) = text.indices(src, Chars.LBrace, Chars.RBrace);             
            if(iB0 == -1 || iB1 == -1)
                return fail;

            var count = size.Value;            
            var hexdata = text.segment(src, iB0 + 1, iB1 - 1);
            if(hexdata.Length != count)
                return fail;

            var hexparser = Parsers.hex(true);
            var bytesMaybe = hexparser.ParseData(hexdata);
            if(bytesMaybe.Failed)
                return fail;
            
            var bytes = bytesMaybe.Value;
            if(bytes.Length != count)
                return fail;
            
            return ParseResult.Success(src, Encoding.encode(bytes));
        }        
 
    }
}