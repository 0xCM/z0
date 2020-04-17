//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    
    public static class ServiceFactory
    {

        [MethodImpl(Inline)]
        public static ByteParser<EncodingPatternKind> PatternParser(this IContext context, byte[] buffer)
            => ByteParser<EncodingPatternKind>.Create(context, EncodingPatterns.Default,  buffer);

        [MethodImpl(Inline)]
        public static IExtractParser ExtractParser(this IContext context, byte[] buffer)
            => Z0.ExtractParser.Create(context, buffer);

        [MethodImpl(Inline)]
        public static IExtractParser ExtractParser(this IContext context, int? bufferlen = null)
            => Z0.ExtractParser.Create(context, bufferlen);
    }
}