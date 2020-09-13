//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static Asm.AsmFxCheck;

    public readonly struct AsmApi
    {
        [MethodImpl(Inline), Op]
        public static AsmRoutine routine(X86MemberRefinement encoding, AsmFxList src)
        {
            var code = new X86ApiCode(encoding.OpUri, encoding.Encoded);
            var sig = encoding.Method.Signature().Format();
            return new AsmRoutine(encoding.OpUri, sig, code, encoding.TermCode, src);
        }

        [MethodImpl(Inline), Op]
        public static AsmRoutine routine(X86ApiMember member, AsmInstructions asm)
        {
            var code = new X86ApiCode(member.OpUri, member.Encoded);
            var sig = member.Method.Signature().Format();
            return new AsmRoutine(member.OpUri, sig, code, member.TermCode, new AsmFxList(asm, member.Encoded));
        }

        [Op]
        public static AsmRoutine routine(OpUri uri, string sig, AsmFxBlock src, bool check = false)
        {
            var info = new AsmFxSummary[src.InstructionCount];
            var offset = (ushort)0;
            var @base = src.BaseAddress;

            for(var i=0; i<info.Length; i++)
            {
                var instruction = src[i];
                if(check)
                    CheckInstructionSize(instruction, offset, src);
                info[i] = asm.summarize(@base, instruction, src.Encoded.Encoded, instruction.FormattedInstruction, offset);
                offset += (ushort)instruction.ByteLength;
            }

            if(check)
                CheckBlockLength(src);

            var instructions = asm.list(src.Decoded, src.Encoded.Encoded);
            return new AsmRoutine(uri, sig, src.Encoded, src.TermCode, instructions);
        }
    }
}