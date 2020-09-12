//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;

    [ApiHost]
    public readonly struct X86Extraction
    {
        public const int DefaultBufferLength = Pow2.T14 + Pow2.T08;

        [MethodImpl(Inline), Op]
        public static MemberExtractor service(int bufferlen)
            => new MemberExtractor(bufferlen);

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


        [MethodImpl(Inline), Op]
        public static X86ApiExtract extract(in ApiMember src, Span<byte> buffer)
        {
            var address = src.Address;
            var length = MemoryExtractor.read(address, buffer);
            var extracted = sys.array(buffer.Slice(0,length));
            return new X86ApiExtract(src, new X86Code(address, extracted));
        }

        [Op]
        public static X86ApiExtract[] extract(ApiMember[] src, Span<byte> buffer)
        {
            var count = src.Length;
            var dst = sys.alloc<X86ApiExtract>(count);
            var target = span(dst);
            var source = span(src);
            for(var i=0; i<count; i++)
                seek(target,i) = extract(skip(source,i), sys.clear(buffer));
            return dst;
        }
    }
}