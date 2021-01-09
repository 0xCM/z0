//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Windows
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// https://docs.microsoft.com/en-us/windows/win32/api/minidumpapiset/ns-minidumpapiset-minidump_module_list
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct MINIDUMP_MODULE_LIST
    {
        public uint  NumberOfModules;

        public MINIDUMP_MODULE* Modules;
    }
}