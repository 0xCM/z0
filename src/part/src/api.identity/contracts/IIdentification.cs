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

        int HashCode
            => DenullifiedIdentity.GetHashCode();

        bool Same(object src)
            => src is IIdentification t && string.Equals(DenullifiedIdentity, t.DenullifiedIdentity, StringComparison.InvariantCultureIgnoreCase);

        string ITextual.Format()
            => text.denullify(Identifier);

        int IComparable.CompareTo(object src)
            => DenullifiedIdentity.CompareTo((src as IIdentified)?.Identifier);
    }

    /// <summary>
    /// Specifies what it means to be a reified identifier
    /// </summary>
    [Free]
    public interface IIdentification<T> : IIdentification, IEquatable<T>, IComparable<T>
        where T : IIdentification<T>, new()
    {
        bool IEquatable<T>.Equals(T src)
            => DenullifiedIdentity.Equals(src.DenullifiedIdentity);

        int IComparable<T>.CompareTo(T src)
            => DenullifiedIdentity.CompareTo(src.DenullifiedIdentity);
    }
}