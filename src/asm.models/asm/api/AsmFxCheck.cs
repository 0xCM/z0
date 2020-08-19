//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public readonly struct AsmFxCheck
    {
        public static void CheckInstructionSize(in Instruction instruction, int offset, in AsmFxBlock src)
        {
            if(src.Encoded.Length < offset + instruction.ByteLength)
                throw SizeMismatch(instruction, offset, src);
        }

        public static void CheckBlockLength(in AsmFxBlock src)
        {
            var blocklen = src.Decoded.Select(i => i.ByteLength).Sum();
            if(blocklen != src.Encoded.Length)
                throw BadBlockLength(src,blocklen);
        }

        static AppException BadBlockLength(in AsmFxBlock src, int computedLength)
            => AppException.Define(InstructionBlockSizeMismatch(src.BaseAddress, src.Encoded.Length, computedLength));

        static AppException SizeMismatch(in Instruction instruction, int offset, in AsmFxBlock src)
            => AppException.Define(InstructionSizeMismatch(instruction.IP, offset, src.Encoded.Length, instruction.ByteLength));

        static AppMsg InstructionSizeMismatch(MemoryAddress ip, int offset, int actual, int reported,
            [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                => AppMsg.Error(text.concat(
                    $"The encoded instruction length does not match the reported instruction length:", 
                    $"address = {ip}, datalen = {reported}, offset = {offset}, bytelen = {reported}"),
                        caller, file, line);
                        
        static AppMsg InstructionBlockSizeMismatch(MemoryAddress @base, int actual, int reported,
            [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                => AppMsg.Error(text.concat(
                    $"The encoded instruction block length does not match the reported total instruction length:", 
                    $"@base = {@base}, block length = {reported}, reported length = {reported}"),
                        caller, file, line);
    }
}