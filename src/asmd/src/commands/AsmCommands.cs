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

    public class AsmCommands
    {
        /// <summary>
        /// Computes the length, in bytes, of the encoded content
        /// </summary>
        /// <param name="src">The command source</param>
        [MethodImpl(Inline), Op]
        public static byte size(in EncodedCommand src)
            => vcell(src.Data, 15);

        [Op]
        public static string format(in EncodedCommand src)
        {         
            var data = encoding(src);
            var size = src.EncodingSize;
            return text.concat($"data", text.bracket(size), Chars.Colon, text.embrace(data.FormatHex()));
        }

        /// <summary>
        /// Presents the encoded content as a bytespan of variable length from 0 to 15 bytes
        /// </summary>
        /// <param name="src">The command source</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> encoding(in EncodedCommand src)
            => Fixed.view<byte>(Fixed.from(src.Data)).Slice(size(src));        

        /// <summary>
        /// Defines a command from data supplied by a bytespan
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static EncodedCommand encode(ReadOnlySpan<byte> src)
        {
            var dst = default(Vector128<byte>);
            var count = src.Length;
            var max = math.min(15,count);
            for(var i=0; i<max; i++)
                dst = dst.WithElement(i, skip(src,i));
            return  new EncodedCommand(dst.WithElement(15, (byte)count));            
        }

        /// <summary>
        /// Creates a command from data supplied in a 64-bit unsigned integer
        /// </summary>
        /// <param name="lo64">The data source</param>
        [MethodImpl(Inline), Op]
        public static EncodedCommand encode(ulong lo64)
        {
            var hi64 = (ulong)(Bits.effsize(lo64)/8) << 56;
            var v = v8u(Vector128.Create(lo64, hi64));
            return new EncodedCommand(v); 
        }

        /// <summary>
        /// Creates a command from the data supplied in a 64-bit unsigned integer
        /// </summary>
        /// <param name="lo32">The data source</param>
        [MethodImpl(Inline), Op]
        public static EncodedCommand encode(uint lo32)
            => encode((ulong)lo32);
         
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
        
        public static ParseResult<AsmHeader> ParseHeader(string[] lines)
        {

            var input = text.join(Chars.Space, lines);

            var fail = ParseResult.Fail<AsmHeader>(input);
            if(lines.Length < 4)
                return fail;

            var l0 = lines[0].RightOf(CommentMarker);
            var sig = l0.LeftOf(LocatedMarker);
            var uriParse = OpUriParser.The.Parse(text.concat(LocatedMarker,l0.RightOf(LocatedMarker)));
            if(uriParse.Failed)
                return fail;
            var uri = uriParse.Value;

            var prop = lines[1].RightOf(CommentMarker);

            var l2Parts = lines[2].RightOf(CommentMarker).SplitClean(Assign);
            var baseText = l2Parts.Length == 2 ? l2Parts[1] : string.Empty;
            var @base = MemoryAddress.From(HexScalarParser.Service.Parse(baseText).ValueOrDefault(0ul));
            
            var l3Parts = lines[3].RightOf(CommentMarker).SplitClean(Assign);
            var tcText = l3Parts.Length == 2 ? l3Parts[1] : string.Empty;
            var tcVal = Enums.Parse(tcText, ExtractTermCode.None);

            return ParseResult.Success(input, new AsmHeader(uri, sig, prop, @base, tcVal));
        }
        
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
                                
                if(IsSegSepLine(line))
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
                                ParseHeader(comments.ToArray()).OnSuccess(HeaderParsed);
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
            
            return ParseResult.Success(src, encode(bytes));
        }

        const string LocatedMarker = "located://";

        const char Assign = Chars.Eq;

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