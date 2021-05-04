//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct ImageRecords
    {
        /// <summary>
        /// Stores compile-time, constant values for fields, parameters, and propertie
        /// </summary>
        [Record(CliTableKind.Constant), StructLayout(LayoutKind.Sequential)]
        public struct ConstantRow : IRecord<ConstantRow>
        {
            public RowKey Key;

            public byte Type;

            /// <summary>
            /// An index into one of: <see cref='ParamRow'/>, <see cref='FieldRow'/>, <see cref='PropertyRow'/>
            /// </summary>
            public RowKey Parent;

            public BlobIndex Value;
        }
    }
}