//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface ICounted
    {
        ulong Count {get;}
    }

    public interface ICounted<T> : ICounted
        where T : unmanaged
    {
        new T Count {get;}

        ulong ICounted.Count
        {
            [MethodImpl(Inline)]
            get => Cast.to<T,ulong>(Count);
        }
    }
}