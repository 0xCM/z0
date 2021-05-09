//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [Record(CliTableKind.CustomAttribute), StructLayout(LayoutKind.Sequential)]
        public struct CustomAttributeRow  : ICliRecord<CustomAttributeRow>
        {
            public CliRowKey<CustomAttribute> Key;

            public CliRowKey Parent;

            /// <summary>
            /// An index into the <see cref='MethodDefRow'/> or <see cref='MemberRefInfo'/> table
            /// </summary>
            public CliRowKey Type;

            public BlobIndex Value;
        }
    }
}