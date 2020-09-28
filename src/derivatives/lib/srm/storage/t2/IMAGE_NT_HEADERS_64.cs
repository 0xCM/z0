//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Runtime.InteropServices;

    [Url(
        "https://docs.microsoft.com/en-us/windows/win32/api/winnt/ns-winnt-image_nt_headers64",
        "https://www.pinvoke.net/default.aspx/Structures/IMAGE_NT_HEADERS.html"
    )]
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct IMAGE_NT_HEADERS_64
    {

        [FieldOffset(0)]
        public uint Signature;

        [FieldOffset(4)]
        public IMAGE_FILE_HEADER FileHeader;

        [FieldOffset(24)]
        public IMAGE_OPTIONAL_HEADER_64 OptionalHeader;
    }
}