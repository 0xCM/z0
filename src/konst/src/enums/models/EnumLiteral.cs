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

    /// <summary>
    /// Defines a boxed enumeration literal as the triple (index,identifier,value)
    /// </summary>
    public readonly struct EnumLiteral
    {        
        /// <summary>
        /// THe literal's surrogate identifier
        /// </summary>
        public readonly ArtifactIdentity Id;

        /// <summary>
        /// The name of the declaring type
        /// </summary>
        public readonly StringRef TypeName;

        /// <summary>
        /// The handle of the declaring type
        /// </summary>
        public readonly MemoryAddress TypeHandle;

        /// <summary>
        /// The enum's numeric data type
        /// </summary>
        public readonly EnumScalarKind DataType;

        /// <summary>
        /// The literal declaration order, unique within the declaring enum
        /// </summary>
        public readonly uint Position;

        /// <summary>
        /// The literal identifier, unique within the declaring enum
        /// </summary>
        public readonly StringRef Name;

        /// <summary>
        /// The literal value
        /// </summary>
        public readonly variant Value;

        [MethodImpl(Inline)]
        public EnumLiteral(FieldInfo field, EnumScalarKind kind, uint index, StringRef name, variant value)
        {            
            Id = field.MetadataToken;
            TypeName = field.DeclaringType.Name;
            TypeHandle = field.DeclaringType.TypeHandle.Value;
            Name = name;
            DataType = kind;
            Position = index;
            Value = value;
        }           
    }
}