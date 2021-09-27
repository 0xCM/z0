//-----------------------------------------------------------------------------
// Copyright   :  (c) LLVM Project
// License     :  Apache-2.0 WITH LLVM-exceptions
//-----------------------------------------------------------------------------
namespace llvm.X86
{
    /// <summary>
    /// From llvm/lib/Target/X86/MCTargetDesc/X86FixupKinds.h
    /// </summary>
    public enum Fixups : ushort
    {
        reloc_riprel_4byte = MCFixupKind.FirstTargetFixupKind, // 32-bit rip-relative

        reloc_riprel_4byte_movq_load, // 32-bit rip-relative in movq

        reloc_riprel_4byte_relax, // 32-bit rip-relative in relaxable instruction

        reloc_riprel_4byte_relax_rex, // 32-bit rip-relative in relaxable instruction with rex prefix

        reloc_signed_4byte, // 32-bit signed. Unlike FK_Data_4 this will be sign extended at runtime.

        reloc_signed_4byte_relax, // like reloc_signed_4byte, but in a relaxable instruction.

        reloc_global_offset_table, // 32-bit, relative to the start of the instruction. Used only for _GLOBAL_OFFSET_TABLE_.

        reloc_global_offset_table8, // 64-bit variant.

        reloc_branch_4byte_pcrel, // 32-bit PC relative branch.

        // Marker
        LastTargetFixupKind,

        NumTargetFixupKinds = LastTargetFixupKind - MCFixupKind.FirstTargetFixupKind
    };
}