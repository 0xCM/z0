//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Extract : IExtract
    {
        public static IExtract Services => default(Extract);


        /// <summary>
        /// Creates a code extractor with an optionally-specified buffer length
        /// </summary>
        /// <param name="bufferlen">The desired buffer length</param>
        [MethodImpl(Inline)]
        IHostCodeExtractor HostExtractor(int? bufferlen)
            => new HostCodeExtractor(bufferlen ?? Pow2.T14);

    }

    public interface IExtract : IStatelessFactory<Extract>
    {
        [MethodImpl(Inline)]
        ByteParser<EncodingPatternKind> PatternParser(byte[] buffer)
            => ByteParser<EncodingPatternKind>.Create(EncodingPatterns.Default,  buffer);

        [MethodImpl(Inline)]
        IExtractParser ExtractParser(byte[] buffer)
            => Z0.ExtractParser.Create(buffer);

        [MethodImpl(Inline)]
        IExtractParser ExtractParser(int? bufferlen = null)
            => Z0.ExtractParser.Create(bufferlen);        
    }
}