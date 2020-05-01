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

    using static Seed;

    public interface IPartId : ITextual
    {
        /// <summary>
        /// The part identifier literal value
        /// </summary>
        PartId Id {get;}

    }

    public interface IPartId<P> : IPartId, ITypedLiteral<PartId>, IEquatable<P>
        where P : IPartId, new()
    {
        PartId ITypedLiteral<PartId>.Class => Id;
    }
}