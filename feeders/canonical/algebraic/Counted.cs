//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public interface ICounted
    {
        ulong Count {get;}
    }

    public interface ICounted<T> : ICounted
        where T : unmanaged
    {
        new T Count {get;}

    }
}