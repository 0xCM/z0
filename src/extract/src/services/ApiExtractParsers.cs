//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct ApiExtractParsers
    {
        [MethodImpl(Inline), Op]
        public static BytePatternParser<EncodingPatternKind> pattern(byte[] buffer)
            => new BytePatternParser<EncodingPatternKind>(EncodingPatterns.Default, buffer);

        [MethodImpl(Inline), Op]
        public static PatternExtractParser member(byte[] buffer)
            => new PatternExtractParser(buffer);

        [MethodImpl(Inline), Op]
        public static PatternExtractParser member(uint size = ApiCodeExtractors.DefaultBufferLength)
            => new PatternExtractParser(sys.alloc<byte>(size));

        [MethodImpl(Inline), Op]
        public static ParseResult<BinaryCode,CodeBlock> parse(in CodeBlock src, in BinaryCode buffer)
        {
            var parser = pattern(buffer);
            var status = parser.Parse(src);
            var matched = parser.Result;
            var succeeded = matched.IsSome() && status.Success();
            return succeeded
                ? ParseResult.win(buffer, new CodeBlock(src.BaseAddress, parser.Parsed))
                : ParseResult.fail<BinaryCode,CodeBlock>(buffer);
        }

        [MethodImpl(Inline), Op]
        public static bool parse(in CodeBlock src, in BinaryCode buffer, out CodeBlock dst)
        {
            var result = parse(src, buffer);
            if(result.Succeeded)
                dst = result.Value;
            else
                dst = CodeBlock.Empty;
            return result.Succeeded;
        }
    }
}