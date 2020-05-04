//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Enumerates the identifiable things
    /// </summary>
    public enum IdentityTargetKind
    {
        None = 0,

        /// <summary>
        /// Designates type identity
        /// </summary>
        Type = 2,

        /// <summary>
        /// Designates operation identity
        /// </summary>
        Method = 4,
    }

    public interface IIdentification : IIdentified, ITextual, IComparable
    {
        IdentityTargetKind TargetKind  
            => IdentityTargetKind.Type;

        protected string DenullifiedIdentity 
            => IdentityText ?? string.Empty;

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
            => DenullifiedIdentity.CompareTo((src as IIdentified)?.IdentityText);
    }

    /// <summary>
    /// Specifies what it means to be a reified identifier
    /// </summary>
    public interface IIdentification<T> :  IIdentification, IEquatable<T>, IComparable<T>
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