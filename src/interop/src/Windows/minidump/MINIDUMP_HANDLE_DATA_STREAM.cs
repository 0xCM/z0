//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Windows
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct MINIDUMP_HANDLE_DATA_STREAM
    {
        public uint SizeOfHeader;

        public uint SizeOfDescriptor;

        public uint NumberOfDescriptors;

        public uint Reserved;
    }
}