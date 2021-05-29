//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using RF = RexFieldIndex;

    partial class AsmEncoder
    {
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