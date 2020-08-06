//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IExtractors
    {
        BytePatternParser<EncodingPatternKind> PatternParser(byte[] buffer)
            => ExtractParsers.pattern(buffer);

        IExtractionParser ExtractParser(byte[] buffer)
            => ExtractParsers.member(buffer);

        IExtractionParser ExtractParser(ByteSize bufferlen)
            => ExtractParsers.member(bufferlen);
    }
}