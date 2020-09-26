//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ResourceDirectory
    {
        public uint Charecteristics;

        public uint TimeDateStamp;

        public short MajorVersion;

        public short MinorVersion;

        public short NumberOfNamedEntries;

        public short NumberOfIdEntries;
    }
}