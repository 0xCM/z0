//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static IdentityCommons;

    public interface IIdentity : ICustomFormattable, IComparable
    {
        string Identifier {get;}

        bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => text.empty(Identifier);
        }
        
        [MethodImpl(Inline)]
        string ICustomFormattable.Format()
            => IdentityFormat(this);
        
        [MethodImpl(Inline)]
        int IComparable.CompareTo(object src)
            => IdentityCompare(this, src as IIdentity);
    }

    public interface IIdentity<T> :  IIdentity, IEquatable<T>, IFormattable<T>, IComparable<T>
        where T : IIdentity<T>, new()
    {
        [MethodImpl(Inline)]
        bool IEquatable<T>.Equals(T src)
            => IdentityEquals(this, src);

        [MethodImpl(Inline)]
        int IComparable<T>.CompareTo(T src)
            => IdentityCompare(this, src);
    }    
}