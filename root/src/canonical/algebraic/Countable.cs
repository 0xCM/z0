//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface ICountable
    {
        ulong Count {get;}
    }

    public interface ICountable<T> : ICountable
        where T : unmanaged
    {
        new T Count {get;}

        ulong ICountable.Count
        {
            [MethodImpl(Inline)]
            get => Cast.to<T,ulong>(Count);
        }
    }
}