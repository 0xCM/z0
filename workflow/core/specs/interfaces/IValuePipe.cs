//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    public interface IValuePipe : IPipe
    {
        
    }

    public interface IValuePipe<T> : IValuePipe
        where T : struct
    {
        
    }


    public interface IValuePipe<S,T>  : IValuePipe
        where T : struct
        where S : struct
    {

    }
}