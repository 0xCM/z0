//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Components;

    /// <summary>
    /// Canonical reification of type-level part identifiers
    /// </summary>
    public readonly struct IdentifiedPart<P> : IPartId<P>
        where P : IPartId<P>, new()
    {
        [MethodImpl(Inline)]
        public static implicit operator PartId(IdentifiedPart<P> id)
            => id.Id;

        [MethodImpl(Inline)]
        public static implicit operator IdentifiedPart<P>(P part)
            => new IdentifiedPart<P>(part.Id);

        [MethodImpl(Inline)]
        public static implicit operator P(IdentifiedPart<P> part)
            => default(P);

        [MethodImpl(Inline)]
        public static implicit operator IdentifiedPart<P>(PartId id)
            => new IdentifiedPart<P>(id);
        
        [MethodImpl(Inline)]
        public IdentifiedPart(PartId id)
        {
            this.Id = id;
        }

        public PartId Id {get;}
    }

}