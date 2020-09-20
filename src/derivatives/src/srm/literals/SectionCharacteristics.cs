//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    partial struct ClrStorage
    {
        public enum SectionCharacteristics : uint
        {
            TypeReg = 0x00000000, // Reserved.

            TypeDSect = 0x00000001, // Reserved.

            TypeNoLoad = 0x00000002, // Reserved.

            TypeGroup = 0x00000004, // Reserved.

            TypeNoPad = 0x00000008, // Reserved.

            TypeCopy = 0x00000010, // Reserved.

            CNTCode = 0x00000020, // Section contains code.

            CNTInitializedData = 0x00000040, // Section contains initialized data.

            CNTUninitializedData = 0x00000080, // Section contains uninitialized data.

            LNKOther = 0x00000100, // Reserved.

            LNKInfo = 0x00000200, // Section contains comments or some other type of information.

            TypeOver = 0x00000400, // Reserved.

            LNKRemove = 0x00000800, // Section contents will not become part of image.

            LNKCOMDAT = 0x00001000, // Section contents comdat.
            //                                0x00002000  // Reserved.

            MemProtected = 0x00004000,

            No_Defer_Spec_Exc = 0x00004000, // Reset speculative exceptions handling bits in the TLB entries for this section.

            GPRel = 0x00008000, // Section content can be accessed relative to GP

            MemFardata = 0x00008000,

            MemSysheap = 0x00010000,

            MemPurgeable = 0x00020000,

            Mem16Bit = 0x00020000,

            MemLocked = 0x00040000,

            MemPreload = 0x00080000,

            Align1Bytes = 0x00100000, //

            Align2Bytes = 0x00200000, //

            Align4Bytes = 0x00300000, //

            Align8Bytes = 0x00400000, //

            Align16Bytes = 0x00500000, // Default alignment if no others are specified.

            Align32Bytes = 0x00600000, //

            Align64Bytes = 0x00700000, //

            Align128Bytes = 0x00800000, //

            Align256Bytes = 0x00900000, //

            Align512Bytes = 0x00A00000, //

            Align1024Bytes = 0x00B00000, //

            Align2048Bytes = 0x00C00000, //

            Align4096Bytes = 0x00D00000, //

            Align8192Bytes = 0x00E00000, //

            // Unused                     0x00F00000
            AlignMask = 0x00F00000,

            LNKNRelocOvfl = 0x01000000, // Section contains extended relocations.

            MemDiscardable = 0x02000000, // Section can be discarded.

            MemNotCached = 0x04000000, // Section is not cachable.

            MemNotPaged = 0x08000000, // Section is not pageable.

            MemShared = 0x10000000, // Section is shareable.

            MemExecute = 0x20000000, // Section is executable.

            MemRead = 0x40000000, // Section is readable.

            MemWrite = 0x80000000, // Section is writeable.
        }

    }
}