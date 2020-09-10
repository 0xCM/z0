//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static Konst;
    using static AsmCommandParser;
    using static z;

    [ApiHost]
    public readonly struct AsmParsers
    {
        [MethodImpl(Inline), Op]
        public static AsmStatementParser statement()
            => new AsmStatementParser(ParseMnemonic);

        [MethodImpl(Inline), Op]
        public static Mnemonic ParseMnemonic(string src)
            => Enums.Parse(src, Mnemonic.INVALID);

        [MethodImpl(Inline), Op]
        public static ParseResult<AsmStatementEncoding> statement(string line, ref uint seq)
        {
            var fail = ParseResult<AsmStatementEncoding>.Fail(line);

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

            return ParseResult.Success(line, new AsmStatementEncoding(seq++, statement.Value, new AsmFxCode(opcode, instruction), encoded.Value));
        }

        [MethodImpl(Inline), Nlz]
        static int nlz(ulong src)
            => (int)Lzcnt.X64.LeadingZeroCount(src);

        [MethodImpl(Inline)]
        static int hipos(ulong src)
            => (int)bitsize<ulong>() - 1 - nlz(src);

        [MethodImpl(Inline)]
        static byte effsize(ulong src)
            => math.sub(math.log2((byte)hipos(src)), One8u);

        [MethodImpl(Inline)]
        static ReadOnlySpan<byte> bytes(in EncodedFx src)
            => Fixed.view<byte>(Fixed.from(src.Data)).Slice((int)size(src));

        [MethodImpl(Inline)]
        static EncodedFx encode(ReadOnlySpan<byte> src)
        {
            var dst = default(Vector128<byte>);
            var count = src.Length;
            var max = min(15,count);
            for(var i=0; i<max; i++)
                dst = dst.WithElement(i, skip(src,i));
            var c = new EncodedFx(dst.WithElement(15, (byte)count));
            var b = bytes(c);
            return c;
        }

        [MethodImpl(Inline)]
        static EncodedFx encode(ulong lo64)
        {
            var hi64 = (ulong)(effsize(lo64)/8) << 56;
            var v = v8u(Vector128.Create(lo64, hi64));
            return new EncodedFx(v);
        }

        // Parses text of the form encoded[4]{48 83 ec 40}
        [MethodImpl(Inline), Op]
        public static ParseResult<EncodedFx> ParseEncoded(string src)
        {
            var fail = ParseResult.Fail<EncodedFx>(src);
            var np = Parsers.numeric<int>();

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

            return ParseResult.Success(src, encode(bytes));
        }
    }
}