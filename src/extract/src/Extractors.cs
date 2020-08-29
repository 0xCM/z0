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
    public readonly struct Extractors : IExtractors
    {
        public static IExtractors Services => default(Extractors);

        public const int DefaultBufferLength = Pow2.T14 + Pow2.T08;

        [MethodImpl(Inline), Op]
        public static IExtractionParser parser(byte[] buffer)
            => ExtractParsers.member(buffer);

        [MethodImpl(Inline), Op]
        public static IExtractionParser parser(ByteSize bufferlen)
            => ExtractParsers.member(bufferlen);

        [MethodImpl(Inline), Op]
        public static Option<X86Code> parse(X86Code src, byte[] buffer)
        {
            if(ExtractParsers.parse(src, buffer, out var dst))
                return Option.some(dst);
            else
                return Option.none<X86Code>();
        }

        [MethodImpl(Inline), Op]
        public static X86Code extract(MemoryAddress src, byte[] buffer)
        {
            Span<byte> target = buffer;
            var length = MemoryExtractor.read(src, target);
            return new X86Code(src, sys.array(target.Slice(0,length)));
        }
    }
}