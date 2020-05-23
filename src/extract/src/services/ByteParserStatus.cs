//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public static class ByteParserStatus
    {
        [MethodImpl(Inline)]
        public static bool Finished(this ByteParserState state)
            => (state & ByteParserState.Completed) != 0;

        [MethodImpl(Inline)]
        public static bool IsAccepting(this ByteParserState state)
            => state == ByteParserState.Accepting;

        [MethodImpl(Inline)]
        public static bool IsSome(this ByteParserState state)
            => state != 0;

        [MethodImpl(Inline)]
        public static bool Success(this ByteParserState state)
            => state == ByteParserState.Succeeded;

        [MethodImpl(Inline)]
        public static bool IsSome(this EncodingPatternKind code)
            => code != 0;

        [MethodImpl(Inline)]
        public static bool IsPartial(this EncodingPatternKind code)
            => (uint)code >= 2*16;

        [MethodImpl(Inline)]
        public static ExtractTermCode ToTermCode(this EncodingPatternKind src)
            => (ExtractTermCode)src;
    }    
}