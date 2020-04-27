//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct StatelessExtract : IStatelessExtract
    {
        public static IStatelessExtract Factory => default(StatelessExtract);
    }

    public interface IStatelessExtract : IStatelessFactory<StatelessExtract>
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