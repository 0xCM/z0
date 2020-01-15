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
    
    public static class AsmDistiller
    {        
        /// <summary>
        /// Decodes an assembly code block
        /// </summary>
        /// <param name="src">The source assembly block</param>
		public static InstructionBlock DistillInstructions(this AsmCode src)
            => Deconstructor.Decode(src.Name, src.Data);

        /// <summary>
        /// Disassembles the assembly code for reified methods declared by the source type
        /// </summary>
        /// <param name="src">The source type</param>
        public static AsmFuncInfo[] DistillAsmFunctions(this Type src)
            => Deconstructor.Deconstruct(src).DistillAsmFunctions().ToArray();

        public static AsmFuncInfo DistillAsmFunction(this AsmCode code)
        {
            var src = code.DistillInstructions();
            var count = src.InstructionCount;
            Span<byte> data = code.Data;
            var startaddress = src[0].IP;
            var endaddress = src[count - 1].IP + (ulong)src[count - 1].ByteLength; 
            var format = src.FormatAsm(AsmFormatConfig.Default.Invert());            
            var dst = new AsmInstructionInfo[count];
            for(var i=0; i<count; i++)
                dst[i] = src[i].Summarize(data, format[i], startaddress);
            return new AsmFuncInfo(startaddress, endaddress, code.Name, dst, code.Data);            
        }

        public static IEnumerable<AsmFuncInfo> DistillAsmFunctions(this IEnumerable<MethodDisassembly> src)
            => src.Select(DistillAsmFunction);

        public static AsmFuncInfo DistillAsmFunction(this MethodDisassembly src)
        {
            var asm = src.AsmBody;
            var count = asm.Instructions.Length;
            var code = asm.NativeBlock.Data;
            Span<byte> codespan = code;
            var inxs = new AsmInstructionInfo[count];
            var inxsfmt = asm.FormatAsm(AsmFormatConfig.Default.Invert());

            for(var i=0; i<count; i++)
            {
                var instruction = asm.Instructions[i];
                var offset = (ushort)(instruction.IP - asm.StartAddress);
                var encoded = codespan.Slice(offset, instruction.ByteLength).ToArray();
                //var operands = instruction.DistillOperands(asm);                
                var operands = instruction.Operands(asm.StartAddress);
                var mnemonic = instruction.Mnemonic.ToString().ToUpper();
                var opcode = instruction.Code.ToString();
                var enckind = instruction.Encoding == EncodingKind.Legacy ? string.Empty : instruction.Encoding.ToString();
                inxs[i] = AsmInstructionInfo.Define(offset, inxsfmt[i], mnemonic, opcode, operands, enckind, encoded);
            }

            return new AsmFuncInfo(asm.StartAddress, asm.EndAddress, src.MethodSig, inxs, code);            
        }

        /// <summary>
        /// Extracts operand information from an instruction
        /// </summary>
        /// <param name="instruction">The source instruction</param>
        static AsmOperandInfo[] Operands(this Instruction instruction, ulong startaddress)        
        {
            var args = new AsmOperandInfo[instruction.OpCount];
            for(byte j=0; j< instruction.OpCount; j++)
            {
                var operandKind = instruction.GetOpKind(j);
                var imm = instruction.ImmediateInfo(j);
                var reg = operandKind == AsmOpKind.Register ? instruction.RegisterInfo(j) : null;
                var mem = operandKind.IsMemory() ? instruction.MemoryInfo(j) : null;
                var branch = operandKind.IsBranch() ? instruction.BranchInfo(j, startaddress) : null;
                args[j] = AsmOperandInfo.Define(j, operandKind.ToString(), imm, mem, reg, branch);
            }
            return args;
        }

        static AsmInstructionInfo Summarize(this Instruction instruction, Span<byte> data, string formatted, ulong startaddress)
        {
            var offset = (ushort)(instruction.IP - startaddress);
            var encoded = data.Slice(offset, instruction.ByteLength).ToArray();
            var operands = instruction.Operands(startaddress);
            var mnemonic = instruction.Mnemonic.ToString().ToUpper();
            var opcode = instruction.Code.ToString();
            var enckind = instruction.Encoding == EncodingKind.Legacy ? string.Empty : instruction.Encoding.ToString();            
            return AsmInstructionInfo.Define(offset, formatted, mnemonic, opcode, operands, enckind, encoded);
        }

        // static AsmOperandInfo[] DistillOperands(this Instruction inx, MethodAsmBody asm)        
        // {
        //     var args = new AsmOperandInfo[inx.OpCount];
        //     for(byte j=0; j< inx.OpCount; j++)
        //     {
        //         var operandKind = inx.GetOpKind(j);
        //         var imm = inx.ImmediateInfo(j);
        //         var reg = operandKind == AsmOpKind.Register ? inx.RegisterInfo(j) : null;
        //         var mem = operandKind.IsMemory() ? inx.MemoryInfo(j) : null;
        //         var branch = operandKind.IsBranch() ? inx.BranchInfo(j, asm.StartAddress) : null;
        //         args[j] = AsmOperandInfo.Define(j, operandKind.ToString(), imm, mem, reg, branch);
        //     }
        //     return args;
        // }

        /// <summary>
        /// Extracts register information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="inx">The source instruction</param>
        /// <param name="operand">The operand index</param>
        static Option<AsmRegisterInfo> RegisterInfo(this Instruction inx, int operand)
        {
            var kind = inx.GetOpKind(operand);
            if(kind.IsRegister())
            {
                var reg = inx.GetOpRegister(operand);
                return new AsmRegisterInfo(reg.ToString());                
            }

            return default;
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
        /// <param name="inx">The source instruction</param>
        /// <param name="operand">The operand index</param>
        static Option<AsmMemInfo> MemoryInfo(this Instruction inx, byte operand)
        {            
            var kind = inx.GetOpKind(operand);
            if(!kind.IsMemory())
                return default;

            var info = new AsmMemInfo();
            info.Size = inx.MemorySize.Format();

            if(kind.IsMemDirect())
            {
                info.BaseRegister = inx.MemoryBase.ToString();
                info.Displacement = inx.MemoryDisplacement;
                info.DisplacementSize = inx.MemoryDisplSize;
                info.IndexScale = inx.MemoryIndexScale;
            }

            if(kind.IsMemDirect() || kind.IsMemBaseSegment())
            {
                if(inx.SegmentPrefix.IsSpecified())
                    info.SegmentPrefix = inx.SegmentPrefix.ToString();
                
                info.SegmentRegister = inx.MemorySegment.ToString();
            }

            if(kind.IsMemOffset64())
                info.Address = inx.MemoryAddress64;                

            return info;
        }

        static Option<AsmBranchInfo> BranchInfo(this Instruction instruction, int operand, ulong baseAddress)
        {
            var result = none<AsmBranchInfo>();
            var kind = instruction.GetOpKind(operand);
            if(kind.IsBranch())
            {
                switch(kind)
                {
                    case AsmOpKind.NearBranch16:
                        return new AsmBranchInfo(16, instruction.NearBranch16, true, baseAddress);
                    case AsmOpKind.NearBranch32:
                        return new AsmBranchInfo(32, instruction.NearBranch32, true, baseAddress);
                    case AsmOpKind.NearBranch64:
                        return new AsmBranchInfo(64, instruction.NearBranch64, true, baseAddress);
                    case AsmOpKind.FarBranch16:
                        return new AsmBranchInfo(16, instruction.FarBranch16, false, baseAddress);
                    case AsmOpKind.FarBranch32:
                        return new AsmBranchInfo(32, instruction.FarBranch32, false, baseAddress);
                }
            }

            return result;
        }

        /// <summary>
        /// Extracts immediate information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="instruction">The source instruction</param>
        /// <param name="operand">The operand index</param>
        static Option<ImmInfo> ImmediateInfo(this Instruction instruction, int operand)
        {
            var result = none<ImmInfo>();
            var kind = instruction.GetOpKind(operand);
            int size = kind.GetImmediateSize();
            if(size != 0)
            {
                var signed = kind.IsSignExtendedImmediate();
                var imm = instruction.GetImmediate(operand);
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

            return result;
        }

        /// <summary>
        /// Determines whether the classified operand is a 16-bit, 32-bit or 64-bit near branch
        /// Assessed respectively via the NearBranch16, NearBranch32 and NearBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        static bool IsNearBranch(this AsmOpKind src)        
            => src == AsmOpKind.NearBranch16
            || src == AsmOpKind.NearBranch32
            || src == AsmOpKind.NearBranch64;

        /// <summary>
        /// Determines whether the classified operand is a 32-bit or 64-bit far branch
        /// Assessed respectively via the FarBranch32 and FarBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        static bool IsFarBranch(this AsmOpKind src)        
            => src == AsmOpKind.FarBranch16
            || src == AsmOpKind.FarBranch32;

        /// <summary>
        /// Determines whether a classified operand is associated with a branching instruction
        /// </summary>
        /// <param name="src">The operand classification</param>
        static bool IsBranch(this AsmOpKind src)
            => src.IsFarBranch() || src.IsNearBranch();

        /// <summary>
        /// Determines whether the classified operand is an 8-bit immediate
        /// used by the enter, extrq, or insertq instructions
        /// Accessed via the instruction attribute Immediate8_2nd
        /// </summary>
        /// <param name="src">The operand classifier</param>
        static bool IsSpecialImmediate8(this AsmOpKind src)
            => src == AsmOpKind.Immediate8_2nd;
        
        /// <summary>
        /// Determines whether the classified operand a sign-extended immediate which may include:
        /// An 8-bit value sign extended to 16 bits, accessed via the Immediate8to16 instruction attribute
        /// An 8-bit value sign extended to 32 bits, accessed via Immediate8to32 instruction attribute
        /// An 8-bit value sign extended to 64 bits, accessed via the Immediate8to64 instruction attribute
        /// A 32-bit value sign extended to 64 bits, accessed via the Immediate32to64 instruction attribute
        /// </summary>
        /// <param name="src">The operand classifier</param>
        static bool IsSignExtendedImmediate(this AsmOpKind src)
            => src == AsmOpKind.Immediate8to16  
            || src == AsmOpKind.Immediate8to32  
            || src == AsmOpKind.Immediate8to64  
            || src == AsmOpKind.Immediate32to64 
             ;

        /// <summary>
        /// Determines whether the classified operand is an 8-bit, 16-bit, 32-bit or 64-bit constant
        /// which are accessed respectively through the Immediate8, Immediate16, Immediate32, and Immediate64
        /// instruction attributes
        /// </summary>
        /// <param name="src">The operand classifier</param>
        static bool IsDirectImmediate(this AsmOpKind src)
            => src == AsmOpKind.Immediate8
            || src == AsmOpKind.Immediate16
            || src == AsmOpKind.Immediate32
            || src == AsmOpKind.Immediate64
            ;

        /// <summary>
        /// Determines whether the classified operand is an immediate of some sort
        /// </summary>
        /// <param name="src">The operand classifier</param>
        static bool IsImmediate(this AsmOpKind src)
            => src.IsSignExtendedImmediate() || src.IsDirectImmediate() || src.IsSpecialImmediate8();

        /// <summary>
        /// Determines the size of a classified immediate operand, if applicable; otherwise,
        /// returns <see cref='BitSize.Zero'/>
        /// </summary>
        /// <param name="src">The operand classifier</param>
        static BitSize GetImmediateSize(this AsmOpKind src)
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
                return BitSize.Zero;
        }
        
        /// <summary>
        /// Determines whether the classified operand is a segment of the form 
        /// seg:[di], seg:[edi], seg:[esi], seg:[rdi], seg:[rsi], seg:[si]
        /// Relevant instruction attributes include: MemorySize, MemorySegment, SegmentPrefix 
        /// </summary>
        /// <param name="src">The operand classifier</param>
        static bool IsMemBaseSegment(this AsmOpKind src)
            => src == AsmOpKind.MemorySegDI
            || src == AsmOpKind.MemorySegEDI
            || src == AsmOpKind.MemorySegESI
            || src == AsmOpKind.MemorySegRDI
            || src == AsmOpKind.MemorySegRSI
            || src == AsmOpKind.MemorySegSI
            ;

        /// <summary>
        /// Determines whether the classified operand is an ES ("extra") memory segment.
        /// Possible choices include es:[di], es:[edi], es:[rdi]
        /// Relevant instruction attributes inlude: MemorySize
        /// </summary>
        /// <param name="src">The operand classifier</param>
        static bool IsMemEsSegment(this AsmOpKind src)            
            => src == AsmOpKind.MemoryESDI
            || src == AsmOpKind.MemoryESEDI
            || src == AsmOpKind.MemoryESRDI;

        /// <summary>
        /// Determines whether the classified operand is a 64-bit memory offset. 
        /// Relevant instruction attributes include:
        /// MemoryAddress64, MemorySegment, SegmentPrefix, MemorySize
        /// </summary>
        /// <param name="src">The operand classifier</param>
        static bool IsMemOffset64(this AsmOpKind src)
            =>  src == AsmOpKind.Memory64;

        /// <summary>
        /// Determines whether the classified operand is direct memory.
        /// Relevant instruction attributes include: 
        /// MemoryDisplSize, MemorySize, MemoryIndexScale, MemoryDisplacement, MemoryBase, 
        /// MemoryIndex, MemorySegment, SegmentPrefix
        /// </summary>
        /// <param name="src">The operand classifier</param>
        static bool IsMemDirect(this AsmOpKind src)
            => src == AsmOpKind.Memory;         
        
        /// <summary>
        /// Determines whether the classified operand is some sort of memory
        /// </summary>
        /// <param name="src">The operand classifier</param>
        static bool IsMemory(this AsmOpKind src)            
            => src.IsMemDirect() || src.IsMemOffset64() || src.IsMemEsSegment() || src.IsMemBaseSegment();

        /// <summary>
        /// Determines whether the classified operand is a register
        /// </summary>
        /// <param name="src">The operand classifier</param>
        static bool IsRegister(this AsmOpKind src)
            => src == AsmOpKind.Register; 
    }
}