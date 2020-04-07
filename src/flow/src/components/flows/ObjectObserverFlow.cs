//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    readonly struct ObjectObserverFlow<T> : IObjectObserverFlow<T>
        where T : class
    {

    }

    readonly struct ObjectObserverFlow<P, T> : IObjectObserverFlow<P, T>
        where T : class
        where P : IObjectObserverPipe<T>
    {

    }    
}