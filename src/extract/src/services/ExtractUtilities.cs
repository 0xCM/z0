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
    public static class ExtractUtilities
    {
        [Op]
        public static int ExtractLength(this Span<byte> src, int maxcut, byte code)
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


        [MethodImpl(Inline), Op]
        public static bool Finished(this BytePatternParserState state)
            => (state & BytePatternParserState.Completed) != 0;

        [MethodImpl(Inline), Op]
        public static bool IsAccepting(this BytePatternParserState state)
            => state == BytePatternParserState.Accepting;

        [MethodImpl(Inline), Op]
        public static bool HasFailed(this BytePatternParserState state)
            => state == BytePatternParserState.Failed;

        [MethodImpl(Inline), Op]
        public static bool IsSome(this BytePatternParserState state)
            => state != 0;

        [MethodImpl(Inline), Op]
        public static bool Success(this BytePatternParserState state)
            => state == BytePatternParserState.Succeeded;

        [MethodImpl(Inline), Op]
        public static bool IsSome(this EncodingPatternKind code)
            => code != 0;

        [MethodImpl(Inline), Op]
        public static bool IsPartial(this EncodingPatternKind code)
            => (uint)code >= 2*16;

        [MethodImpl(Inline), Op]
        public static ExtractTermCode ToTermCode(this EncodingPatternKind src)
        {
            if(src != 0)
                return (ExtractTermCode)src;
            else
                return ExtractTermCode.Fail;
        }
    }
}