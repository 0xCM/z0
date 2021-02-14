//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static TextRules.Format;

    [ApiHost]
    public readonly partial struct AsmInstructions
    {

        // [Op]
        // public static void render(in CallRel32 src, ITextBuffer dst)
        // {
        //     dst.AppendPropLine(property(nameof(src.Target), src.Target.Format()));
        //     dst.AppendPropLine(property(nameof(src.Ip), src.Ip.Format()));
        //     dst.AppendPropLine(property(nameof(src.InstructionSize), src.InstructionSize.Format()));
        //     dst.AppendPropLine(property(nameof(src.NextIp), src.NextIp.Format()));
        //     dst.AppendPropLine(property(nameof(src.Displacement), src.Displacement.FormatHex()));
        // }
    }
}