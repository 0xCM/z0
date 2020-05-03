//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static AsmQuery;

    public interface IAsmQuery
    {
        IAsmBranch BranchInfo(MemoryAddress @base, Instruction src, int index)
            => Service.BranchInfo(@base, src,index);        

        [MethodImpl(Inline)]
        InstructionInfo Details(Instruction src)        
            => Service.Details(src);

        /// <summary>
        /// Extracts immediate information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        [MethodImpl(Inline)]
        AsmImmInfo DescribeImm(Instruction src, int index)
            => Service.DescribeImm(src,index);

        /// <summary>
        /// Extracts operand instruction data
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="@base">The base address</param>
        [MethodImpl(Inline)]
        AsmOperandInfo[] Operands(MemoryAddress @base, Instruction src)
            => Service.Operands(@base, src);

        [MethodImpl(Inline)]
        AsmOperandInfo Operand(MemoryAddress @base, Instruction src, int index)
            => Service.Operand(@base,src,index);            

 		/// <summary>
		/// Gets an operand's kind if it exists
		/// </summary>
		/// <param name="operand">Operand number, 0-4</param>
        [MethodImpl(Inline)]
        OpKind OperandKind(Instruction src, int operand)
            => Service.OperandKind(src,operand);

        [MethodImpl(Inline)]
        AsmInstructionSummary Summarize(MemoryAddress @base, Instruction src, ReadOnlySpan<byte> encoded, string content, ushort offset)
                => Service.Summarize(@base, src,encoded, content,offset);            

        /// <summary>
        /// Describes the instructions that comprise an instruction list
        /// </summary>
        /// <param name="src">The source instruction list</param>
        AsmInstructionSummary[] Summarize(AsmInstructionList src)
            => Service.Summarize(src);

        /// <summary>
        /// Describes the instructions that comprise a function
        /// </summary>
        /// <param name="src">The source function</param>
        AsmInstructionSummary[] Summarize(AsmFunction src)
            => Service.Summarize(src); 
                    
        /// <summary>
        /// Determines whether the classified operand is a segment of the form 
        /// seg:[di], seg:[edi], seg:[esi], seg:[rdi], seg:[rsi], seg:[si]
        /// Relevant instruction attributes include: MemorySize, MemorySegment, SegmentPrefix 
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        bool IsSegBase(OpKind src)
            => Service.IsSegBase(src);        

        /// <summary>
        /// Determines whether the classified operand is a 16-bit, 32-bit or 64-bit near branch
        /// Assessed respectively via the NearBranch16, NearBranch32 and NearBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline)]
        bool IsNearBranch(OpKind src)        
            => Service.IsNearBranch(src);

        /// <summary>
        /// Determines whether the classified operand is a 32-bit or 64-bit far branch
        /// Assessed respectively via the FarBranch32 and FarBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline)]
        bool IsFarBranch(OpKind src)        
            => Service.IsFarBranch(src);
       
        /// <summary>
        /// Determines whether a classified operand is associated with a branching instruction
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline)]
        bool IsBranch(OpKind src)
            => Service.IsBranch(src);

        /// <summary>
        /// Determines the size of a classified immediate operand, if applicable; otherwise, returns 0
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        NumericWidth ImmWidth(OpKind src)
            => Service.ImmWidth(src);

		/// <summary>
		/// Extracts an immediate operand from an instruction
		/// </summary>
		/// <param name="src">The source instruction</param>
		/// <param name="index">The operand index</param>
        [MethodImpl(Inline)]
        ulong ExtractImm(Instruction src, int index) 
            => Service.ExtractImm(src,index);

        /// <summary>
        /// Determines whether the classified operand a sign-extended immediate which may include:
        /// An 8-bit value sign extended to 16 bits, accessed via the Immediate8to16 instruction attribute
        /// An 8-bit value sign extended to 32 bits, accessed via Immediate8to32 instruction attribute
        /// An 8-bit value sign extended to 64 bits, accessed via the Immediate8to64 instruction attribute
        /// A 32-bit value sign extended to 64 bits, accessed via the Immediate32to64 instruction attribute
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        bool IsSignedImm(OpKind src)
            => Service.IsSignedImm(src);

        /// <summary>
        /// Determines whether the classified operand is an 8-bit, 16-bit, 32-bit or 64-bit constant
        /// which are accessed respectively through the Immediate8, Immediate16, Immediate32, and Immediate64
        /// instruction attributes
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        bool IsDirectImm(OpKind src)
            => Service.IsDirectImm(src);

        /// <summary>
        /// Determines whether the classified operand is an 8-bit immediate
        /// used by the enter, extrq, or insertq instructions
        /// Accessed via the instruction attribute Immediate8_2nd
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        bool IsSpecialImm(OpKind src)
            => Service.IsSpecialImm(src);
        
        /// <summary>
        /// Determines whether the classified operand is an immediate of some sort
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        bool IsImmOperand(OpKind src)
            => Service.IsImmOperand(src);

        // /// <summary>
        // /// Extracts immediate information, if applicable, from an instruction operand
        // /// </summary>
        // /// <param name="src">The source instruction</param>
        // /// <param name="index">The operand index</param>
        // AsmImmInfo ImmInfo(Instruction src, int index)
        //     => Service.ImmInfo(src,index);

        /// <summary>
        /// Tests whether the the source operand kind is a register kind
        /// </summary>
        /// <param name="src">The source kind to test</param>
        [MethodImpl(Inline)]
        bool IsRegisterOperand(OpKind src)
            => Service.IsRegisterOperand(src);

        /// <summary>
        /// Extracts memory information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        [MethodImpl(Inline)]
        AsmMemInfo MemInfo(Instruction src, int index)            
            => Service.MemInfo(src,index);

        /// <summary>
        /// Determines whether the classified operand is some sort of memory
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        bool IsMem(OpKind src)            
            => Service.IsMem(src);

        /// <summary>
        /// Determines whether the classified operand is an ES ("extra") memory segment.
        /// Possible choices include es:[di], es:[edi], es:[rdi]
        /// Relevant instruction attributes inlude: MemorySize
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        bool IsMemEs(OpKind src)            
            => Service.IsMemEs(src);

        /// <summary>
        /// Determines whether the classified operand is a 64-bit memory offset. 
        /// Relevant instruction attributes include:
        /// MemoryAddress64, MemorySegment, SegmentPrefix, MemorySize
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        bool IsMem64(OpKind src)
            => Service.IsMem64(src);

        /// <summary>
        /// Determines whether the classified operand is direct memory.
        /// Relevant instruction attributes include: 
        /// MemoryDisplSize, MemorySize, MemoryIndexScale, MemoryDisplacement, MemoryBase, 
        /// MemoryIndex, MemorySegment, SegmentPrefix
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        bool IsMemDirect(OpKind src)
            => Service.IsMemDirect(src);
    }
}