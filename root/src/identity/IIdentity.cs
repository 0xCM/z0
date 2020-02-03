//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static RootShare;

    public interface IIdentity
    {
        string Identifier {get;}

        bool IsEmpty 
            => string.IsNullOrWhiteSpace(Identifier);
    }

    public interface IIdentity<T> :  IIdentity, IEquatable<T>
        where T : struct, IIdentity<T>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        bool IEquatable<T>.Equals(T src)
            => IdentityEquals(Identifier,src.Identifier);        
    }
}