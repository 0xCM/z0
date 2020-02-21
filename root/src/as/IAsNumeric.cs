//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static Root;

    public interface IAsNumeric<S,T> : IAs<S,T>
        where T : unmanaged
        
    {

    }

    public interface IAsNumeric<R,S,T> : IAsNumeric<S,T>
        where T : unmanaged
        where R : unmanaged, IAsNumeric<R,S,T>
        
    {

    }
}