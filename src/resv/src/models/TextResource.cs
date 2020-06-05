//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    /// <summary>
    /// Describes/models a literal text resource
    /// </summary>
    public readonly struct TextResource : ITextResource
    {
        /// <summary>
        /// The resource identifier
        /// </summary>
        public readonly ulong Identifier {get;}

        /// <summary>
        /// The resource address
        /// </summary>
        public MemoryAddress Location {get;}
    
        /// <summary>
        /// The resource value extracted from the accompanying location
        /// </summary>
        public string Content {get;}

        [MethodImpl(Inline)]
        public static TextResource Define(ulong id, MemoryAddress location, string value)
            => new TextResource(id,location,value);

        [MethodImpl(Inline)]
        public static TextResource<E> Define<E>(E id, MemoryAddress location, string value)
            where E : unmanaged, Enum
                => new TextResource<E>(id,location,value);
       
        [MethodImpl(Inline)]
        public TextResource(ulong id, MemoryAddress location, string value)
        {
            Identifier = id;
            Location = location;
            Content = value;
        }
    }
}