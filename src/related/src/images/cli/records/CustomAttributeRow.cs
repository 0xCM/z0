//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct ImageRecords
    {
        [Record(CliTableKind.CustomAttribute), StructLayout(LayoutKind.Sequential)]
        public struct CustomAttributeRow  : IRecord<CustomAttributeRow>
        {
            public RowKey Key;

            public RowKey Parent;

            /// <summary>
            /// An index into the <see cref='MethodDefRow'/> or <see cref='MemberRefRow'/> table
            /// </summary>
            public RowKey Type;

            public BlobIndex Value;
        }
    }
}