//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct FieldSpec
    {
        /// <summary>
        /// The field's name
        /// </summary>
        public readonly Name Name;

        /// <summary>
        /// The assembly-qualified name of the field data type
        /// </summary>
        public readonly FullTypeName Type;

        /// <summary>
        /// The position of the field within the declaring type
        /// </summary>
        public readonly ushort Position;

        /// <summary>
        /// The 0-based offset address of the field
        /// </summary>
        public readonly Address16? Offset;

        [MethodImpl(Inline)]
        public FieldSpec(Name name, FullTypeName type, ushort pos, Address16? offset = null)
        {
            Type = type;
            Name = name;
            Position = pos;
            Offset = offset;
        }
    }
}