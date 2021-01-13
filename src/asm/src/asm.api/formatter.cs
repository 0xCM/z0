//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static string format(in AsmCallRow src)
            => string.Format(AsmCallRow.RenderPattern, src.Source, src.Target, src.InstructionSize, src.TargetOffset, src.Instruction, src.Encoded);

        [MethodImpl(Inline), Op]
        public static IIceInstructionFormatter formatter(in AsmFormatConfig config)
            => new IceInstructionFormatter(config);
    }
}