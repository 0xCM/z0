//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Extract;

    public readonly struct Extract : IExtract
    {
        public static IExtract Services => default(Extract);

        internal const int DefaultBufferLength = Pow2.T14;
    }

    public interface IExtract : IStateless<Extract>
    {
        IMemberExtractor MemberExtractor
            => new MemberExtractor(DefaultBufferLength);

        [MethodImpl(Inline)]
        ILocatedCodeParser LocatedParser(byte[] buffer) 
            => new LocatedCodeParser(buffer);

        [MethodImpl(Inline)]
        ILocatedCodeParser LocatedParser() 
            => new LocatedCodeParser(new byte[DefaultBufferLength]);

        [MethodImpl(Inline)]
        ByteParser<EncodingPatternKind> PatternParser(byte[] buffer)
            => ByteParser<EncodingPatternKind>.Create(EncodingPatterns.Default, buffer);

        [MethodImpl(Inline)]
        IExtractParser ExtractParser(byte[] buffer)
            => new MemberExtractParser(buffer);

        [MethodImpl(Inline)]
        IExtractParser ExtractParser(int? bufferlen = null)
            => new MemberExtractParser(new byte[bufferlen ?? DefaultBufferLength]);
    }
}