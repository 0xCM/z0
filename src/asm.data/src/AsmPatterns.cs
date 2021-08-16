//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static llvm.MC;

    using Id = llvm.MC.AsmId;

    [LiteralProvider]
    public readonly partial struct AsmPatterns
    {
        [AsmId(Id.AND64ri32)]
        public const string AND64ri32 = "AND(RAX,imm32) = REX.W + 25 id";

        [AsmId(Id.AND8ri)]
        public const string AND8ri = "AND(r8,imm8) = 80 /4 ib";

        public const string AND8ri_Rex = "AND(r/m8,imm8) = REX + 80 /4 ib";

        [AsmId(Id.AND8mi)]
        public const string AND8mi = "AND(m8,imm8) = 80 /4 ib";

        public const string AND8mi_Rex = "AND(m8,imm8) = REX + 80 /4 ib";

        [AsmId(Id.AND16ri)]
        public const string AND16ri = "AND(r16, imm16) = 81 /4 iw";

        [AsmId(Id.AND16mi)]
        public const string AND16mi = "AND(m16,imm16) = 81 /4 iw";

        public const string And7 = "AND(r/m32,imm32) = 81 /4 id";

        public const string And8 = "REX.W + 81 /4 id | AND r/m64, imm32";

        public const string And9 = "83 /4 ib | AND r/m16, imm8";

        public const string And10 = "83 /4 ib | AND r/m32, imm8";

        public const string And11 = "REX.W + 83 /4 ib | AND r/m64, imm8";

        public const string And12 = "20 /r | AND r/m8, r8";

        public const string And13 = "REX + 20 /r | AND r/m8, r8";

        public const string And14 = "21 /r | AND r/m16, r16";

        public const string And15 = "21 /r | AND r/m32, r32";

        public const string And16 = "REX.W + 21 /r | AND r/m64, r64";

        public const string And17 = "22 /r | AND r8, r/m8";

        public const string And18 = "REX + 22 /r | AND r8, r/m8";

        public const string And19 = "23 /r | AND r16, r/m16";

        public const string And20 = "23 /r | AND r32, r/m32";

        public const string And21 = "REX.W + 23 /r | AND r64, r/m64";
    }
}