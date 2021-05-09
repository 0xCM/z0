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
        /// <summary>
        /// Stores compile-time, constant values for fields, parameters, and propertie
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct ConstantRow : ICliRecord<ConstantRow,Constant>
        {
            public CliRowKey<Constant> Key;

            public byte Type;

            /// <summary>
            /// An index into one of: <see cref='ParamRow'/>, <see cref='FieldRow'/>, <see cref='PropertyRow'/>
            /// </summary>
            public CliRowKey Parent;

            public BlobIndex Value;
        }
    }
}