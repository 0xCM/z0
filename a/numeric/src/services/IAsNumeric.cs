//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IAs<S,T>
    {
        T As(S src);
    }
    
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