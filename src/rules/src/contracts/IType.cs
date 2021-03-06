//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IType
    {
        string Name  => "";
    }

    public interface IType<T> : IType
        where T : IType<T>, new()
    {

    }

    public interface IType<K,T> : IType<T>
        where T : struct, IType<T>
        where K : unmanaged, Enum, IEquatable<K>
    {
        K Kind {get;}
    }
}