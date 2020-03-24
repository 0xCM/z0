//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Components;

    /// <summary>
    /// Specifies what it means to be an identifier
    /// </summary>
    public interface IIdentified
    {        
        string Identifier {get;}

        bool IsEmpty 
        {
            get => string.IsNullOrWhiteSpace(Identifier);
        }               
    }

    public interface IIdentifiedTarget : IIdentified, ICustomFormattable, IComparable
    {
        IdentityTargetKind TargetKind  => IdentityTargetKind.Type;

        protected string DenullifiedIdentity => Identifier ?? string.Empty;

        [MethodImpl(Inline)]
        string ICustomFormattable.Format() => DenullifiedIdentity;

        int IComparable.CompareTo(object src)
            => DenullifiedIdentity.CompareTo((src as IIdentified)?.Identifier);
    }

    /// <summary>
    /// Specifies what it means to be a reified identifier
    /// </summary>
    public interface IIdentifiedTarget<T> :  IIdentifiedTarget, IEquatable<T>, IComparable<T>
        where T : IIdentifiedTarget<T>, new()
    {
        [MethodImpl(Inline)]
        bool IEquatable<T>.Equals(T src)
            => DenullifiedIdentity.Equals(src.DenullifiedIdentity);

        [MethodImpl(Inline)]
        int IComparable<T>.CompareTo(T src)
            => DenullifiedIdentity.CompareTo(src.DenullifiedIdentity);
    }    

    public interface IIdentfiedOp : IIdentifiedTarget
    {
        IdentityTargetKind IIdentifiedTarget.TargetKind => IdentityTargetKind.Method;
    }
    
    public interface IIdentifedOp<T> : IIdentfiedOp, IIdentifiedTarget<T>
        where T : IIdentifedOp<T>, new()    
    {
        Func<string,T> Factory {get;}
    }

    public interface IIdentifiedType : IIdentifiedTarget
    {
        IdentityTargetKind IIdentifiedTarget.TargetKind => IdentityTargetKind.Type;

    }
    
    public interface IIdentifiedType<T> : IIdentifiedType, IIdentifiedTarget<T>
        where T : IIdentifiedType<T>, new()    
    {

    }
}