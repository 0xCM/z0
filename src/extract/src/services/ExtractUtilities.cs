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
        [MethodImpl(Inline), Op]
        public static bool Finished(this BytePatternParserState state)
            => (state & BytePatternParserState.Completed) != 0;

        [MethodImpl(Inline), Op]
        public static bool HasFailed(this BytePatternParserState state)
            => state == BytePatternParserState.Failed;

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