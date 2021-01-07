//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Identifies a resource, its data type, and specifies the memory segment it occupies
    /// </summary>
    public readonly struct ResIdentity
    {
        /// <summary>
        /// The resource name, relative to the enclosing type
        /// </summary>
        public Name Name {get;}

        /// <summary>
        /// The memory segment occupied by the resource
        /// </summary>
        public MemorySegment Segment {get;}

        /// <summary>
        /// The resource data type
        /// </summary>
        public ClrPrimalKind DataType {get;}

        [MethodImpl(Inline)]
        public ResIdentity(Name name, MemorySegment seg, ClrPrimalKind type)
        {
            Name = name;
            Segment = seg;
            DataType = type;
        }
    }
}