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
    public readonly struct MemberExtraction
    {
        [MethodImpl(Inline), Op]
        public static MemberExtractor service(int bufferlen)
            => new MemberExtractor(bufferlen);

        [MethodImpl(Inline), Op]
        public static MemberExtractor service(byte[] buffer)
            => new MemberExtractor(buffer);

        [MethodImpl(Inline), Op]
        public static ApiMembers members(IApiHost src)
            => ApiMemberJit.jit(src);

        [MethodImpl(Inline), Op]
        public static ApiMembers members(IApiHost[] src, IWfBroker broker)
            => ApiMemberJit.jit(src, broker.Sink);

        /// <summary>
        /// Extracts encoded content for all operations defined by a host
        /// </summary>
        /// <param name="src">The source member</param>
        [MethodImpl(Inline), Op]
        public static ExtractedCode[] extract(IApiHost src, Span<byte> buffer)
            => extract(members(src), buffer);

        /// <summary>
        /// Extracts encoded content for all operations defined by a host
        /// </summary>
        /// <param name="src">The source member</param>
        [MethodImpl(Inline), Op]
        public static ExtractedCode[] extract(IApiHost src)
            => extract(members(src), sys.alloc<byte>(Extractors.DefaultBufferLength));

        [MethodImpl(Inline), Op]
        public static ExtractedCode extract(in ApiMember src, Span<byte> buffer)
        {
            var address = src.Address;
            var length = MemoryExtractor.read(address, buffer);
            var extracted = sys.array(buffer.Slice(0,length));
            return new ExtractedCode(src, new LocatedCode(address, extracted));
        }

        [Op]
        public static ExtractedCode[] extract(ApiMember[] src, Span<byte> buffer)
        {
            var count = src.Length;
            var dst = sys.alloc<ExtractedCode>(count);
            var target = span(dst);
            var source = span(src);
            for(var i=0; i<count; i++)
                seek(target,i) = extract(skip(source,i), sys.clear(buffer));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ExtractedCode[] extract(ApiMember[] src)
            => extract(src, sys.alloc<byte>(Extractors.DefaultBufferLength));
    }
}