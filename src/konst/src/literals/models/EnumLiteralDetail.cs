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
    /// Defines a boxed enumeration literal as the triple (index,identifier,value)
    /// </summary>
    public struct EnumLiteralDetail
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
        /// The primal kind specialized by the enum
        /// </summary>
        public EnumScalarKind PrimalKind;

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