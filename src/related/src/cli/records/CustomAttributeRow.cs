//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct CliRecords
    {
        [Record(CliTableKind.CustomAttribute), StructLayout(LayoutKind.Sequential)]
        public struct CustomAttributeRow  : IRecord<CustomAttributeRow>
        {
            public CliRowKey Key;

            public CliRowKey Parent;

            /// <summary>
            /// An index into the <see cref='MethodDefRow'/> or <see cref='MemberRefRow'/> table
            /// </summary>
            public CliRowKey Type;

            public BlobIndex Value;
        }
    }
}