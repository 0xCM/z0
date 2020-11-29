//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

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

        public string Name
        {
            [MethodImpl(Inline)]
            get => Definition.Name;
        }

        public ClrType RecordType
        {
            [MethodImpl(Inline)]
            get => Definition.DeclaringType;
        }

        public ClrType DataType
        {
            [MethodImpl(Inline)]
            get => Definition.FieldType;
        }

        public MemoryAddress HandleAddress
        {
            [MethodImpl(Inline)]
            get => Definition.HandleAddress;
        }
    }
}