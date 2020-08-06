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

    [Table("http://www.pinvoke.net/default.aspx/Structures/IMAGE_OPTIONAL_HEADER32.html")]
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct IMAGE_NT_HEADERS_32
    {
        [FieldOffset(0)]
        public uint Signature;

        [FieldOffset(4)]
        public IMAGE_FILE_HEADER FileHeader;

        [FieldOffset(24)]
        public IMAGE_OPTIONAL_HEADER_32 OptionalHeader;
    }
}