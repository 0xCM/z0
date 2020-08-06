//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    
    using Z0.MS;

    [Table("https://docs.microsoft.com/en-us/windows/win32/api/dbghelp/ns-dbghelp-loaded_image")]
    public unsafe struct LOADED_IMAGE_64
    {
        /// <summary>
        /// The file name of the mapped file.
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)]
        public string ModuleName;

        /// <summary>
        /// A handle to the mapped file.
        /// </summary>
        public IntPtr hFile;

        /// <summary>
        /// The base address of the mapped file.
        /// </summary>
        public byte* MappedAddress;

        /// <summary>
        /// A pointer to an IMAGE_NT_HEADERS structure.
        /// </summary>
        public IMAGE_NT_HEADERS_64* FileHeader;

        /// <summary>
        /// A pointer to an IMAGE_SECTION_HEADER structure.
        /// </summary>
        public IMAGE_SECTION_HEADER* LastRvaSection;

        /// <summary>
        /// The number of COFF section headers.
        /// </summary>
        public int NumberOfSections;

        /// <summary>
        /// A pointer to an IMAGE_SECTION_HEADER structure.
        /// </summary>
        public IMAGE_SECTION_HEADER* Sections;

        /// <summary>
        /// The image characteristics value.
        /// </summary>
        public LOADED_IMAGE_SCN Characteristics;

        byte fSystemImageByte;

        byte fDOSImageByte;

        byte fReadOnlyByte;

        /// <summary>
        /// The version string.
        /// Prior to Windows Vista:  This member is not included in the structure.
        /// </summary>
        public byte Version;

        /// <summary>
        /// The list of loaded images.
        /// </summary>
        public LIST_ENTRY Links;

        /// <summary>
        /// The size of the image, in bytes.
        /// </summary>
        public uint SizeOfImage;

        /// <summary>
        /// If the image is a kernel mode executable image, this value is TRUE.
        /// </summary>
        public bool fSystemImage
        {
            get => this.fSystemImageByte != 0;
            set => this.fSystemImageByte = value ? (byte)1 : (byte)0;
        }

        /// <summary>
        /// If the image is a 16-bit executable image, this value is TRUE.
        /// </summary>
        public bool fDOSImage
        {
            get => this.fDOSImageByte != 0;
            set => this.fDOSImageByte = value ? (byte)1 : (byte)0;
        }

        /// <summary>
        /// If the image is read-only, this value is TRUE.
        /// Prior to Windows Vista:  This member is not included in the structure.
        /// </summary>
        public bool fReadOnly
        {
            get => this.fReadOnlyByte != 0;
            set => this.fReadOnlyByte = value ? (byte)1 : (byte)0;
        }
    }
}