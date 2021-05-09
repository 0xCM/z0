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
        [Record(CliTableKind.AssemblyOS), StructLayout(LayoutKind.Sequential)]
        public struct AssemblyOSRow : ICliRecord<AssemblyOSRow>
        {
            public CliRowKey Key;

        }
    }
}