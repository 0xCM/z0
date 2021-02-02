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
    public unsafe readonly struct ApiCodeExtractors
    {
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

        public const int DefaultBufferLength = Pow2.T14 + Pow2.T08;

        const int MaxZeroCount = 10;

        [MethodImpl(Inline), Op]
        public static ApiMemberExtractor service(int bufferlen = DefaultBufferLength)
            => new ApiMemberExtractor(bufferlen);

        [MethodImpl(Inline), Op]
        public static BytePatternParser<EncodingPatternKind> patterns(byte[] buffer)
            => new BytePatternParser<EncodingPatternKind>(EncodingPatterns.Default, buffer);

        [MethodImpl(Inline), Op]
        public static PatternExtractParser parser(byte[] buffer)
            => new PatternExtractParser(buffer);

        [MethodImpl(Inline), Op]
        public static PatternExtractParser parser(uint size = DefaultBufferLength)
            => new PatternExtractParser(sys.alloc<byte>(size));

        [MethodImpl(Inline), Op]
        public static Option<CodeBlock> parse(CodeBlock src, byte[] buffer)
        {
            if(parse(src, buffer, out var dst))
                return root.some(dst);
            else
                return root.none<CodeBlock>();
        }

        [MethodImpl(Inline), Op]
        public static CodeBlock extract(MemoryAddress src, byte[] buffer)
        {
            Span<byte> target = buffer;
            var length = extract(src, target);
            return new CodeBlock(src, sys.array(target.Slice(0, length)));
        }

        [MethodImpl(Inline), Op]
        public static ApiMemberExtract extract(in ApiMember src, Span<byte> buffer)
        {
            var address = src.BaseAddress;
            var length = extract(address, buffer);
            var extracted = sys.array(buffer.Slice(0,length));
            return new ApiMemberExtract(src, new CodeBlock(address, extracted));
        }

        [Op]
        static bool parse(in CodeBlock src, in BinaryCode buffer, out CodeBlock dst)
        {
            var parser = patterns(buffer);
            var status = parser.Parse(src);
            var matched = parser.Result;
            var succeeded = matched.IsSome() && status.Success();
            if(succeeded)
            {
                dst = new CodeBlock(src.BaseAddress, parser.Parsed);
                return true;
            }
            else
            {
                dst = CodeBlock.Empty;
                return false;
            }
        }

        [MethodImpl(Inline), Op]
        static int extract(MemoryAddress src, Span<byte> dst)
        {
            var pSrc = src.Pointer<byte>();
            var limit = dst.Length;
            return read(ref pSrc, limit, dst);
        }

        [MethodImpl(Inline), Op]
        static int read(ref byte* pSrc, int count, Span<byte> dst)
            => read(ref pSrc, count, ref first(dst));

        [MethodImpl(Inline), Op]
        static int read(ref byte* pSrc, int limit, ref byte dst)
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