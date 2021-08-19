//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmSigs
    {
        [Op]
        public static void decompose(GpRmComposite src, out GpRegToken gp, out MemToken m)
        {
            gp = default;
            m = default;
            switch(src)
            {
                case GpRmComposite.r:
                    gp = GpRegToken.reg;
                break;
                case GpRmComposite.rm8:
                    gp = GpRegToken.r8;
                    m = MemToken.m8;
                break;
                case GpRmComposite.rm16:
                    gp = GpRegToken.r16;
                    m = MemToken.m16;
                break;
                case GpRmComposite.rm32:
                    gp = GpRegToken.r32;
                    m = MemToken.m32;
                break;
                case GpRmComposite.rm64:
                    gp = GpRegToken.r64;
                    m =  MemToken.m64;
                break;
            }
        }
    }
}