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
    /// Identifies a resource, its data type, and specifies the memory segment it occupies
    /// </summary>
    public readonly struct ResIdentity
    {
        /// <summary>
        /// The resource name, relative to the enclosing type
        /// </summary>
        public asci32 Name {get;}

        /// <summary>
        /// The memory segment occupied by the resource
        /// </summary>
        public SegRef Reference {get;}
        
        /// <summary>
        /// The resource data type
        /// </summary>
        public PrimalKind DataType {get;}
        
        [MethodImpl(Inline)]
        public ResIdentity(asci32 name, SegRef memref, PrimalKind type)
        {
            Name = name;
            Reference = memref;
            DataType = type;
        }    
    }
}