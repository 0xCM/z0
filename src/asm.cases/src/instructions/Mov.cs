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

    // 7ffa095300e5h 0005h mov rax,1f6d13cb5e4h ; MOV r64, imm64 | REX.W B8+ro io | 48 b8 e4 b5 3c d1 f6 01 00 00
    // 7ffa09530115h 0005h mov rax,1f6d12f2f4ch ; MOV r64, imm64 | REX.W B8+ro io | 48 b8 4c 2f 2f d1 f6 01 00 00

    partial class AsmCases
    {
        [MethodImpl(Inline), Op]
        public static AsmEncodingCase define(TestCaseId id, AsmExprSet expr, AsmHexCode code)
            => new AsmEncodingCase(id, expr,code);

        [MethodImpl(Inline), Op]
        public AsmEncodingCase define(AsmMnemonicCode monic, ushort seq, AsmOpCodeExpr oc, AsmSigExpr sig, AsmStatementExpr statement, string encoding)
            => new AsmEncodingCase(monic, seq, asm.pack(oc, sig, statement), encoding);

        [Op]
        public Mov MovCases()
        {
            var dst = new Mov(alloc<AsmEncodingCase>(2));
            var counter = z16;
            var monic = AsmMnemonicCode.MOV;
            dst[0] = define(monic, counter++, asm.opcode("REX.W B8+ro io"), AsmParser.sig("MOV r64, imm64"), asm.statement("mov rax,1f6d13cb5e4h"), "48 b8 e4 b5 3c d1 f6 01 00 00");
            dst[1] = define(monic, counter++, asm.opcode("REX.W B8+ro io"), AsmParser.sig("MOV r64, imm64"), asm.statement("mov rax,1f6d12f2f4ch"), "48 b8 4c 2f 2f d1 f6 01 00 00");
            return dst;
        }

        public readonly struct Mov
        {
            public Index<AsmEncodingCase> Cases {get;}

            [MethodImpl(Inline)]
            public Mov(Index<AsmEncodingCase> src)
            {
                Cases = src;
            }

            public ref AsmEncodingCase this[ushort index]
            {
                [MethodImpl(Inline)]
                get => ref Cases[index];
            }

            public ReadOnlySpan<AsmEncodingCase> View
            {
                [MethodImpl(Inline)]
                get => Cases.View;
            }
        }
    }
}