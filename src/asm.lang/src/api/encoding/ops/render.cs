//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmEncoder
    {
        public static void render(ModRm src, ITextBuffer dst)
        {
            const char Open = Chars.LBracket;
            const char Close = Chars.RBracket;
            const char Sep = Chars.Pipe;

            dst.Append(Open);

            dst.Append("Mod");
            dst.Append(Open);
            dst.Append(src.Mod.Format());
            dst.Append(Close);
            dst.Append(Chars.Space);
            dst.Append(Sep);

            dst.Append(Chars.Space);
            dst.Append("Reg");
            dst.Append(Open);
            dst.Append(src.Reg.Format());
            dst.Append(Close);
            dst.Append(Chars.Space);
            dst.Append(Sep);

            dst.Append(Chars.Space);
            dst.Append("Rm");
            dst.Append(Open);
            dst.Append(src.Rm.Format());
            dst.Append(Close);

            dst.Append(Close);
        }
    }
}