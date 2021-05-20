//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    using Iced = Iced.Intel;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    readonly struct AsmDecoderApi
    {
        public static AsmRoutine routine(ApiMemberCode member, AsmInstructionBlock asm)
        {
            var code = new ApiCodeBlock(member.OpUri, member.Encoded);
            return new AsmRoutine(member.OpUri, member.Method.Artifact().DisplaySig, code, member.TermCode, AsmEtl.ToApiInstructions(code, asm));
        }

        public static AsmRoutine routine(OpUri uri, MethodDisplaySig sig, ApiBlockAsm src, bool check = false)
        {
            var count = src.InstructionCount;
            var info = new AsmInstructionInfo[count];
            var offset = 0u;
            var @base = src.BaseAddress;

            for(var i=0; i<count; i++)
            {
                var instruction = src[i];
                if(check)
                    CheckInstructionSize(instruction, offset, src);
                info[i] = IceExtractors.summarize(@base, instruction, src.Encoded.Code, instruction.FormattedInstruction, offset);
                offset += (uint)instruction.ByteLength;
            }

            if(check)
                CheckBlockLength(src);

            return new AsmRoutine(uri, sig, src.Encoded, src.TermCode, AsmEtl.ToApiInstructions(src.Encoded, src.Decoded));
        }

        [MethodImpl(Inline), Op]
        public static IceInstructionList icelist(IceInstruction[] src, CodeBlock data)
            => new IceInstructionList(src, data);

        [MethodImpl(Inline), Op]
        public static IIceInstructionFormatter iformatter(in AsmFormatConfig config)
            => new IceInstructionFormatter(config);

        static void CheckInstructionSize(in IceInstruction instruction, uint offset, in ApiBlockAsm src)
        {
            if(src.Encoded.Length < offset + instruction.ByteLength)
                throw SizeMismatch(instruction, offset, src);
        }

        static void CheckBlockLength(in ApiBlockAsm src)
        {
            var blocklen = (uint)src.Decoded.Select(i => i.ByteLength).Sum();
            if(blocklen != src.Encoded.Length)
                throw BadBlockLength(src,blocklen);
        }

        static AppException BadBlockLength(in ApiBlockAsm src, uint computedLength)
            => new AppException(InstructionBlockSizeMismatch(src.BaseAddress, src.Encoded.Length, computedLength));

        static AppException SizeMismatch(in IceInstruction instruction, uint offset, in ApiBlockAsm src)
            => new AppException(InstructionSizeMismatch(instruction.IP, offset, (uint)src.Encoded.Length, (uint)instruction.ByteLength));

        static AppMsg InstructionSizeMismatch(MemoryAddress ip, uint offset, uint actual, uint reported,
            [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                => AppMsg.error(text.concat(
                    $"The encoded instruction length does not match the reported instruction length:",
                    $"address = {ip}, datalen = {reported}, offset = {offset}, bytelen = {reported}"),
                        caller, file, line);

        static AppMsg InstructionBlockSizeMismatch(MemoryAddress @base, int actual, uint reported,
            [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                => AppMsg.error(text.concat(
                    $"The encoded instruction block length does not match the reported total instruction length:",
                    $"@base = {@base}, block length = {reported}, reported length = {reported}"),
                        caller, file, line);
    }
}