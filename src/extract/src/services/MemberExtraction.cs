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

    public readonly struct MemberExtraction
    {
        [MethodImpl(Inline)]
        public static MemberExtractor service(int bufferlen)
            => new MemberExtractor(bufferlen);

        [MethodImpl(Inline)]
        public static MemberExtractor service(byte[] buffer)
            => new MemberExtractor(buffer);
        
        static ApiMembers members(IApiHost src)
            => ApiMemberJit.jit(src);

        /// <summary>
        /// Extracts encoded content for all operations defined by a host
        /// </summary>
        /// <param name="src">The source member</param>
        public static ExtractedCode[] extract(IApiHost src, Span<byte> buffer)
            => extract(members(src), buffer);

        /// <summary>
        /// Extracts encoded content for all operations defined by a host
        /// </summary>
        /// <param name="src">The source member</param>
        public static ExtractedCode[] extract(IApiHost src)
            => extract(members(src), sys.alloc<byte>(Extracts.DefaultBufferLength));

        [MethodImpl(Inline), Op]
        public static ExtractedCode extract(in ApiMember src, Span<byte> buffer)
        {
            var address = src.Address;      
            var reader = MemoryReader.Service;
            var length = reader.Read(address, buffer);
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
            var reader = MemoryReader.Service;
            for(var i=0; i<count; i++)
                seek(target,i) = extract(skip(source,i), sys.clear(buffer));
            return dst;
        }

        public static ExtractedCode[] extract(ApiMember[] src)
            => extract(src, sys.alloc<byte>(Extracts.DefaultBufferLength));    
    }
}
