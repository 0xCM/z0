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

        /// <summary>
        /// Extracts encoded content for all operations defined by a host
        /// </summary>
        /// <param name="src">The source member</param>
        [MethodImpl(Inline), Op]
        public static X86ApiExtract[] extract(IApiHost src, Span<byte> buffer)
            => extract(members(src), buffer);

        /// <summary>
        /// Extracts encoded content for all operations defined by a host
        /// </summary>
        /// <param name="src">The source member</param>
        [MethodImpl(Inline), Op]
        public static X86ApiExtract[] extract(IApiHost src)
            => extract(members(src), sys.alloc<byte>(Extractors.DefaultBufferLength));

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

        [MethodImpl(Inline), Op]
        public static X86ApiExtract[] extract(ApiMember[] src)
            => extract(src, sys.alloc<byte>(Extractors.DefaultBufferLength));
    }
}