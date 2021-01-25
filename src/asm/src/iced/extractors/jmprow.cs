//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct IceExtractors
    {
        [Op]
        public static ref AsmJmpRow jmprow(in ApiInstruction src, JccKind jk, out AsmJmpRow dst)
        {
            dst.Kind = jk;
            dst.Base = src.Base;
            dst.Source = src.IP;
            dst.InstructionSize = src.Encoded.Size;
            dst.CallSite = dst.Source + dst.InstructionSize;
            dst.Target = branch(src.Base, src.Instruction, 0).Target.Address;
            dst.Asm = src.FormattedInstruction;
            return ref dst;
        }
    }
}