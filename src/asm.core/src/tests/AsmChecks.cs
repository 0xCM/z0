//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [ApiHost]
    public readonly partial struct AsmChecks
    {
        [Op]
        public static bit check(ref AsmSizeCheck src)
        {
            src.Actual = (ushort)asm.width(src.Input);
            switch(src.Input)
            {
                case AsmSizeClass.@byte:
                    src.Expect = 8;
                break;
                case AsmSizeClass.word:
                    src.Expect = 16;
                break;
                case AsmSizeClass.dword:
                    src.Expect = 32;
                break;
                case AsmSizeClass.qword:
                    src.Expect = 64;
                break;
                case AsmSizeClass.xmmword:
                    src.Expect = 128;
                break;
                case AsmSizeClass.ymmword:
                    src.Expect = 256;
                break;
                case AsmSizeClass.zmmword:
                    src.Expect = 512;
                break;
            }
            return src.Passed;
        }
    }
}