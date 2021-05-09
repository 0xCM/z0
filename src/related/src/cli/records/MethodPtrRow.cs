//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;
    using System.Reflection;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [Record(CliTableKind.MethodPtr), StructLayout(LayoutKind.Sequential)]
        public struct MethodPtrRow : ICliRecord<MethodPtrRow>
        {
            public CliRowKey<MethodPtr> Key;

        }
    }
}