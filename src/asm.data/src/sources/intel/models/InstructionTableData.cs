//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public readonly partial struct IntelSdm
    {
        public ref struct InstructionTableData
        {
            public ReadOnlySpan<byte> OpCode;

            public ReadOnlySpan<byte> Sig;

            public ReadOnlySpan<byte> Encoding;

            public ReadOnlySpan<byte> Mode64;

            public ReadOnlySpan<byte> LegacyMode;

            public ReadOnlySpan<byte> Description;
        }

        public const string And0 = "24 ib | AND AL, imm8 | (AL/AX/EAX/RAX, imm8/16/32)";

        public const string And1 = "25 iw | AND AX, imm16 | (AL/AX/EAX/RAX, imm8/16/32)";

        public const string And2 = "25 id | AND EAX, imm32 | (AL/AX/EAX/RAX, imm8/16/32)";

        public const string And3 = "REX.W + 25 id | AND RAX, imm32 | (AL/AX/EAX/RAX, imm8/16/32)";

        public const string And4 = "80 /4 ib | AND r/m8, imm8 | (ModRM:r/m (r, w), imm8/16/32)";

        public const string And5 = "REX + 80 /4 ib | AND r/m8, imm8 | (ModRM:r/m (r, w), imm8/16/32)";

        public const string And6 = "81 /4 iw | AND r/m16, imm16 | (ModRM:r/m (r, w), imm8/16/32)";

        public const string And7 = "81 /4 id | AND r/m32, imm32 | (ModRM:r/m (r, w), imm8/16/32)";

        public const string And8 = "REX.W + 81 /4 id | AND r/m64, imm32 | (ModRM:r/m (r, w), imm8/16/32)";

        public const string And9 = "83 /4 ib | AND r/m16, imm8 | (ModRM:r/m (r, w), imm8/16/32)";

        public const string And10 = "83 /4 ib | AND r/m32, imm8 | (ModRM:r/m (r, w), imm8/16/32)";

        public const string And11 = "REX.W + 83 /4 ib | AND r/m64, imm8 | (ModRM:r/m (r, w), imm8/16/32)";

        public const string And12 = "20 /r | AND r/m8, r8 | (ModRM:r/m (r, w),ModRM:reg (r)) ";

        public const string And13 = "REX + 20 /r | AND r/m8, r8 | (ModRM:r/m (r, w),ModRM:reg (r))";

        public const string And14 = "21 /r | AND r/m16, r16 | (ModRM:r/m (r, w),ModRM:reg (r))";

        public const string And15 = "21 /r | AND r/m32, r32 | (ModRM:r/m (r, w),ModRM:reg (r))";

        public const string And16 = "REX.W + 21 /r | AND r/m64, r64 | (ModRM:r/m (r, w),ModRM:reg (r))";

        public const string And17 = "22 /r | AND r8, r/m8 | (ModRM:reg (r, w), ModRM:r/m (r))";

        public const string And18 = "REX + 22 /r | AND r8, r/m8 | (ModRM:reg (r, w), ModRM:r/m (r))";

        public const string And19 = "23 /r | AND r16, r/m16 | (ModRM:reg (r, w), ModRM:r/m (r))";

        public const string And20 = "23 /r | AND r32, r/m32 | (ModRM:reg (r, w), ModRM:r/m (r))";

        public const string And21 = "REX.W + 23 /r | AND r64, r/m64 | (ModRM:reg (r, w), ModRM:r/m (r))";

    }
}