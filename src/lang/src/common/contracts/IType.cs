//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;

    public interface IType
    {

    }

    public interface IType<T>
        where T : struct, IType<T>
    {

    }

    public interface IType<K,T>
        where T : struct, IType<T>
        where K : unmanaged, Enum, IEquatable<K>
    {
        K Kind {get;}
    }

}