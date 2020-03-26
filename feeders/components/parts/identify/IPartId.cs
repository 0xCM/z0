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

    public interface IPartId : ICustomFormattable
    {
        /// <summary>
        /// The part identifier literal value
        /// </summary>
        PartId Id {get;}

        string Formatted => Id.Format();

        string ICustomFormattable.Format() => Formatted;
    }

    public interface IPartId<P> : IPartId, ITypedLiteral<PartId>, IEquatable<P>
        where P : IPartId, new()
    {
        PartId ITypedLiteral<PartId>.Class => Id;

        [MethodImpl(Inline)]
        bool IEquatable<P>.Equals(P src)
            => this.Id == src.Id;

        int HashCode
            => Id.GetHashCode();     
    }


}