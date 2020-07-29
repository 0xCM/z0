//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct IMAGE_SECTION_HEADER
    {
        public string Name
        {
            get
            {
                fixed (byte* ptr = NameBytes)
                {
                    if (ptr[7] == 0)
                        return Marshal.PtrToStringAnsi((IntPtr)ptr)!;

                    return Marshal.PtrToStringAnsi((IntPtr)ptr, 8);
                }
            }
        }

        public fixed byte NameBytes[8];
        
        public uint VirtualSize;
        
        /// <summary>
        /// The address of the first byte of the section when loaded into memory, relative to the image base. For object files, this is the address of the first byte before relocation is applied.
        /// </summary>
        public uint VirtualAddress;

        /// <summary>
        /// The size of the initialized data on disk, in bytes. This value must be a multiple of the <see cref="IMAGE_OPTIONAL_HEADER.FileAlignment"/> member of the <see cref="IMAGE_OPTIONAL_HEADER"/> structure. If this value is less than the VirtualSize member, the remainder of the section is filled with zeroes. If the section contains only uninitialized data, the member is zero.
        /// </summary>
        public uint SizeOfRawData;

        /// <summary>
        /// A file pointer to the first page within the COFF file. This value must be a multiple of the <see cref="IMAGE_OPTIONAL_HEADER.FileAlignment"/> member of the <see cref="IMAGE_OPTIONAL_HEADER "/> structure. If a section contains only uninitialized data, set this member is zero.
        /// </summary>
        public uint PointerToRawData;

        /// <summary>
        /// A file pointer to the beginning of the relocation entries for the section.If there are no relocations, this value is zero.
        /// </summary>
        public uint PointerToRelocations;

        /// <summary>
        /// A file pointer to the beginning of the line-number entries for the section. If there are no COFF line numbers, this value is zero.
        /// </summary>
        public uint PointerToLinenumbers;

        /// <summary>
        /// The number of relocation entries for the section. This value is zero for executable images.
        /// </summary>
        public ushort NumberOfRelocations;

        /// <summary>
        /// The number of line-number entries for the section.
        /// </summary>
        public ushort NumberOfLinenumbers;

        /// <summary>
        /// The characteristics of the image.
        /// </summary>
        public CharacteristicsType Characteristics;
    }
}