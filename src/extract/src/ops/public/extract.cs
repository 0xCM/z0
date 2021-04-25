//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct ApiExtracts
    {
        [Op]
        public static unsafe ApiMemberExtract[] extract(ReadOnlySpan<ApiMember> src, Span<byte> buffer)
        {
            var count = src.Length;
            var dst = memory.alloc<ApiMemberExtract>(count);
            ref var target = ref first(dst);
            for(var i=0u; i<count; i++)
                seek(target, i) = extract(skip(src, i), sys.clear(buffer));
            return dst;
        }

        [Op]
        public static unsafe ApiMemberExtract extract(in ApiMember src, Span<byte> dst)
        {
            var address = src.BaseAddress;
            var length = extract(address, dst);
            var extracted = sys.array(dst.Slice(0,length));
            return new ApiMemberExtract(src, new ApiExtractBlock(address, src.OpUri, extracted));
        }
    }
}
