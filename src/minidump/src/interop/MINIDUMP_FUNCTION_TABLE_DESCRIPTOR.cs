//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Windows
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// https://docs.microsoft.com/en-us/windows/win32/api/minidumpapiset/ns-minidumpapiset-minidump_function_table_descriptor
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MINIDUMP_FUNCTION_TABLE_DESCRIPTOR
    {
        public ulong MinimumAddress;

        public ulong MaximumAddress;

        public ulong BaseAddress;

        public uint EntryCount;

        public uint SizeOfAlignPad;
    }
}