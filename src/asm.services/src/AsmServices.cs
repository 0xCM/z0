//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static AsmFxCheck;

    public readonly struct AsmServices : IAsmServices
    {
        public static IAsmServices Services => default(AsmServices);

        [MethodImpl(Inline), Op]
        public static AsmRoutine routine(X86ApiCapture captured, AsmFxList src)
        {
            var code = new X86ApiCode(captured.OpUri, captured.Encoded);
            var sig = captured.Method.Signature().Format();
            return new AsmRoutine(captured.OpUri, sig, code, captured.TermCode, src);
        }

        [MethodImpl(Inline), Op]
        public static AsmRoutine routine(X86ApiMember member, AsmInstructions asm)
        {
            var code = new X86ApiCode(member.OpUri, member.Encoded);
            var sig = member.Method.Signature().Format();
            return new AsmRoutine(member.OpUri, sig, code, member.TermCode, new AsmFxList(asm, member.Encoded));
        }

        [Op]
        public static AsmRoutine routine(OpUri uri, string sig, AsmBlock src, bool check = false)
        {
            var count = src.InstructionCount;
            var info = new AsmFxSummary[count];
            var offset = 0u;
            var @base = src.BaseAddress;

            for(var i=0; i<count; i++)
            {
                var instruction = src[i];
                if(check)
                    CheckInstructionSize(instruction, offset, src);
                info[i] = asm.summarize(@base, instruction, src.Encoded.Encoded, instruction.FormattedInstruction, offset);
                offset += (uint)instruction.ByteLength;
            }

            if(check)
                CheckBlockLength(src);

            var instructions = asm.list(src.Decoded, src.Encoded.Encoded);
            return new AsmRoutine(uri, sig, src.Encoded, src.TermCode, instructions);
        }
    }
}