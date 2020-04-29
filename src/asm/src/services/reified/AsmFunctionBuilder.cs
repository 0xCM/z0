//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static AsmFunctionChecks;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public readonly struct AsmFunctionBuilder : IAsmFunctionBuilder
    {        
        public static IAsmFunctionBuilder Service => default(AsmFunctionBuilder);
        
        public bool RunChecks {get;}

        public AsmFunction BuildFunction(OpUri uri, string sig, AsmInstructionBlock src)
        {
            var info = new AsmInstructionInfo[src.InstructionCount];
            var offset = (ushort)0;

            for(var i=0; i<info.Length; i++)
            {
                var instruction = src[i];                
                if(RunChecks)
                    CheckInstructionSize(instruction, offset, src);

                info[i] = AsmInstruction.describe(instruction,src.NativeCode.Encoded, instruction.FormattedInstruction, offset, src.Origin.Start);
                offset += (ushort)instruction.ByteLength;
            }

            if(RunChecks)
                CheckBlockLength(src);

            //var parsed = ParsedMember.Define(uri,sig, src.TermCode, src.NativeCode.Encoded);
            
            var instructions = AsmInstructionList.Create(src.Decoded, src.NativeCode.Encoded);

            var function = AsmFunction.Define(uri, sig, src.NativeCode, src.TermCode, instructions);
            return function;
            //return AsmFunction.Define(parsed, instructions);
        }
    }

    static class AsmFunctionChecks
    {
        [MethodImpl(Inline)]
        public static void CheckInstructionSize(in Instruction instruction, int offset, in AsmInstructionBlock src)
        {
            if(src.NativeCode.Length < offset + instruction.ByteLength)
                throw SizeMismatch(instruction, offset, src);
        }

        [MethodImpl(Inline)]
        public static void CheckBlockLength(in AsmInstructionBlock src)
        {
            var blocklen = src.Decoded.Select(i => i.ByteLength).Sum();
            if(blocklen != src.NativeCode.Length)
                throw BadBlockLength(src,blocklen);
        }

        static AppException BadBlockLength(in AsmInstructionBlock src, int computedLength)
            => AppException.Define(InstructionBlockSizeMismatch(src.Origin, src.NativeCode.Length, computedLength));

        static AppException SizeMismatch(in Instruction instruction, int offset, in AsmInstructionBlock src)
            => AppException.Define(InstructionSizeMismatch(instruction.IP, offset, src.NativeCode.Length, instruction.ByteLength));

        static AppMsg InstructionSizeMismatch(MemoryAddress location, int offset, int actual, int reported,
            [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                => AppMsg.Error(text.concat(
                    $"The encoded instruction length does not match the reported instruction length:", 
                    $"address = {location}, datalen = {reported}, offset = {offset}, bytelen = {reported}"),
                        caller, file, line);
                        
        static AppMsg InstructionBlockSizeMismatch(MemoryRange origin, int actual, int reported,
            [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                => AppMsg.Error(text.concat(
                    $"The encoded instruction block length does not match the reported total instruction length:", 
                    $"origin = {origin}, block length = {reported}, reported length = {reported}"),
                        caller, file, line);
    }
}