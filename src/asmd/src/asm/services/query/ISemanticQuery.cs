//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static AsmQuery;

    public interface ISemanticQuery
    {
        [MethodImpl(Inline)]
        InstructionMemory InxsMemory(Instruction src, int index)            
            => InstructionMemory.From(src,index);

        [MethodImpl(Inline)]
        bool HasInxsMemory(Instruction src, int index)            
            => InstructionMemory.Has(src,index);

        [MethodImpl(Inline)]
        SegmentedIdentity Identify(MemorySize src)        
            => Direct.Identify(src);

        [MethodImpl(Inline)]
        AsmBranchInfo BranchInfo(MemoryAddress @base, Instruction src, int index)
            => Direct.BranchInfo(@base, src,index);        

        /// <summary>
        /// Extracts immediate information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        [MethodImpl(Inline)]
        AsmImmInfo ImmInfo(Instruction src, int index)
            => Direct.ImmInfo(src,index);

 		/// <summary>
		/// Gets an operand's kind if it exists
		/// </summary>
		/// <param name="operand">Operand number, 0-4</param>
        [MethodImpl(Inline)]
        OpKind OperandKind(Instruction src, int operand)
            => Direct.OperandKind(src,operand);

		/// <summary>
		/// Extracts an immediate operand from an instruction
		/// </summary>
		/// <param name="src">The source instruction</param>
		/// <param name="index">The operand index</param>
        [MethodImpl(Inline)]
        ulong ExtractImm(Instruction src, int index) 
            => Direct.ExtractImm(src,index);

        /// <summary>
        /// Extracts memory information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        [MethodImpl(Inline)]
        InstructionMemory MemInfo(Instruction src, int index)            
            => InstructionMemory.From(src,index);

        /// <summary>
        /// Extracts register information, should it exist, from an index-identified register operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        [MethodImpl(Inline)]
        Register RegisterInfo(Instruction src, int index) 
            => Direct.RegisterInfo(src, index);
                    
        /// <summary>
        /// Determines whether the classified operand is a segment of the form 
        /// seg:[di], seg:[edi], seg:[esi], seg:[rdi], seg:[rsi], seg:[si]
        /// Relevant instruction attributes include: MemorySize, MemorySegment, SegmentPrefix 
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        bool IsSegBase(OpKind src)
            => Direct.IsSegBase(src);        

        /// <summary>
        /// Determines whether the classified operand is a 16-bit, 32-bit or 64-bit near branch
        /// Assessed respectively via the NearBranch16, NearBranch32 and NearBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline)]
        bool IsNearBranch(OpKind src)        
            => Direct.IsNearBranch(src);

        /// <summary>
        /// Determines whether the classified operand is a 32-bit or 64-bit far branch
        /// Assessed respectively via the FarBranch32 and FarBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline)]
        bool IsFarBranch(OpKind src)        
            => Direct.IsFarBranch(src);
       
        /// <summary>
        /// Determines whether a classified operand is associated with a branching instruction
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline)]
        bool IsBranch(OpKind src)
            => Direct.IsBranch(src);

        /// <summary>
        /// Determines the size of a classified immediate operand, if applicable; otherwise, returns 0
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        NumericWidth ImmWidth(OpKind src)
            => Direct.ImmWidth(src);

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
            => Direct.IsSignedImm(src);

        /// <summary>
        /// Determines whether the classified operand is an 8-bit, 16-bit, 32-bit or 64-bit constant
        /// which are accessed respectively through the Immediate8, Immediate16, Immediate32, and Immediate64
        /// instruction attributes
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        bool IsDirectImm(OpKind src)
            => Direct.IsDirectImm(src);

        /// <summary>
        /// Determines whether the classified operand is an 8-bit immediate
        /// used by the enter, extrq, or insertq instructions
        /// Accessed via the instruction attribute Immediate8_2nd
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        bool IsSpecialImm(OpKind src)
            => Direct.IsSpecialImm(src);
        
        /// <summary>
        /// Determines whether the classified operand is an immediate of some sort
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        bool IsImm(OpKind src)
            => Direct.IsImm(src);

        /// <summary>
        /// Tests whether the the source operand kind is a register kind
        /// </summary>
        /// <param name="src">The source kind to test</param>
        [MethodImpl(Inline)]
        bool IsRegister(OpKind src)
            => Direct.IsRegister(src);

        /// <summary>
        /// Determines whether the classified operand is some sort of memory
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        bool IsMem(OpKind src)            
            => Direct.IsMem(src);

        /// <summary>
        /// Determines whether the classified operand is an ES ("extra") memory segment.
        /// Possible choices include es:[di], es:[edi], es:[rdi]
        /// Relevant instruction attributes inlude: MemorySize
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        bool IsSegEs(OpKind src)            
            => Direct.IsSegEs(src);

        /// <summary>
        /// Determines whether the classified operand is a 64-bit memory offset. 
        /// Relevant instruction attributes include:
        /// MemoryAddress64, MemorySegment, SegmentPrefix, MemorySize
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        bool IsMem64(OpKind src)
            => Direct.IsMem64(src);

        /// <summary>
        /// Determines whether the classified operand is direct memory.
        /// Relevant instruction attributes include: 
        /// MemoryDisplSize, MemorySize, MemoryIndexScale, MemoryDisplacement, MemoryBase, 
        /// MemoryIndex, MemorySegment, SegmentPrefix
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        bool IsMemDirect(OpKind src)
            => Direct.IsMemDirect(src);

        [MethodImpl(Inline)]
        AsmInstructionSummary Summarize(MemoryAddress @base, Instruction src, ReadOnlySpan<byte> encoded, string content, ushort offset)
                => Direct.Summarize(@base, src,encoded, content,offset);            

        /// <summary>
        /// Describes the instructions that comprise an instruction list
        /// </summary>
        /// <param name="src">The source instruction list</param>
        AsmInstructionSummary[] Summarize(AsmInstructionList src)
            => Direct.Summarize(src);

        /// <summary>
        /// Describes the instructions that comprise a function
        /// </summary>
        /// <param name="src">The source function</param>
        AsmInstructionSummary[] Summarize(AsmFunction src)
            => Direct.Summarize(src); 

        [MethodImpl(Inline)]
        InstructionInfo Details(Instruction src)        
            => Direct.Details(src);

        /// <summary>
        /// Extracts operand instruction data
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="@base">The base address</param>
        [MethodImpl(Inline)]
        AsmOperandInfo[] Operands(MemoryAddress @base, Instruction src)
            => Direct.Operands(@base, src);

        [MethodImpl(Inline)]
        AsmOperandInfo Operand(MemoryAddress @base, Instruction src, int index)
            => Direct.Operand(@base,src,index);

        [MethodImpl(Inline)]
        bool IsCall(Instruction src)
            => Direct.IsCall(src);
    }
}