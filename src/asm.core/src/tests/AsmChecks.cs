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
            src.Actual = (ushort)Sizes.width(src.Input);
            switch(src.Input.Code)
            {
                case NativeSizeCode.W8:
                    src.Expect = 8;
                break;
                case NativeSizeCode.W16:
                    src.Expect = 16;
                break;
                case NativeSizeCode.W32:
                    src.Expect = 32;
                break;
                case NativeSizeCode.W64:
                    src.Expect = 64;
                break;
                case NativeSizeCode.W128:
                    src.Expect = 128;
                break;
                case NativeSizeCode.W256:
                    src.Expect = 256;
                break;
                case NativeSizeCode.W512:
                    src.Expect = 512;
                break;
            }
            return src.Passed;
        }
    }
}