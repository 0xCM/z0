//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

	using Iced.Intel;
    
    using AsmOpKind = Iced.Intel.OpKind;
    
    using static Iced.Intel.OpKind;
    using static zfunc;
    
    public static class AsmFunctions
    {        
        public static AsmFunction define(NativeMemberCapture src)
            => AsmDecoder.function(src);
        // {            
        //     var instructions = AsmDecoder.block(src);
        //     var count = instructions.InstructionCount;
        //     var format = instructions.FormatInstructionLines(AsmFormatConfig.Default.Invert());            
        //     var dst = new AsmInstructionInfo[count];
        //     var offset = (ushort)0;
        //     var root = src.Location.Start;

        //     for(var i=0; i<count; i++)
        //     {
        //         dst[i] = instructions[i].SummarizeInstruction(src.Code, format[i], offset, root);
        //         offset += (ushort)instructions[i].ByteLength;
        //     }
            
        //     require(src.Code.Encoded.Length == instructions.Decoded.Select(i => i.ByteLength).Sum());

        //     return AsmFunction.Define(src.Location, src.Code, src.CaptureInfo.TermReason, dst);            
        // }

        public static IEnumerable<AsmFunction> define(IEnumerable<MethodDisassembly> src)
            => src.Select(define);

        public static AsmFunction define(InstructionBlock src, CilFunction cil = null)
        {
            var count = src.InstructionCount;
            var location = src.Location;
            var format = src.FormatInstructions(AsmFormatConfig.Default.Invert());            
            var dst = new AsmInstructionInfo[count];
            var offset = (ushort)0;
            var root = location.Start;            

            for(var i=0; i<count; i++)
            {
                dst[i] = src[i].SummarizeInstruction(src.Code, format[i], offset, root);
                offset += (ushort)src[i].ByteLength;
            }

            require(src.Encoded.Length == src.Decoded.Select(i => i.ByteLength).Sum());

            return AsmFunction.Define(location, src.Code, CaptureTermReason.None, dst, cil);
        }

        public static AsmFunction define(MethodDisassembly src)
        {
            var offset = (ushort)0;
            var body = src.AsmBody;
            var instructions = src.Instructions;
            var descriptions = new AsmInstructionInfo[instructions.InstructionCount];
            var content = instructions.FormatInstructions(AsmFormatConfig.Default.Invert());
            var root = src.AsmBody.Location.Start;     

            for(var i=0; i<descriptions.Length; i++)
            {
                descriptions[i] = instructions[i].SummarizeInstruction(src.AsmCode, content[i], offset, root);
                offset += (ushort)instructions[i].ByteLength;
            }

            require(src.AsmCode.Length == instructions.Decoded.Select(i => i.ByteLength).Sum());            
            
            return AsmFunction.Define(body.Location, 
                AsmCode.Define(src.Id, src.Method.Signature().Format(),body.NativeBlock.Data), CaptureTermReason.None, descriptions);            
        }

        static AsmInstructionSpec InstructionSpec(this Instruction src)
        {
            var opcode = src.Code.ToOpCode();
            return AsmInstructionSpec.Define(opcode.ToInstructionString(), opcode.ToOpCodeString());
        }

        static AsmInstructionInfo SummarizeInstruction(this Instruction src, AsmCode code, string content, ushort offset, ulong baseaddress)
        {            
            if(code.Encoded.Length < offset + src.ByteLength)
                throw new ArgumentException($"ip = {src.IP.FormatHex()}, datalen = {code.Encoded.Length}, offset = {offset}, bytelen = {src.ByteLength}");

            Span<byte> data = code.Encoded;
            return AsmInstructionInfo.Define((ushort)offset, 
                content, 
                src.InstructionSpec(), 
                src.SummarizeOperands(baseaddress), 
                data.Slice(offset, src.ByteLength).ToArray());
        }

        /// <summary>
        /// Extracts operand information from an instruction
        /// </summary>
        /// <param name="src">The source instruction</param>
        static AsmOperandInfo[] SummarizeOperands(this Instruction src, ulong baseaddress)
        {
            var args = new AsmOperandInfo[src.OpCount];
            for(byte j=0; j< src.OpCount; j++)
                args[j] = src.OperandInfo(j,baseaddress);
            return args;
        }

        static AsmOperandInfo OperandInfo(this Instruction src, int index, ulong baseaddress)
            => AsmOperandInfo.Define(index, 
                src.GetOpKind(index).ToString(),
                src.ImmediateInfo(index).ValueOrDefault(), 
                src.MemoryInfo(index).ValueOrDefault(), 
                src.RegisterInfo(index).ValueOrDefault(), 
                src.BranchInfo(index,baseaddress).ValueOrDefault()
                );

        /// <summary>
        /// Extracts register information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        static Option<AsmRegisterInfo> RegisterInfo(this Instruction src, int index)
            => src.GetOpKind(index).IsRegister() ? new AsmRegisterInfo(src.GetOpRegister(index).ToString()) : default;

        static Option<AsmBranchInfo> BranchInfo(this Instruction src, int index, ulong baseaddress)
        {
            var kind = src.GetOpKind(index);
            if(kind.IsBranch())
            {
                switch(kind)
                {
                    case AsmOpKind.NearBranch16:
                        return AsmBranchInfo.Define(16, src.NearBranch16, true, baseaddress);
                    case AsmOpKind.NearBranch32:
                        return AsmBranchInfo.Define(32, src.NearBranch32, true, baseaddress);
                    case AsmOpKind.NearBranch64:
                        return AsmBranchInfo.Define(64, src.NearBranch64, true, baseaddress);
                    case AsmOpKind.FarBranch16:
                        return AsmBranchInfo.Define(16, src.FarBranch16, false, baseaddress);
                    case AsmOpKind.FarBranch32:
                        return AsmBranchInfo.Define(32, src.FarBranch32, false, baseaddress);
                }
            }

            return default;
        }

        /// <summary>
        /// Extracts immediate information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        static Option<ImmInfo> ImmediateInfo(this Instruction src, int index)
        {
            var kind = src.GetOpKind(index);
            int size = kind.ImmediateSize();
            if(kind.IsImmediate() && size != 0)
            {
                var signed = kind.IsSignExtendedImmediate();
                var imm = src.GetImmediate(index);
                switch(size)
                {
                    case Pow2.T03:
                        return ImmInfo.Define(size, imm);
                    case Pow2.T04:
                        if(signed)
                            return ImmInfo.Define(size, (long)imm);
                        else 
                            return ImmInfo.Define(size, imm);
                    case Pow2.T05:
                        if(signed)
                            return ImmInfo.Define(size, (long)imm);
                        else 
                            return ImmInfo.Define(size, imm);
                    case Pow2.T06:
                        if(signed)
                            return ImmInfo.Define(size, (long)imm);
                        else 
                            return ImmInfo.Define(size, imm);
                }
            }

            return default;
        }

        /// <summary>
        /// Determines the size of a classified immediate operand, if applicable; otherwise, returns 0
        /// </summary>
        /// <param name="src">The operand classifier</param>
        static int ImmediateSize(this AsmOpKind src)
        {
            if(src == Immediate8 || src == Immediate8_2nd)
                return 8;
            else if(src == Immediate16 || src == Immediate8to16)
                return 16;
            else if(src == Immediate32 || src == Immediate8to32)
                return 32;
            else if(src == Immediate64 || src == Immediate8to64 || src == Immediate32to64)
                return 64;
            else
                return 0;
        }
        
        static bool IsSpecified(this Register r)
            => r != Iced.Intel.Register.None;

        static string Format(this MemorySize src)
            => src switch {
                MemorySize.Int8 => "8i",
                MemorySize.Int16 => "16i",
                MemorySize.Int32 => "32i",
                MemorySize.Int64 => "64i",
                MemorySize.UInt8 => "8u",
                MemorySize.UInt16 => "16u",
                MemorySize.UInt32 => "32u",
                MemorySize.UInt64 => "64u",
                _   => src.ToString()
            };

        /// <summary>
        /// Extracts memory information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        static Option<AsmMemInfo> MemoryInfo(this Instruction src, int index)
        {            
            var kind = src.GetOpKind(index);
            
            if(kind.IsMemory())
            {
                var info = new AsmMemInfo();
                info.Size = src.MemorySize.Format();

                if(kind.IsDirectMemory())
                {
                    info.BaseRegister = src.MemoryBase.ToString();
                    info.Displacement = src.MemoryDisplacement;
                    info.DisplacementSize = src.MemoryDisplSize;
                    info.IndexScale = src.MemoryIndexScale;
                }

                if(kind.IsDirectMemory() || kind.IsBaseSegment())
                {
                    if(src.SegmentPrefix.IsSpecified())
                        info.SegmentPrefix = src.SegmentPrefix.ToString();
                    
                    info.SegmentRegister = src.MemorySegment.ToString();
                }

                if(kind.IsMem64())
                    info.Address = src.MemoryAddress64;                

                return info;
            }

            return default;
        }

    }
}
