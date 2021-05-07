//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    using static ImageRecords;

    partial struct CliRecords
    {
        /// <summary>
        /// Stores compile-time, constant values for fields, parameters, and propertie
        /// </summary>
        [Record(CliTableKind.Constant), StructLayout(LayoutKind.Sequential)]
        public struct ConstantRow : IRecord<ConstantRow>
        {
            public CliRowKey Key;

            public byte Type;

            /// <summary>
            /// An index into one of: <see cref='ParamRow'/>, <see cref='FieldRow'/>, <see cref='PropertyRow'/>
            /// </summary>
            public CliRowKey Parent;

            public BlobIndex Value;
        }
    }
}