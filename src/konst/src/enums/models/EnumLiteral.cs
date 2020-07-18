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

    public enum EnumLiteralField : uint
    {
        Id = 0 | 10 << WidthOffset,

        TypeHandle = 1 | 16 << WidthOffset,

        TypeId = 2 | 10 << WidthOffset,

        TypeName = 3 | 30 << WidthOffset,

        DataType = 4 | 16 << WidthOffset,

        Position = 5 | 10 << WidthOffset,

        Name = 6 | 30 << WidthOffset,

        Value = 7 | 8 << WidthOffset,
    }
    
    /// <summary>
    /// Defines a boxed enumeration literal as the triple (index,identifier,value)
    /// </summary>
    public struct EnumLiteral
    {        
        /// <summary>
        /// The literal's surrogate identifier
        /// </summary>
        public ArtifactIdentity Id;

        /// <summary>
        /// The handle of the declaring type
        /// </summary>
        public MemoryAddress TypeHandle;

        /// <summary>
        /// The types's surrogate identifier
        /// </summary>
        public ArtifactIdentity TypeId;

        /// <summary>
        /// The name of the declaring type
        /// </summary>
        public StringRef TypeName;
        
        /// <summary>
        /// The enum's numeric data type
        /// </summary>
        public EnumScalarKind DataType;

        /// <summary>
        /// The literal declaration order, unique within the declaring enum
        /// </summary>
        public uint Position;

        /// <summary>
        /// The literal identifier, unique within the declaring enum
        /// </summary>
        public StringRef Name;

        /// <summary>
        /// The literal value
        /// </summary>
        public variant Value;
    }
}