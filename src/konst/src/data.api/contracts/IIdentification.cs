//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IIdentification : IIdentified, ITextual, IComparable
    {
        IdentityTargetKind TargetKind
            => IdentityTargetKind.Type;

        protected string DenullifiedIdentity
            => Identifier ?? string.Empty;

        int HashCode
            => DenullifiedIdentity.GetHashCode();

        bool Same(object src)
            => src is IIdentification t
            && string.Equals(DenullifiedIdentity, t.DenullifiedIdentity,
                    StringComparison.InvariantCultureIgnoreCase);

        [MethodImpl(Inline)]
        string ITextual.Format()
            => DenullifiedIdentity;

        int IComparable.CompareTo(object src)
            => DenullifiedIdentity.CompareTo((src as IIdentified)?.Identifier);
    }

    /// <summary>
    /// Specifies what it means to be a reified identifier
    /// </summary>
    public interface IIdentification<T> : IIdentification, IEquatable<T>, IComparable<T>
        where T : IIdentification<T>, new()
    {
        [MethodImpl(Inline)]
        bool IEquatable<T>.Equals(T src)
            => DenullifiedIdentity.Equals(src.DenullifiedIdentity);

        [MethodImpl(Inline)]
        int IComparable<T>.CompareTo(T src)
            => DenullifiedIdentity.CompareTo(src.DenullifiedIdentity);
    }

}