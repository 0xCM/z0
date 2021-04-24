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

    [ApiHost]
    public readonly struct ApiExtracts
    {
        const int DefaultBufferLength = Pow2.T14 + Pow2.T08;

        const int MaxZeroCount = 10;

        [MethodImpl(Inline), Op]
        public static EncodingParser patterns(byte[] buffer)
            => new EncodingParser(EncodingPatterns.Default, buffer);

        [MethodImpl(Inline), Op]
        public static PatternExtractParser parser(uint size = DefaultBufferLength)
            => new PatternExtractParser(sys.alloc<byte>(size));

        [Op]
        public static Index<ApiCodeBlock> parse(ReadOnlySpan<ApiExtractBlock> src)
        {
            var count = src.Length;
            var buffer = alloc<ApiCodeBlock>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = parse(skip(src,i));
            return buffer;
        }

        [Op]
        public static ApiCodeBlock parse(in ApiExtractBlock src)
        {
            var j = terminal(src);
            var code = slice(src.View, 0, j);
            return new ApiCodeBlock(src.BaseAddress, src.Uri, code.ToArray());
        }

        [MethodImpl(Inline), Op]
        public static uint parse(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            var j = terminal(src);
            var code = slice(src,0,j);
            code.CopyTo(dst);
            return j;
        }

        [MethodImpl(Inline), Op]
        static uint terminal(ReadOnlySpan<byte> src)
        {
            var count = (uint)src.Length;
            var j = count;
            var test = 0u;
            for(var i=0u; i<count - 1; i++)
            {
                test = terminal(skip(src,i),skip(src, i+1));
                if(test !=0)
                {
                    j = i + test;
                    break;
                }
            }

            return j;
        }

        /// <summary>
        /// Attempts to find the logical end of the block
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        static uint terminal(in ApiExtractBlock src)
            => terminal(src.Encoded.View);

        /// <summary>
        /// Tests for a terminal opcode sequence
        /// </summary>
        /// <param name="a0"></param>
        /// <param name="a1"></param>
        /// <returns>
        /// This follows https://github.com/microsoft/Detours/samples/disas/disas.cpp, but seems to miss a lot
        /// </returns>
        [MethodImpl(Inline), Op]
        static byte terminal(byte a0, byte a1)
        {
            if(0xC3 == a0 && 0x00 == a1)
                return 2;

            if (0xCB == a0 || 0xC2 == a0 || 0xCA == a0 || 0xEB == a0 || 0xE9 == a0 || 0xEA == a0)
                return 1;

            if(0xff == a0 && 0x25 == a1)
                return 2;

            return 0;
        }

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
        public static unsafe ApiMemberExtract extract(in ApiMember src, Span<byte> buffer)
        {
            var address = src.BaseAddress;
            var length = extract(address, buffer);
            var extracted = sys.array(buffer.Slice(0,length));
            return new ApiMemberExtract(src, new ApiExtractBlock(address, src.OpUri, extracted));
        }

        [MethodImpl(Inline), Op]
        static unsafe int extract(MemoryAddress src, Span<byte> dst)
        {
            var pSrc = src.Pointer<byte>();
            var limit = dst.Length;
            return read(ref pSrc, limit, dst);
        }

        [MethodImpl(Inline), Op]
        static unsafe int read(ref byte* pSrc, int count, Span<byte> dst)
            => read(ref pSrc, count, ref first(dst));

        [MethodImpl(Inline), Op]
        static unsafe int read(ref byte* pSrc, int limit, ref byte dst)
        {
            var offset = 0;
            var count = 0;
            while(offset < limit && count < MaxZeroCount)
            {
                var value = Unsafe.Read<byte>(pSrc++);
                seek(dst, offset++) = value;
                if(value != 0)
                    count = 0;
                else
                    count++;
            }
            return offset;
        }
    }
}