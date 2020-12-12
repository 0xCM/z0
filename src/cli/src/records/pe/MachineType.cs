//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    partial struct Pe
    {
        /// <summary>
        /// Spcifies a CPU type. An image file can be run only on the specified machine or on a system that emulates the specified machine.
        /// </summary>
        [Data(MachineTypeInfo)]
        public enum MachineType : ushort
        {
            Unknown = 0x0000,

            I386 = 0x014C,

            WceMipsV2 = 0x0169,

            Alpha = 0x0184,

            SH3 = 0x01a2,

            SH3Dsp = 0x01a3,

            SH3E = 0x01a4,

            SH4 = 0x01a6,

            SH5 = 0x01a8,

            Arm = 0x01c0,

            Thumb = 0x01c2,

            ArmThumb2 = 0x01c4,

            AM33 = 0x01d3,

            PowerPC = 0x01F0,

            PowerPCFP = 0x01f1,

            IA64 = 0x0200,

            MIPS16 = 0x0266,

            Alpha64 = 0x0284,

            MipsFpu = 0x0366,

            MipsFpu16 = 0x0466,

            Tricore = 0x0520,

            Ebc = 0x0EBC,

            Amd64 = 0x8664,

            M32R = 0x9041,

            Arm64 = 0xAA64,
        }

        const string MachineTypeInfo = @"
            | Constant | Value | Description |
            | IMAGE_FILE_MACHINE_UNKNOWN | 0x0 | The content of this field is assumed to be applicable to any machine type |
            | IMAGE_FILE_MACHINE_AM33 | 0x1d3 | Matsushita AM33 |
            | IMAGE_FILE_MACHINE_AMD64 | 0x8664 | x64 |
            | IMAGE_FILE_MACHINE_ARM | 0x1c0 | ARM little endian |
            | IMAGE_FILE_MACHINE_ARM64 | 0xaa64 | ARM64 little endian |
            | IMAGE_FILE_MACHINE_ARMNT | 0x1c4 | ARM Thumb-2 little endian |
            | IMAGE_FILE_MACHINE_EBC | 0xebc | EFI byte code |
            | IMAGE_FILE_MACHINE_I386 | 0x14c | Intel 386 or later processors and compatible processors |
            | IMAGE_FILE_MACHINE_IA64 | 0x200 | Intel Itanium processor family |
            | IMAGE_FILE_MACHINE_M32R | 0x9041 | Mitsubishi M32R little endian |
            | IMAGE_FILE_MACHINE_MIPS16 | 0x266 | MIPS16 |
            | IMAGE_FILE_MACHINE_MIPSFPU | 0x366 | MIPS with FPU |
            | IMAGE_FILE_MACHINE_MIPSFPU16 | 0x466 | MIPS16 with FPU |
            | IMAGE_FILE_MACHINE_POWERPC | 0x1f0 | Power PC little endian |
            | IMAGE_FILE_MACHINE_POWERPCFP | 0x1f1 | Power PC with floating point support |
            | IMAGE_FILE_MACHINE_R4000 | 0x166 | MIPS little endian |
            | IMAGE_FILE_MACHINE_RISCV32 | 0x5032 | RISC-V 32-bit address space |
            | IMAGE_FILE_MACHINE_RISCV64 | 0x5064 | RISC-V 64-bit address space |
            | IMAGE_FILE_MACHINE_RISCV128 | 0x5128 | RISC-V 128-bit address space |
            | IMAGE_FILE_MACHINE_SH3 | 0x1a2 | Hitachi SH3 |
            | IMAGE_FILE_MACHINE_SH3DSP | 0x1a3 | Hitachi SH3 DSP |
            | IMAGE_FILE_MACHINE_SH4 | 0x1a6 | Hitachi SH4 |
            | IMAGE_FILE_MACHINE_SH5 | 0x1a8 | Hitachi SH5 |
            | IMAGE_FILE_MACHINE_THUMB | 0x1c2 | Thumb |
            | IMAGE_FILE_MACHINE_WCEMIPSV2 | 0x169 | MIPS little-endian WCE v2 |";
    }
}
