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
        [StructLayout(LayoutKind.Sequential)]
        public struct FieldPtrRow : ICliRecord<FieldPtrRow,FieldPtr>
        {
            public CliRowKey<FieldPtr> Key;
        }
    }
}