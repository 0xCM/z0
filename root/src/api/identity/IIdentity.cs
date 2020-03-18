//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Root;
    
    /// <summary>
    /// Specifies what it means to be an identifier
    /// </summary>
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
            => text.denullify(Identifier);

        [MethodImpl(Inline)]
        int IComparable.CompareTo(object src)
            => text.denullify(Identifier).CompareTo((src as IIdentity)?.Identifier);
    }

    /// <summary>
    /// Specifies what it means to be a reified identifier
    /// </summary>
    public interface IIdentity<T> :  IIdentity, IEquatable<T>, IFormattable<T>, IComparable<T>
        where T : IIdentity<T>, new()
    {
        [MethodImpl(Inline)]
        bool IEquatable<T>.Equals(T src)
            => text.equals(Identifier, src?.Identifier);

        [MethodImpl(Inline)]
        int IComparable<T>.CompareTo(T src)
            => text.denullify(Identifier).CompareTo(src?.Identifier); 
    }    
}