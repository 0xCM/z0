//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static RexPrefixFacets;
    using static AsmSigTokens;
    using static AsmInstructions;

    [ApiHost]
    public readonly partial struct AsmQuery
    {
        public static bit test(AsmHexCode src, Jmp jmp, Rel8 rel8)
        {

            return false;

        }

        public static bit test(AsmHexCode src, Jmp jmp, Rel32 rel8)
        {

            return false;

        }


        [MethodImpl(Inline), Op]
        public static bit IsRexPrefix(byte src)
            => emath.between(src, MinRex, MaxRex);

        [MethodImpl(Inline), Op]
        public static bool IsCallRel32(ReadOnlySpan<byte> src, uint offset)
            => skip(src,offset) == 0xE8 && (offset + 4) <= src.Length;

    }
}