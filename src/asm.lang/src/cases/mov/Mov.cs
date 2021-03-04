//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;
    using static AsmExpr;

    // 7ffa095300e5h 0005h mov rax,1f6d13cb5e4h ; MOV r64, imm64 | REX.W B8+ro io | 48 b8 e4 b5 3c d1 f6 01 00 00
    // 7ffa09530115h 0005h mov rax,1f6d12f2f4ch ; MOV r64, imm64 | REX.W B8+ro io | 48 b8 4c 2f 2f d1 f6 01 00 00

    partial struct AsmCases
    {
        [MethodImpl(Inline), Op]
        public static AsmEncodingCase define(TestCaseId id, AsmExprSet expr, AsmHexCode code)
            => new AsmEncodingCase(id, expr,code);

        [MethodImpl(Inline), Op]
        public static AsmEncodingCase define(TestCaseId id, string oc, string sig, string statement, string encoding)
            => new AsmEncodingCase(id, asm.pack(oc, sig, statement), encoding);

        [MethodImpl(Inline), Op]
        public static AsmEncodingCase define(AsmMnemonicCode monic, ushort seq, string oc, string sig, string statement, string encoding)
            => new AsmEncodingCase(monic, seq, asm.pack(oc, sig, statement), encoding);

        [Op]
        public static Mov mov()
        {
            var dst = new Mov(alloc<AsmEncodingCase>(2));
            var counter = z16;
            var monic = AsmMnemonicCode.MOV;
            dst[0] = define(monic, counter++, "REX.W B8+ro io", "MOV r64, imm64", "mov rax,1f6d13cb5e4h", "48 b8 e4 b5 3c d1 f6 01 00 00");
            dst[1] = define(monic, counter++, "REX.W B8+ro io", "MOV r64, imm64", "mov rax,1f6d12f2f4ch", "48 b8 4c 2f 2f d1 f6 01 00 00");
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