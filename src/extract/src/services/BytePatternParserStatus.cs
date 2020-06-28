//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public static class BytePatternParserStatus
    {
        [MethodImpl(Inline)]
        public static bool Finished(this BytePatternParserState state)
            => (state & BytePatternParserState.Completed) != 0;

        [MethodImpl(Inline)]
        public static bool IsAccepting(this BytePatternParserState state)
            => state == BytePatternParserState.Accepting;

        [MethodImpl(Inline)]
        public static bool HasFailed(this BytePatternParserState state)
            => state == BytePatternParserState.Failed;

        [MethodImpl(Inline)]
        public static bool IsSome(this BytePatternParserState state)
            => state != 0;

        [MethodImpl(Inline)]
        public static bool Success(this BytePatternParserState state)
            => state == BytePatternParserState.Succeeded;

        [MethodImpl(Inline)]
        public static bool IsSome(this EncodingPatternKind code)
            => code != 0;

        [MethodImpl(Inline)]
        public static bool IsPartial(this EncodingPatternKind code)
            => (uint)code >= 2*16;

        [MethodImpl(Inline)]
        public static ExtractTermCode ToTermCode(this EncodingPatternKind src)
        {
            if(src != 0)
                return (ExtractTermCode)src;
            else
                return ExtractTermCode.Fail;
        }
    }    
}