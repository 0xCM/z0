//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    [ApiHost]
    public readonly partial struct AsmTests
    {
        [Op]
        public static string format(in AsmSizeCheck src)
        {
            const string Pattern = "{0} | Input={1,-16} | Output={2,-16} | Expect={3,-16} | {4}";
            return string.Format(Pattern,
                nameof(AsmSizeCheck), src.Input, src.Expect, src.Actual, src.Passed ? "Pass" : "Fail");
        }

        [Op]
        public static bit check(ref AsmSizeCheck src)
        {
            src.Actual = (ushort)asm.width(src.Input);
            switch(src.Input)
            {
                case AsmSizeKind.@byte:
                    src.Expect = 8;
                break;
                case AsmSizeKind.word:
                    src.Expect = 16;
                break;
                case AsmSizeKind.dword:
                    src.Expect = 32;
                break;
                case AsmSizeKind.qword:
                    src.Expect = 64;
                break;
                case AsmSizeKind.xmmword:
                    src.Expect = 128;
                break;
                case AsmSizeKind.ymmword:
                    src.Expect = 256;
                break;
                case AsmSizeKind.zmmword:
                    src.Expect = 512;
                break;
            }
            return src.Passed;
        }
    }
}