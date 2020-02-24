//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    public interface IIdentity : IComparable<IIdentity>, ICustomFormattable
    {
        string Identifier {get;}

        bool IsEmpty 
            => string.IsNullOrWhiteSpace(Identifier);
        
        string ICustomFormattable.Format()
            => Identifier.ToString();
    }

    public interface IIdentity<T> :  IIdentity, IEquatable<T>, IFormattable<T>
        where T : struct, IIdentity<T>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        bool IEquatable<T>.Equals(T src)
            => IdentityEquals(Identifier,src.Identifier);                
    }    
}        
