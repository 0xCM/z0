//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Describes a column in a table
    /// </summary>
    public struct RecordField
    {
        /// <summary>
        /// The defining field
        /// </summary>
        public ClrField Definition;

        /// <summary>
        /// The 0-based, declaration order of the field
        /// </summary>
        public ushort FieldIndex;

        /// <summary>
        /// The field name
        /// </summary>
        public string Name
        {
            [MethodImpl(Inline)]
            get => Definition.Name;
        }

        /// <summary>
        /// The field datatype
        /// </summary>
        public ClrType DataType
        {
            [MethodImpl(Inline)]
            get => Definition.FieldType;
        }
    }
}