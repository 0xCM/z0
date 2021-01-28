//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmEtl
    {
        [MethodImpl(Inline), Op]
        public static AsmEncoding encoding(AsmSpecifier specifier, AsmStatement statement, BinaryCode encoded)
            => new AsmEncoding(statement, specifier, encoded);

        [MethodImpl(Inline), Op]
        public static AsmEncoding encoding(in AsmRow src)
            => encoding(asm.specifier(src.OpCode, src.Instruction), src.Statement, src.Encoded);
    }
}