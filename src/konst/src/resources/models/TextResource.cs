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

        ulong ITextResource.Location
            => Location;

        [MethodImpl(Inline)]
        public TextResource(ulong id, MemoryAddress location, string value)
        {
            Identifier = id;
            Location = location;
            Content = value;
        }
    }
}