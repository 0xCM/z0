//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    [ApiHost]
    public readonly struct ApiCodeExtractors
    {
        public const int DefaultBufferLength = Pow2.T14 + Pow2.T08;

        [MethodImpl(Inline), Op]
        public static MemberExtractor service(int bufferlen)
            => new MemberExtractor(bufferlen);

        [MethodImpl(Inline), Op]
        public static Option<CodeBlock> parse(CodeBlock src, byte[] buffer)
        {
            if(ApiExtractParsers.parse(src, buffer, out var dst))
                return Option.some(dst);
            else
                return Option.none<CodeBlock>();
        }

        [MethodImpl(Inline), Op]
        public static CodeBlock extract(MemoryAddress src, byte[] buffer)
        {
            Span<byte> target = buffer;
            var length = MemoryExtractor.read(src, target);
            return new CodeBlock(src, sys.array(target.Slice(0,length)));
        }

        [MethodImpl(Inline), Op]
        public static ApiMemberExtract extract(in ApiMember src, Span<byte> buffer)
        {
            var address = src.Address;
            var length = MemoryExtractor.read(address, buffer);
            var extracted = sys.array(buffer.Slice(0,length));
            return new ApiMemberExtract(src, new CodeBlock(address, extracted));
        }

        [Op]
        public static ApiMemberExtract[] extract(ApiMember[] src, Span<byte> buffer)
        {
            var count = src.Length;
            var dst = sys.alloc<ApiMemberExtract>(count);
            var target = span(dst);
            var source = span(src);
            for(var i=0u; i<count; i++)
                seek(target,i) = extract(skip(source,i), sys.clear(buffer));
            return dst;
        }
    }
}