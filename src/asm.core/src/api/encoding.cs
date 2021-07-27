//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct asm
    {
        [Op]
        public static AsmEncodingInfo encoding(in AsmGlobal src)
            => new AsmEncodingInfo((src.OpCode, src.Sig), src.Statement, src.Encoded, AsmBitstrings.bitstring(src.Encoded));

        [Op]
        public static AsmEncodingInfo encoding(in AsmFormExpr form, in AsmExpr statement, in AsmHexCode encoded)
            => new AsmEncodingInfo(form, statement, encoded, AsmBitstrings.bitstring(encoded));

        [MethodImpl(Inline), Op]
        internal static AsmEncodingInfo encoding(in AsmFormExpr form, in AsmExpr statement, in AsmHexCode encoded, in AsmBitstring bitstring)
            => new AsmEncodingInfo(form, statement, encoded, bitstring);
    }
}