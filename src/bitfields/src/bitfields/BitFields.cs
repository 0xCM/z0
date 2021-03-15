//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Rules;

    [ApiHost]
    public readonly partial struct BitFields
    {
        const NumericKind Closure = UnsignedInts;

        public const char SegmentDelimiter = Chars.Colon;

        public static Fence<char> SegmentFence
        {
            [MethodImpl(Inline)]
            get => Rules.fence(Chars.LBracket, Chars.RBracket);
        }
   }
}