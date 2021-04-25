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
    }
}
