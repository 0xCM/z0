//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using RF = RexFieldIndex;

    partial struct AsmEncoder
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

        [Op]
        public static string describe(RexPrefix src)
            => $"{src.Format()} | {src.FormatBits()} | {RF.W}:{src.W} | {RF.R}:{src.R} | {RF.X}:{src.X} | {RF.B}:{src.B}";

        public static string describe(Vsib src)
        {
            var buffer = text.buffer();
            buffer.Append("[ ");
            buffer.Append(src.SS.ToString());
            buffer.Append(" | ");
            buffer.Append(src.Index.ToString());
            buffer.Append(" | ");
            buffer.Append(src.Base.ToString());
            buffer.Append(" ]");
            return buffer.Emit();
        }
    }
}