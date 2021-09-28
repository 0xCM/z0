//-----------------------------------------------------------------------------
// Copyright   :  (c) LLVM Project
// License     :  Apache-2.0 WITH LLVM-exceptions
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    partial struct MCDomain
    {
        /// <summary>
        /// From llvm\lib\Target\X86\MCTargetDesc\X86FixupKinds.h
        /// </summary>
        [SymSource]
        public enum MCFixupKind : ushort
        {
            [Symbol("FK_NONE","A no-op fixup")]
            FK_NONE = 0,

            [Symbol("FK_Data_1", "A one-byte fixup")]
            FK_Data_1,

            [Symbol("FK_Data_2", "A two-byte fixup")]
            FK_Data_2,

            [Symbol("FK_Data_4", "A four-byte fixup")]
            FK_Data_4,

            [Symbol("FK_Data_8", "A eight-byte fixup")]
            FK_Data_8,

            [Symbol("", "A six-bits fixup")]
            FK_Data_6b,     ///< A six-bits fixup.

            [Symbol("", "")]
            FK_PCRel_1,     ///< A one-byte pc relative fixup.

            [Symbol("", "")]
            FK_PCRel_2,     ///< A two-byte pc relative fixup.

            [Symbol("", "")]
            FK_PCRel_4,     ///< A four-byte pc relative fixup.

            [Symbol("", "")]
            FK_PCRel_8,     ///< A eight-byte pc relative fixup.

            [Symbol("", "")]
            FK_GPRel_1,     ///< A one-byte gp relative fixup.

            [Symbol("", "")]
            FK_GPRel_2,     ///< A two-byte gp relative fixup.

            [Symbol("", "")]
            FK_GPRel_4,     ///< A four-byte gp relative fixup.

            [Symbol("", "")]
            FK_GPRel_8,     ///< A eight-byte gp relative fixup.

            [Symbol("", "A four-byte dtp relative fixup")]
            FK_DTPRel_4,

            [Symbol("", "")]
            FK_DTPRel_8,    ///< A eight-byte dtp relative fixup.

            [Symbol("", "")]
            FK_TPRel_4,     ///< A four-byte tp relative fixup.

            [Symbol("", "")]
            FK_TPRel_8,     ///< A eight-byte tp relative fixup.

            [Symbol("", "A one-byte section relative fixup")]
            FK_SecRel_1,    ///< A one-byte section relative fixup.

            [Symbol("", "A two-byte section relative fixup")]
            FK_SecRel_2,    ///< A two-byte section relative fixup.

            [Symbol("", "A four-byte section relative fixup")]
            FK_SecRel_4,    ///< A four-byte section relative fixup.

            [Symbol("", "A eight-byte section relative fixup")]
            FK_SecRel_8,    ///< A eight-byte section relative fixup.

            FirstTargetFixupKind = 128,

            /// The range [FirstLiteralRelocationKind, MaxTargetFixupKind) is used for
            /// relocations coming from .reloc directive. Fixup kind
            /// FirstLiteralRelocationKind+V represents the relocation type with number V.
            FirstLiteralRelocationKind = 256,

            /// Set limit to accommodate the highest reloc type in use for all Targets,
            /// currently R_AARCH64_IRELATIVE at 1032, including room for expansion.
            MaxFixupKind = FirstLiteralRelocationKind + 1032 + 32,
        }
    }
}