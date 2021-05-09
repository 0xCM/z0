//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Reflection;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct AssemblyOSRow : ICliRecord<AssemblyOSRow,AssemblyOS>
        {
            public CliRowKey<AssemblyOS> Key;
        }
    }
}