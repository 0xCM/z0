//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IIdentity
    {
        string Identifier {get;}

        bool IsEmpty 
            => string.IsNullOrWhiteSpace(Identifier);
    }

    public interface IIdentity<T> :  IIdentity, IEquatable<T>
        where T : struct, IIdentity<T>
    {
        bool IEquatable<T>.Equals(T src)
            => string.Equals(src.Identifier, Identifier, StringComparison.InvariantCultureIgnoreCase);        
    }
}