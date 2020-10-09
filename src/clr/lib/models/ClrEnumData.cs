//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public struct ClrEnumData
    {
        /// <summary>
        /// The metadata token that identifies the backing field
        /// </summary>
        public ClrArtifactKey Key
        {
            [MethodImpl(Inline)]
            get => BackingField;
        }

        /// <summary>
        /// The compiler-emitted field that defines the literal
        /// </summary>
        public FieldInfo BackingField;

        /// <summary>
        /// The kind of primitive specialized by the enum
        /// </summary>
        public EnumScalarKind PrimalKind;

        /// <summary>
        /// The literal declaration order, unique within the declaring enum
        /// </summary>
        public uint Position;

        /// <summary>
        /// The literal identifier, unique within the declaring enum
        /// </summary>
        public string Name;

        /// <summary>
        /// The literal E-value
        /// </summary>
        public ulong LiteralValue;

        /// <summary>
        /// The system data type
        /// </summary>
        public Type DataType;

    }
}