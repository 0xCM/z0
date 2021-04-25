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
    using static ExtractTermCode;

    using EP = EncodingParser;

    [ApiHost]
    public readonly struct ApiExtracts
    {
        const int DefaultBufferLength = Pow2.T14 + Pow2.T08;

        const int MaxZeroCount = 10;

        const byte ZED = 0;

        const byte RET = 0xc3;

        const byte INTR = 0xcc;

        const byte SBB = 0x19;

        const byte FF = 0xff;

        const byte E0 = 0xe0;

        const byte J48 = 0x48;

        [Op]
        public static unsafe ApiCaptureResult capture(OpIdentity id, MemoryAddress src, Span<byte> dst)
            => divine(dst, id, src.Pointer<byte>());

        public static ApiMemberExtractor extractor()
            => new ApiMemberExtractor(DefaultBufferLength);

        [MethodImpl(Inline), Op]
        public static PatternExtractParser parser()
            => new PatternExtractParser(sys.alloc<byte>(DefaultBufferLength));

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

        [Op]
        public static unsafe ApiCaptureResult divine(Span<byte> dst, OpIdentity id, byte* pSrc)
        {
            var limit = dst.Length - 1;
            var start = (long)pSrc;
            var offset = 0;
            int? ret_offset = null;
            var end = (long)pSrc;
            var state = default(byte);

            while(offset < limit)
            {
                state = step(dst, id, ref offset, ref end, ref pSrc);
                if(ret_offset == null && state == RET)
                    ret_offset = offset;
                var tc = term(dst, offset, ret_offset, out var delta);
                if(tc != null)
                    return summarize(dst, id, tc.Value, start, end, delta);
            }
            return summarize(dst, id, CTC_BUFFER_OUT, start, end, 0);
        }

        [MethodImpl(Inline), Op]
        internal static EP encodings(byte[] buffer)
            => new EP(EncodingPatterns.Default, buffer);

        [MethodImpl(Inline), Op]
        internal static unsafe int extract(MemoryAddress src, Span<byte> dst)
        {
            var pSrc = src.Pointer<byte>();
            var limit = dst.Length;
            return read(ref pSrc, limit, dst);
        }

        [MethodImpl(Inline), Op]
        internal static unsafe int read(ref byte* pSrc, int count, Span<byte> dst)
            => read(ref pSrc, count, ref first(dst));

        [MethodImpl(Inline), Op]
        internal static unsafe int read(ref byte* pSrc, int limit, ref byte dst)
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

        [Op]
        internal static int extractSize(Span<byte> src, int maxcut, byte code)
        {
            var srcLen = src.Length;
            var cut = 0;
            if(srcLen > maxcut)
            {
                var start = srcLen - maxcut - 1;
                ref readonly var lead = ref skip(src, maxcut);
                ref readonly var current = ref lead;
                for(var i=start; i<srcLen && cut < maxcut; i++, cut++)
                {
                    current = ref skip(lead, i);
                    if(current == code)
                        break;
                }
            }
            var dstLen = src.Length - cut;
            return dstLen <= 0 ? src.Length : dstLen;
        }

        [Op]
        internal static CodeBlock locate(MemoryAddress address, byte[] src, int cut)
        {
            if(cut == 0)
                return new CodeBlock(address, src);
            else
            {
                Span<byte> data = src;
                var len = extractSize(data, cut, 0xC3);
                var keep = data.Slice(0, len);
                return new CodeBlock(address, keep.ToArray());
            }
        }

        [MethodImpl(Inline), Op]
        internal static ExtractTermCode termcode(EncodingPatternKind src)
        {
            if(src != 0)
                return (ExtractTermCode)src;
            else
                return ExtractTermCode.Fail;
        }

        [MethodImpl(Inline), Op]
        internal static bool failure(EncodingParserState state)
            => state == EncodingParserState.Failed;

        [Op]
        internal static Outcome<ApiMemberCode> parse(EP parser, in ApiMemberExtract src, uint seq)
        {
            const int Zx7Cut = 7;

            try
            {
                var status = parser.Parse(src.Block.Encoded.View);
                var term = failure(status) ? ExtractTermCode.Fail : termcode(parser.Result);
                if(term != ExtractTermCode.Fail)
                {
                    var code = locate(src.Block.BaseAddress, parser.Parsed, term == ExtractTermCode.CTC_Zx7 ? Zx7Cut : 0);
                    return new ApiMemberCode(src.Member, new ApiCodeBlock(code.BaseAddress, src.OpUri, code), seq, term);
                }
                else
                    return Outcomes.fail<ApiMemberCode>(term.ToString());
            }
            catch(Exception e)
            {
                return e;
            }
        }

        [Op]
        internal static Index<ApiMemberCode> parse(EP parser, ReadOnlySpan<ApiMemberExtract> src)
        {
            var count = src.Length;
            if(count == 0)
                return default;

            var buffer = alloc<ApiMemberCode>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
            {
                var outcome = parse(parser, skip(src,i), i);
                if(outcome)
                    seek(dst, i) = outcome.Data;
                else
                    seek(dst, i) = ApiMemberCode.Empty;
            }
            return buffer;
        }

        [Op, MethodImpl(Inline)]
        internal static unsafe byte step(Span<byte> dst, OpIdentity id, ref int offset, ref long location, ref byte* pSrc)
        {
            var code = Unsafe.Read<byte>(pSrc++);
            dst[offset++] = code;
            location = (long)pSrc;
            return code;
        }

        [Op, MethodImpl(Inline)]
        internal static CaptureOutcome complete(ExtractTermCode tc, long start, long end, int delta)
            => new CaptureOutcome(((ulong)start, (ulong)(end + delta)), tc);

        [Op, MethodImpl(Inline)]
        internal static ApiCaptureResult summarize(Span<byte> src, OpIdentity id, ExtractTermCode tc, long start, long end, int delta)
        {
            var outcome = complete(tc, start, end, delta);
            var raw = src.Slice(0, (int)(end - start)).ToArray();
            var trimmed = src.Slice(0, outcome.ByteCount).ToArray();
            var bits = CodeBlocks.pair((MemoryAddress)start, raw, trimmed);
            return CodeBlocks.result(id, outcome, bits);
        }

        [Op]
        internal static ExtractTermCode? term(Span<byte> src, int offset, int? ret_offset, out int delta)
        {
            delta = 0;

            if(offset >= 4)
            {
                var tc = scan4(src, offset, out delta);
                if(tc != null)
                    return tc;
            }

            if(offset >= 5)
            {
                var tc = scan5(src, offset, out delta);
                if(tc != null)
                    return tc;
            }

            if(offset >= 7 && Zx7(src, offset))
            {
                if(ret_offset == null)
                {
                    delta = -6;
                    return CTC_Zx7;
                }
                delta = -(offset - ret_offset.Value);
                return CTC_RET_Zx7;
            }

            return null;
        }

        [Op, MethodImpl(Inline)]
        internal static ExtractTermCode? scan4(Span<byte> src, int offset, out int delta)
        {
            var x0 = src[offset - 3];
            var x1 = src[offset - 2];
            var x2 = src[offset - 1];
            var x3 = src[offset - 0];
            delta = -2;

            if(match((x0,RET), (x1, SBB)))
                return CTC_RET_SBB;
            else if(match((x0, RET), (x1, INTR)))
                return CTC_RET_INTR;
            else if(match((x0, RET), (x1, ZED), (x2,SBB)))
                return CTC_RET_ZED_SBB;
            else if(match((x0, RET), (x1, ZED), (x2,ZED)))
                return CTC_RET_Zx3;
            else if(match((x0,INTR), (x1, INTR)))
                return CTC_INTRx2;
            else
                return null;
        }

        [Op, MethodImpl(Inline)]
        internal static ExtractTermCode? scan5(Span<byte> src, int offset, out int delta)
        {
            var x0 = src[offset - 5];
            var x1 = src[offset - 4];
            var x2 = src[offset - 3];
            var x3 = src[offset - 2];
            var x4 = src[offset - 1];
            delta = 0;

            if(match((x0,ZED), (x1,ZED), (x2,J48), (x3,FF), (x4,E0)))
                return CTC_JMP_RAX;
            else
                return null;
        }

        [Op, MethodImpl(Inline)]
        internal static bool Zx7(Span<byte> src, int offset)
            =>      src[offset - 6] == ZED
                && (src[offset - 5] == ZED)
                && (src[offset - 4] == ZED)
                && (src[offset - 3] == ZED)
                && (src[offset - 2] == ZED)
                && (src[offset - 1] == ZED)
                && (src[offset - 0] == ZED);

        [Op, MethodImpl(Inline)]
        internal static bit match((byte x, byte y) a, (byte x, byte y) b)
            => a.x == a.y
            && b.x == b.y;

        [Op, MethodImpl(Inline)]
        internal static bit match((byte x, byte y) a, (byte x, byte y) b, (byte x, byte y) c)
            => a.x == a.y
            && b.x == b.y
            && c.x == c.y;

        [Op, MethodImpl(Inline)]
        internal static bit match((byte x, byte y) a, (byte x, byte y) b, (byte x, byte y) c, (byte x, byte y) d, (byte x, byte y) e)
            => a.x == a.y
            && b.x == b.y
            && c.x == c.y
            && d.x == d.y
            && e.x == e.y;
    }
}