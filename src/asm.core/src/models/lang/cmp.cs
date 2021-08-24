//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmMnemonicCode;
    using static AsmOperands;

    partial struct AsmLang
    {
        [Op]
        public AsmExpr cmp(r8 a0, imm8 a1)
            => Produce(S[CMP], S[a0], a1);

        [Op]
        public AsmExpr cmp(r16 a0, imm16 a1)
            => Produce(S[CMP], S[a0], a1);

        [Op]
        public AsmExpr cmp(r32 a0, imm32 a1)
            => Produce(S[CMP], S[a0], a1);

        [Op]
        public AsmExpr cmp(r16 a0, r16 a1)
            => Produce(S[CMP], S[a0], S[a1]);

        [Op]
        public AsmExpr cmp(r32 a0, r32 a1)
            => Produce(S[CMP], S[a0], S[a1]);

        [Op]
        public AsmExpr cmp(r64 a0, r64 a1)
            => Produce(S[CMP], S[a0], S[a1]);
    }

    /*
        | 80 /7 ib         | CMP r/m8, imm8    | MI    | Valid       | Valid           | Compare imm8 with r/m8.
        | 81 /7 iw         | CMP r/m16, imm16  | MI    | Valid       | Valid           | Compare imm16 with r/m16.                          |
        | 81 /7 id         | CMP r/m32, imm32  | MI    | Valid       | Valid           | Compare imm32 with r/m32.                          |
        | 39 / r           | CMP r/m16, r16    | MR    | Valid       | Valid           | Compare r16 with r/m16.                            |
        | 39 / r           | CMP r/m32, r32    | MR    | Valid       | Valid           | Compare r32 with r/m32.                            |
        | REX.W + 39 / r   | CMP r/m64,r64     | MR    | Valid       | N.E.            | Compare r64 with r/m64.                            |


        | MI    | ModRM:r/m (r)     | imm8/16/32    | NA        | NA        |

    */
}