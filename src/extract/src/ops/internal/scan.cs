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

    partial struct ApiExtracts
    {
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
        internal static bool z7(Span<byte> src, int offset)
            =>      src[offset - 6] == ZED
                && (src[offset - 5] == ZED)
                && (src[offset - 4] == ZED)
                && (src[offset - 3] == ZED)
                && (src[offset - 2] == ZED)
                && (src[offset - 1] == ZED)
                && (src[offset - 0] == ZED);
    }
}