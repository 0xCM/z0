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

        bool Same(object src)
            => src is IIdentification t && string.Equals(IdentityText, t.IdentityText, StringComparison.InvariantCultureIgnoreCase);

        string ITextual.Format()
            => text.denullify(IdentityText);

        int IComparable.CompareTo(object src)
            => text.denullify(IdentityText).CompareTo((src as IIdentified)?.IdentityText);
    }

    /// <summary>
    /// Specifies what it means to be a reified identifier
    /// </summary>
    [Free]
    public interface IIdentification<T> : IIdentification, IEquatable<T>, IComparable<T>
        where T : IIdentification<T>
    {
        bool IEquatable<T>.Equals(T src)
            => Same(src);

        int IComparable<T>.CompareTo(T src)
            => text.denullify(IdentityText).CompareTo(src.IdentityText);
    }
}