//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static AspectLabels;

    public interface IInstructionMemory
    {
        //
        // Summary:
        //     Checks if the memory operand is RIP/EIP relative
        [Ignore]
        bool IsIPRelativeMemoryOperand {get;}

        //
        // Summary:
        //     Gets the RIP/EIP releative address ((Iced.Intel.Instruction.NextIP or Iced.Intel.Instruction.NextIP32)
        //     + Iced.Intel.Instruction.MemoryDisplacement). This property is only valid if
        //     there's a memory operand with RIP/EIP relative addressing.
        [Label(rel)]
        MemoryAddress IPRelativeMemoryAddress {get;}        

        //
        // Summary:
        //     Gets the memory operand's base register or Iced.Intel.Register.None if none.
        //     Use this property if the operand has kind Iced.Intel.OpKind.Memory
        [Label(@base)]
        Register MemoryBase {get;}

        //
        // Summary:
        //     Gets the memory operand's index register or Iced.Intel.Register.None if none.
        //     Use this property if the operand has kind Iced.Intel.OpKind.Memory
        [Label(index)]
        Register MemoryIndex {get;}
        
        //
        // Summary:
        //     Gets the size of the memory location that is referenced by the operand. See also
        //     Iced.Intel.Instruction.IsBroadcast. Use this property if the operand has kind
        //     Iced.Intel.OpKind.Memory, Iced.Intel.OpKind.Memory64, Iced.Intel.OpKind.MemorySegSI,
        //     Iced.Intel.OpKind.MemorySegESI, Iced.Intel.OpKind.MemorySegRSI, Iced.Intel.OpKind.MemoryESDI,
        //     Iced.Intel.OpKind.MemoryESEDI, Iced.Intel.OpKind.MemoryESRDI
        [Label(size)]
        MemorySize MemorySize {get;}

        //
        // Summary:
        //     Gets the index register scale value, valid values are *1, *2, *4, *8. Use this
        //     property if the operand has kind Iced.Intel.OpKind.Memory
        [Label(scale)]
        AsmMemScale MemoryIndexScale {get;}
        //
        // Summary:
        //     Gets the memory operand's displacement. This should be sign extended to 64 bits
        //     if it's 64-bit addressing. Use this property if the operand has kind Iced.Intel.OpKind.Memory
        //uint MemoryDisplacement {get;}

        //
        // Summary:
        //     Gets the size of the memory displacement in bytes. Valid values are 0, 1 (16/32/64-bit),
        //     2 (16-bit), 4 (32-bit), 8 (64-bit). Note that the return value can be 1 and Iced.Intel.Instruction.MemoryDisplacement
        //     may still not fit in a signed byte if it's an EVEX encoded instruction. Use this
        //     property if the operand has kind Iced.Intel.OpKind.Memory
        //int MemoryDisplSize {get;}

        [Label(dx)]
        AsmMemDx MemDx {get;}


        //
        // Summary:
        //     Gets the effective segment register used to reference the memory location. Use
        //     this property if the operand has kind Iced.Intel.OpKind.Memory, Iced.Intel.OpKind.Memory64,
        //     Iced.Intel.OpKind.MemorySegSI, Iced.Intel.OpKind.MemorySegESI, Iced.Intel.OpKind.MemorySegRSI
        [Label(seg)]
        Register MemorySegment {get;}
        //
        // Summary:
        //     Gets the segment override prefix or Iced.Intel.Register.None if none. See also
        //     Iced.Intel.Instruction.MemorySegment. Use this property if the operand has kind
        //     Iced.Intel.OpKind.Memory, Iced.Intel.OpKind.Memory64, Iced.Intel.OpKind.MemorySegSI,
        //     Iced.Intel.OpKind.MemorySegESI, Iced.Intel.OpKind.MemorySegRSI
        [Label(prefix)]
        Register SegmentPrefix {get;}

        //
        // Summary:
        //     true if this is an instruction that implicitly uses the stack pointer (SP/ESP/RSP),
        //     eg. call, push, pop, ret, etc. See also Iced.Intel.Instruction.StackPointerIncrement
        bool IsStackInstruction {get;}

        //
        // Summary:
        //     Gets the number of bytes added to SP/ESP/RSP or 0 if it's not an instruction
        //     that pushes or pops data. This method assumes the instruction doesn't change
        //     privilege (eg. iret/d/q). If it's the leave instruction, this method returns
        //     0.
        int StackPointerIncrement {get;}
    }
}