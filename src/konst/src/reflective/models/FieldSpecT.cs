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
    /// Defines a field
    /// </summary>
    public readonly struct FieldSpec<T>
    {
        /// <summary>
        /// The field's name
        /// </summary>
        public readonly Name FieldName;

        /// <summary>
        /// The assembly-qualified name of the field data type
        /// </summary>
        public readonly Type Type;

        /// <summary>
        /// The position of the field within the declaring type
        /// </summary>
        public readonly ushort Position;

        /// <summary>
        /// The 0-based offset address of the field
        /// </summary>
        public readonly Address16? Offset;

        [MethodImpl(Inline)]
        public static implicit operator FieldSpec(FieldSpec<T> src)
            => new FieldSpec(src.FieldName, src.TypeName, src.Position, src.Offset);

        [MethodImpl(Inline)]
        public FieldSpec(Name name, ushort pos, Address16? offset = null)
        {
            Type = typeof(T);
            FieldName = name;
            Position = pos;
            Offset = offset;
        }

        public ClrTypeName TypeName
        {
            [MethodImpl(Inline)]
            get => Type.AssemblyQualifiedName;
        }
    }
}