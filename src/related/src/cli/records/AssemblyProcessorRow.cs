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
        [Record(CliTableKind.AssemblyProcessor), StructLayout(LayoutKind.Sequential)]
        public struct AssemblyProcessorRow : ICliRecord<AssemblyProcessorRow>
        {
            public CliRowKey<AssemblyProcessor> Key;

        }
    }
}