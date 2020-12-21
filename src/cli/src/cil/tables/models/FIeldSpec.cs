//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct CilTables
    {
        /// <summary>
        /// Defines a field
        /// </summary>
        public readonly struct FieldSpec
        {
            /// <summary>
            /// The field's name
            /// </summary>
            public MemberName FieldName {get;}

            /// <summary>
            /// The assembly-qualified name of the field data type
            /// </summary>
            public TypeName TypeName {get;}

            /// <summary>
            /// The field's declearation order within the declaring type
            /// </summary>
            public ushort Position {get;}

            /// <summary>
            /// The 0-based offset address of the field in the context of a type with explicit layout; otherwise ignored
            /// </summary>
            public ushort Offset {get;}

            [MethodImpl(Inline)]
            public FieldSpec(MemberName name, TypeName type, ushort pos, ushort offset = default)
            {
                TypeName = type;
                FieldName = name;
                Position = pos;
                Offset = offset;
            }

            public string Format()
                => CilTables.format(this);

            public override string ToString()
                => Format();
        }
    }
}