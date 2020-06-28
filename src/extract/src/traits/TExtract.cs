//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface TExtract
    {
        BytePatternParser<EncodingPatternKind> PatternParser(byte[] buffer)
            => ExtractParsers.pattern(buffer);

        IExtractParser ExtractParser(byte[] buffer)
            => ExtractParsers.member(buffer);

        IExtractParser ExtractParser(ByteSize bufferlen)
            => ExtractParsers.member(bufferlen);
    }
}