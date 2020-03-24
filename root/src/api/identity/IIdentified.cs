//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    
    public interface IIdentifiedTarget : IIdentified, ICustomFormattable, IComparable
    {
        IdentityTargetKind TargetKind  => IdentityTargetKind.Type;

        [MethodImpl(Inline)]
        string ICustomFormattable.Format()
            => text.denullify(Identifier);

        [MethodImpl(Inline)]
        int IComparable.CompareTo(object src)
            => text.denullify(Identifier).CompareTo((src as IIdentified)?.Identifier);
    }

    /// <summary>
    /// Specifies what it means to be a reified identifier
    /// </summary>
    public interface IIdentifiedTarget<T> :  IIdentifiedTarget, IEquatable<T>, IFormattable<T>, IComparable<T>
        where T : IIdentifiedTarget<T>, new()
    {
        [MethodImpl(Inline)]
        bool IEquatable<T>.Equals(T src)
            => text.equals(Identifier, src?.Identifier);

        [MethodImpl(Inline)]
        int IComparable<T>.CompareTo(T src)
            => text.denullify(Identifier).CompareTo(src?.Identifier); 
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

    public interface ISegmentedIdentity : IIdentifiedType<SegmentedIdentity>
    {

    }

    public interface IPrimalIdentity : IIdentifiedType<PrimalIdentity>
    {

    }

    public interface IIdentifiedEnum : IIdentifiedType<EnumIdentity>
    {

    }

    public interface INumericIdentity : IIdentifiedType<NumericIdentity>
    {

        
    }    
}