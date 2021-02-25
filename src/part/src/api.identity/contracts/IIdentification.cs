//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IIdentification : IIdentified, ITextual, IComparable
    {
        IdentityTargetKind TargetKind
            => IdentityTargetKind.Type;

        protected string DenullifiedIdentity
            => text.denullify(Identifier);

        bool Same(object src)
            => src is IIdentification t && string.Equals(Identifier, t.Identifier, StringComparison.InvariantCultureIgnoreCase);

        string ITextual.Format()
            => text.denullify(Identifier);

        int IComparable.CompareTo(object src)
            => text.denullify(Identifier).CompareTo((src as IIdentified)?.Identifier);
    }

    /// <summary>
    /// Specifies what it means to be a reified identifier
    /// </summary>
    [Free]
    public interface IIdentification<T> : IIdentification, IEquatable<T>, IComparable<T>
        where T : IIdentification<T>, new()
    {
        bool IEquatable<T>.Equals(T src)
            => Same(src);

        int IComparable<T>.CompareTo(T src)
            => text.denullify(Identifier).CompareTo(src.Identifier);
    }
}