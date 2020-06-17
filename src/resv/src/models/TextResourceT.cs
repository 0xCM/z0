//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    /// <summary>
    /// Describes/models a literal text resource with an enum-predicated identity
    /// </summary>
    public readonly struct TextResource<E> : ITextResource<E>
        where E : unmanaged, Enum
    {
        /// <summary>
        /// The resource identifier
        /// </summary>
        public E Identifier {get;}

        /// <summary>
        /// The resource address
        /// </summary>
        public MemoryAddress Location {get;}
    
        /// <summary>
        /// The resource value extracted from the accompanying location
        /// </summary>
        public string Content {get;}    
        
        [MethodImpl(Inline)]
        public TextResource(E id, MemoryAddress location, string value)
        {
            Identifier = id;
            Location = location;
            Content = value;
        }
    }
}