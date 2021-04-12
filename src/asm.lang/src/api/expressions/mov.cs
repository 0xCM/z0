//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmMnemonicCode;

    partial struct AsmX
    {
        [Op, AsmSig(AsmSigKind.mov_r64_imm64)]
        public AsmExpr mov(Gp64 a0, Imm64 a1)
            => Produce(S[MOV], S[a0], a1);


/*
neg r8/m                                      | ANY  | F6 /3                         | M        |        | F6         |     |     |      |      | false | 3    |       |         | -1       | false | false |
neg r16/m                                     | ANY  | 66 F7 /3                      | M        |        | F7         |     |     | 66   |      | false | 3    |       |         | -1       | false | false |
neg r32/m                                     | ANY  | F7 /3                         | M        |        | F7         |     |     |      |      | false | 3    |       |         | -1       | false | false |
neg r64/m                                     | X64  | REX.W F7 /3                   | M        |        | F7         |     | W1  |      |      | false | 3    |       |         | -1       | false | false |

*/
    }
}