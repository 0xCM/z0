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
                return root.some(dst);
            else
                return root.none<CodeBlock>();
        }

        [MethodImpl(Inline), Op]
        public static CodeBlock extract(MemoryAddress src, byte[] buffer)
        {
            Span<byte> target = buffer;
            var length = MemoryExtractor.extract(src, target);
            return new CodeBlock(src, sys.array(target.Slice(0,length)));
        }

        [Op]
        public static ApiMemberExtract[] extract(ReadOnlySpan<ApiMember> src, Span<byte> buffer)
        {
            var count = src.Length;
            var dst = memory.alloc<ApiMemberExtract>(count);
            ref var target = ref first(dst);
            for(var i=0u; i<count; i++)
                seek(target, i) = extract(skip(src, i), sys.clear(buffer));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ApiMemberExtract extract(in ApiMember src, Span<byte> buffer)
        {
            var address = src.BaseAddress;
            var length = MemoryExtractor.extract(address, buffer);
            var extracted = sys.array(buffer.Slice(0,length));
            return new ApiMemberExtract(src, new CodeBlock(address, extracted));
        }
    }
}