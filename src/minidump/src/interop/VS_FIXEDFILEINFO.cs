//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Windows
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// https://docs.microsoft.com/en-us/windows/win32/api/verrsrc/ns-verrsrc-vs_fixedfileinfo
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct VS_FIXEDFILEINFO
    {
        public uint dwSignature;

        public uint dwStrucVersion;

        public uint dwFileVersionMS;

        public uint dwFileVersionLS;

        public uint dwProductVersionMS;

        public uint dwProductVersionLS;

        public uint dwFileFlagsMask;

        public uint dwFileFlags;

        public uint dwFileOS;

        public uint dwFileType;

        public uint dwFileSubtype;

        public uint dwFileDateMS;

        public uint dwFileDateLS;
    }

    /*
        dwSignature

        Type: DWORD

        Contains the value 0xFEEF04BD. This is used with the szKey member of the VS_VERSIONINFO structure when searching a file for the VS_FIXEDFILEINFO structure.

        dwStrucVersion

        Type: DWORD

        The binary version number of this structure. The high-order word of this member contains the major version number, and the low-order word contains the minor version number.

        dwFileVersionMS

        Type: DWORD

        The most significant 32 bits of the file's binary version number. This member is used with dwFileVersionLS to form a 64-bit value used for numeric comparisons.

        dwFileVersionLS

        Type: DWORD

        The least significant 32 bits of the file's binary version number. This member is used with dwFileVersionMS to form a 64-bit value used for numeric comparisons.

        dwProductVersionMS

        Type: DWORD

        The most significant 32 bits of the binary version number of the product with which this file was distributed. This member is used with dwProductVersionLS to form a 64-bit value used for numeric comparisons.

        dwProductVersionLS

        Type: DWORD

        The least significant 32 bits of the binary version number of the product with which this file was distributed. This member is used with dwProductVersionMS to form a 64-bit value used for numeric comparisons.

        dwFileFlagsMask

        Type: DWORD

        Contains a bitmask that specifies the valid bits in dwFileFlags. A bit is valid only if it was defined when the file was created.

        dwFileFlags

        Type: DWORD


        If dwFileType is VFT_VXD, dwFileSubtype contains the virtual device identifier included in the virtual device control block.

        All dwFileSubtype values not listed here are reserved.

        dwFileDateMS

        Type: DWORD

        The most significant 32 bits of the file's 64-bit binary creation date and time stamp.

        dwFileDateLS

        Type: DWORD

        The least significant 32 bits of the file's 64-bit binary creation date and time stamp.

    */
}