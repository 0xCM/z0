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
    public readonly struct ExtractParsers
    {
        [MethodImpl(Inline), Op]
        public static BytePatternParser<EncodingPatternKind> pattern(byte[] buffer)
            => new BytePatternParser<EncodingPatternKind>(EncodingPatterns.Default, buffer);

        [MethodImpl(Inline), Op]
        public static PatternExtractParser member(byte[] buffer)
            => new PatternExtractParser(buffer);

        [MethodImpl(Inline), Op]
        public static PatternExtractParser member(uint size = X86Extraction.DefaultBufferLength)
            => new PatternExtractParser(sys.alloc<byte>(size));

        [MethodImpl(Inline), Op]
        public static ParseResult<BinaryCode,X86Code> parse(in X86Code src, in BinaryCode buffer)
        {
            var parser = pattern(buffer);
            var status = parser.Parse(src);
            var matched = parser.Result;
            var succeeded = matched.IsSome() && status.Success();
            return succeeded
                ? ParseResult.Success(buffer, new X86Code(src.Base, parser.Parsed))
                : ParseResult.Fail<BinaryCode,X86Code>(buffer);
        }

        [MethodImpl(Inline), Op]
        public static bool parse(in X86Code src, in BinaryCode buffer, out X86Code dst)
        {
            var result = parse(src, buffer);
            if(result.Succeeded)
                dst = result.Value;
            else
                dst = X86Code.Empty;
            return result.Succeeded;
        }
    }
}