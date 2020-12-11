//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IPartId : ITextual
    {
        /// <summary>
        /// The part identifier
        /// </summary>
        PartId Id {get;}

        uint Hash
            => (uint)Id.GetHashCode();
        string ITextual.Format()
            => Root.format(Id);
    }

    public interface IPartId<P> : IPartId, IEquatable<P>
        where P : IPartId, new()
    {
        string ITextual.Format()
            => Root.format(Id);

        bool IEquatable<P>.Equals(P src)
            => src.Id == Id;
    }
}