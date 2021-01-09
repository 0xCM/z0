//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Windows
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct MINIDUMP_DIRECTORY
    {
        public MinidumpStreamType StreamType;

        public MINIDUMP_LOCATION_DESCRIPTOR Location;
    }
}