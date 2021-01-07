//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using static Asm.IceOpKind;

    using static Part;

    [ApiHost]
    public readonly struct AsmTest
    {
        /// <summary>
        /// Determines whether the classified operand is a 16-bit, 32-bit or 64-bit near branch
        /// Assessed respectively via the NearBranch16, NearBranch32 and NearBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline), Op]
        public static bool isNearBranch(IceOpKind src)
            => src == IceOpKind.NearBranch16
            || src == IceOpKind.NearBranch32
            || src == IceOpKind.NearBranch64;

        /// <summary>
        /// Determines whether a classified operand is associated with a branching instruction
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline), Op]
        public static bool isBranch(IceOpKind src)
            => isNearBranch(src) || isFarBranch(src);

        /// <summary>
        /// Tests whether the the source operand kind is a register kind
        /// </summary>
        /// <param name="src">The source operand kind</param>
        [MethodImpl(Inline), Op]
        public static bool isRegister(IceOpKind src)
            => src == IceOpKind.Register;

        [MethodImpl(Inline), Op]
        public static bool isCall(Instruction src)
            => src.Mnemonic == IceMnemonic.Call;

        /// <summary>
        /// Determines whether the classified operand is a 32-bit or 64-bit far branch
        /// Assessed respectively via the FarBranch32 and FarBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline), Op]
        public static bool isFarBranch(IceOpKind src)
            => src == IceOpKind.FarBranch16
            || src == IceOpKind.FarBranch32;

        /// <summary>
        /// Determines whether the classified operand a sign-extended immediate which may include:
        /// An 8-bit value sign extended to 16 bits, accessed via the Immediate8to16 instruction attribute
        /// An 8-bit value sign extended to 32 bits, accessed via Immediate8to32 instruction attribute
        /// An 8-bit value sign extended to 64 bits, accessed via the Immediate8to64 instruction attribute
        /// A 32-bit value sign extended to 64 bits, accessed via the Immediate32to64 instruction attribute
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline), Op]
        public static bool isSignedImm(IceOpKind src)
            => src == Immediate8to16
            || src == Immediate8to32
            || src == Immediate8to64
            || src == Immediate32to64;

        /// <summary>
        /// Determines whether the classified operand is an 8-bit, 16-bit, 32-bit or 64-bit constant
        /// which are accessed respectively through the Immediate8, Immediate16, Immediate32, and Immediate64
        /// instruction attributes
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline), Op]
        public static bool isDirectImm(IceOpKind src)
            => src == Immediate8
            || src == Immediate16
            || src == Immediate32
            || src == Immediate64;

        /// <summary>
        /// Determines whether the classified operand is an 8-bit immediate
        /// used by the enter, extrq, or insertq instructions
        /// Accessed via the instruction attribute Immediate8_2nd
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline), Op]
        public static bool isSpecialImm(IceOpKind src)
            => src == Immediate8_2nd;

        /// <summary>
        /// Determines whether the classified operand is an immediate of some sort
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline), Op]
        public static bool isImm(IceOpKind src)
            => isSignedImm(src) || isDirectImm(src) || isSpecialImm(src);

        [MethodImpl(Inline), Op]
        public bool isMem(in Instruction src, byte index)
        {
            switch(asm.kind(src,index))
            {
                case Memory:
                case Memory64:
                case MemorySegSI:
                case MemorySegESI:
                case MemorySegRSI:
                case MemoryESDI:
                case MemoryESEDI:
                case MemoryESRDI:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Determines whether the classified operand is some sort of memory
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline), Op]
        public static  bool isMem(IceOpKind src)
            => isMemDirect(src) || isMem64(src) || isSegEs(src) || isSegBase(src);

        /// <summary>
        /// Determines whether the classified operand is direct memory.
        /// Relevant instruction attributes include:
        /// MemoryDisplSize, MemorySize, MemoryIndexScale, MemoryDisplacement, MemoryBase,
        /// MemoryIndex, MemorySegment, SegmentPrefix
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline), Op]
        public static bool isMemDirect(IceOpKind src)
            => src == IceOpKind.Memory;

        /// <summary>
        /// Determines whether the classified operand is a 64-bit memory offset.
        /// Relevant instruction attributes include:
        /// MemoryAddress64, MemorySegment, SegmentPrefix, MemorySize
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline), Op]
        public static bool isMem64(IceOpKind src)
            => src == IceOpKind.Memory64;

        /// <summary>
        /// Determines whether the classified operand is a segment of the form
        /// seg:[di], seg:[edi], seg:[esi], seg:[rdi], seg:[rsi], seg:[si]
        /// Relevant instruction attributes include: MemorySize, MemorySegment, SegmentPrefix
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline), Op]
        public static bool isSegBase(IceOpKind src)
            => src == MemorySegDI
            || src == MemorySegEDI
            || src == MemorySegESI
            || src == MemorySegRDI
            || src == MemorySegRSI
            || src == MemorySegSI;

        /// <summary>
        /// Determines whether the classified operand is an ES ("extra") memory segment.
        /// Possible choices include es:[di], es:[edi], es:[rdi]
        /// Relevant instruction attributes inlude: MemorySize
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline), Op]
        public static bool isSegEs(IceOpKind src)
            => src == IceOpKind.MemoryESDI
            || src == IceOpKind.MemoryESEDI
            || src == IceOpKind.MemoryESRDI;


        [MethodImpl(Inline), Op]
        public static bool empty(in AsmFxMemory src)
        {
            var empty = true;
            empty &= (src.MemoryBase == 0);
            empty &= (src.MemoryIndex == 0);
            empty &= (src.MemorySize == 0);
            empty &= (src.MemoryIndexScale.IsEmpty);
            empty &= (src.MemDx.IsEmpty);
            empty &= (src.MemorySegment == 0);
            empty &= (src.SegmentPrefix == 0);
            empty &= (!src.IsStackInstruction);
            empty &= (src.StackPointerIncrement == 0);
            empty &= (!src.IsIPRelativeMemoryOperand);
            return empty;
        }
    }
}