//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Windows
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct MINIDUMP_LOCATION_DESCRIPTOR
    {
        public uint DataSize;

        public uint Rva;
    }
}