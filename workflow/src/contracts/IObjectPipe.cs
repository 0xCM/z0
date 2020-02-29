//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    public interface IObjectPipe : IPipe
    {
        
    }

    public interface IObjectPipe<T> : IObjectPipe
        where T : class
    {
        
    }

    public interface IObjectPipe<S,T>  : IObjectPipe
        where S : class
        where T : class
    {

    }
}