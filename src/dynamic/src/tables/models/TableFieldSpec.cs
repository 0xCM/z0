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
    /// Characterizes a field in a record
    /// </summary>
    public readonly struct TableFieldSpec
    {
        public readonly string Name;

        public readonly ushort Position;

        public readonly Address16 Offset;

        public readonly string FieldTypeName;

        [MethodImpl(Inline)]
        public TableFieldSpec(string name, ushort pos, Address16 offset, string type)
        {
            Name = name;
            Position = pos;
            Offset = offset;
            FieldTypeName = type;
        }
    }
}